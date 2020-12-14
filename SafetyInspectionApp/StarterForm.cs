using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace SafetyInspectionApp
{
    public partial class StarterForm : Form
    {

        GoogleSheetHelper sheetHelper = new GoogleSheetHelper();
        FormSettings formSettings = new FormSettings();

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        Boolean QRFound = false;

        String[] formNames;
        String[] formLinks;

        /// <summary>
        /// Gets all needed data for the form including the Form List sheetID and all posible google forms with their links.
        /// </summary>
        /// <param name="formSettings">The layout of the form</param>
        public StarterForm(FormSettings formSettings)
        {
            sheetHelper.GetSheetID();
            this.formSettings = formSettings;
            QRFound = false;
            InitializeComponent();
            formNames = sheetHelper.getFormName();
            formLinks = sheetHelper.getFormLink();

            for (int i = 0; i < formNames.Length-1; i++)
            {
                formSelectionDropDown.Items.Add(formNames[i]);
            }
        }

        /// <summary>
        /// Is called when the form starts, finds availbe cameras and fills them into the systemCameraList dropbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StarterForm_Load(object sender, EventArgs e)
        {
            sheetHelper.GetSheetID();
            //Sets up systemCameraList with the camera options
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection) 
            {
                systemCameraList.Items.Add(filterInfo.Name);
            }

            if (systemCameraList.Items.Count > 0) 
            {
                systemCameraList.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Starts the Camera and puts it onto the display box and changes the buttons text to stop.
        /// Does refresh the image (sets to null) as if their is a QRCode stuck on the pictureBox it would not start the camera again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startCamera_Click(object sender, EventArgs e)
        {
            if (systemCameraList.Items.Count > 0)
            {
                if(videoCaptureDevice == null)
                {
                    videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[systemCameraList.SelectedIndex].MonikerString);
                }
                if (!videoCaptureDevice.IsRunning)
                {
                    startCamera.Text = "Stop";
                    cameraDisplay.Image = null;
                    videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[systemCameraList.SelectedIndex].MonikerString);
                    cameraDisplay.SizeMode = PictureBoxSizeMode.Zoom;
                    videoCaptureDevice.NewFrame += CaptureDevice_NewFrame;
                    videoCaptureDevice.Start();
                    cameraTicker.Start();
                }
                else
                {
                    startCamera.Text = "Start";
                    cameraDisplay.Refresh();
                    videoCaptureDevice.SignalToStop();
                    cameraTicker.Stop();
                }
            }
        }

        /// <summary>
        /// Updates the pictureBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraDisplay.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        /// <summary>
        /// Is the refrate rate of the QR scanner, currently is 60.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cameraTicker_Tick(object sender, EventArgs e)
        {
            if (cameraDisplay.Image != null)
            {
                var url = "";
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)cameraDisplay.Image);
                if (result != null)
                {
                    //MessageBox.Show(result.ToString());
                    if (videoCaptureDevice.IsRunning)
                    {
                        videoCaptureDevice.SignalToStop();
                    }
                    try
                    {
                        for(int i = 0; i < formLinks.Length-1; i++)
                        {
                            cameraDisplay.Refresh();
                            startCamera.Text = "Start";
                            if (result.ToString().Equals(formLinks[i])) {
                                if (!QRFound)
                                {
                                    //This is used becuase the form someitmes reddirects multiple times
                                    QRFound = true;

                                    url = result.ToString();
                                    var psi = new System.Diagnostics.ProcessStartInfo();
                                    psi.UseShellExecute = true;
                                    psi.FileName = url;
                                    System.Diagnostics.Process.Start(psi);
                                    StarterForm_FormClosing(sender, e);
                                    this.Close();
                                }
                            }
                        }
                    }
                    catch (System.ComponentModel.Win32Exception noBrowser)
                    {
                        if (noBrowser.ErrorCode == -2147467259)
                            MessageBox.Show(noBrowser.Message);
                    }
                    catch (System.Exception other)
                    {

                    }
                    videoCaptureDevice.SignalToStop();
                    cameraTicker.Stop();
                }
            }
        }

        /// <summary>
        /// Sends you to the Google From selected based on the dropdown.
        /// If it is not a valid form it does nothing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goToForm_Click(object sender, EventArgs e)
        {
            var url = "";
            for (int i = 0; i < formNames.Length - 1; i++)
            {
                if(formSelectionDropDown.SelectedItem != null)
                {
                    if (formSelectionDropDown.SelectedItem.Equals(formNames[i]))
                    {
                        url = formLinks[i];
                        var psi = new System.Diagnostics.ProcessStartInfo();
                        psi.UseShellExecute = true;
                        psi.FileName = url;
                        System.Diagnostics.Process.Start(psi);
                        StarterForm_FormClosing(sender, e);
                        this.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Is run when the Form is closed.
        /// Ensures the camera is turned off.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StarterForm_FormClosing(object sender, EventArgs e)
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning) 
            {
                videoCaptureDevice.SignalToStop();
            }
            System.Windows.Forms.Application.Exit();
        }
    }
}
