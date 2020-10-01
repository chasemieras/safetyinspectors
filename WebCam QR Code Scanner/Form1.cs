using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using BasselTech_CamCapture;
using Google.Apis.Sheets.v4;
using Google.Apis.Auth.OAuth2;
using System.IO;
using Google.Apis.Sheets.v4.Data;
using System.Threading;
using Google.Apis.Util.Store;
using Google.Apis.Services;

namespace WebCam_QR_Code_Scanner
{
    public partial class Form1 : Form
    {
        Camera cam;
        System.Windows.Forms.Timer t;
        BackgroundWorker worker;
        Bitmap CapImage;
        public Form1()
        {
            InitializeComponent();

            t = new System.Windows.Forms.Timer();
            cam = new Camera(pictureBox1);
            worker = new BackgroundWorker();

            worker.DoWork += Worker_DoWork;
            t.Tick += T_Tick;
            t.Interval = 1;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            CapImage = cam.GetBitmap();
            if (CapImage != null && !worker.IsBusy)
                worker.RunWorkerAsync();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            QRCodeDecoder Decoder = new QRCodeDecoder();

            try
            {
                Console.WriteLine(Decoder.decode(new QRCodeBitmapImage(CapImage)).ToString());
                MessageBox.Show(Decoder.decode(new QRCodeBitmapImage(CapImage)));
                SheetLineFinder QRSheet = new SheetLineFinder("1iSPzeIef7yuPilgx6HGeX_Y4RrxP2WOiztvCw8FiGP4", "A2:E", Decoder.decode(new QRCodeBitmapImage(CapImage)).ToString());
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cam.Start();
                t.Start();
                button2.Enabled = true;
                button1.Enabled = false;
            }
            catch(Exception ex)
            {
                cam.Stop();
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Stop();   // I forgot this line in the video
            cam.Stop();
            button2.Enabled = false;
            button1.Enabled = true;
        }
    }

    internal class SheetLineFinder
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "Google Sheets API .NET Quickstart";

        public SheetLineFinder(string link, string range, string item)
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define request parameters.
            String spreadsheetId = link;
            String where = range;
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, where);

            // Prints the names and majors of students in a sample spreadsheet:
            // https://docs.google.com/spreadsheets/d/1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms/edit
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            Console.WriteLine("Name, Major");
            if (values != null && values.Count > 0)
            {
                Console.WriteLine("Name, Major");
                foreach (var row in values)
                {
                    if (row != null && row.Count > 0 && row[0] != null)
                    {
                        Console.WriteLine(row[0].ToString());
                        // Print columns A and E, which correspond to indices 0 and 4.
                        if (row[0].ToString() == item && row[0] != null)
                        {
                            Console.WriteLine("{0}, {1}", row[0], row[4]);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
            Console.Read();
        }
    }
}
