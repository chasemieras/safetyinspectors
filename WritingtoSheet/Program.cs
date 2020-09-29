using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingtoSheet
{
    static class Program
    {

        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "Google Sheets API .NET Quickstart";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void CreateSpreadsheet()
        {
            Spreadsheet spreadsheet = new Spreadsheet();

            spreadsheet.Properties = new SpreadsheetProperties();
            spreadsheet = 








            //UserCredential credential;

            //using (var stream =
            //    new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            //{
            //    // The file token.json stores the user's access and refresh tokens, and is created
            //    // automatically when the authorization flow completes for the first time.
            //    string credPath = "token.json";
            //    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
            //        GoogleClientSecrets.Load(stream).Secrets,
            //        Scopes,
            //        "user",
            //        CancellationToken.None,
            //        new FileDataStore(credPath, true)).Result;
            //    Console.WriteLine("Credential file saved to: " + credPath);
            //}

            //// Create Google Sheets API service.
            //var service = new SheetsService(new BaseClientService.Initializer()
            //{
            //    HttpClientInitializer = credential,
            //    ApplicationName = ApplicationName,
            //});

            //// Define request parameters.
            //String spreadsheetId = "1Tx1Lv46kbe4B2xNbIlKSKNVCOR00VuBoAeBfeFzy50M";
            //String range = "Class Data!A2:E";
            //string valueInputOption = "USER_ENTERED";
            //SpreadsheetsResource.ValuesResource.GetRequest request =
            //        service.Spreadsheets.Values.Get(spreadsheetId, range);

            //// Prints the names and majors of students in a sample spreadsheet:
            //// https://docs.google.com/spreadsheets/d/1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms/edit
            //ValueRange response = request.Execute();
            //IList<IList<Object>> values = response.Values;
            //if (values != null && values.Count > 0)
            //{
            //    Console.WriteLine("Name, Major");
            //    foreach (var row in values)
            //    {
            //        // Print columns A and E, which correspond to indices 0 and 4.
            //        Console.WriteLine("{0}, {1}", row[0], row[4]);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No data found.");
            //}
            //Console.Read();
        }
    }

}
