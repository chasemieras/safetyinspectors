using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        FormHelper formHelper = new FormHelper();
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public StarterForm()
        {
            InitializeComponent();
        }

        private void StarterForm_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in filterInfoCollection);
            videoCaptureDevice = new VideoCaptureDevice();
        }
    }
}
