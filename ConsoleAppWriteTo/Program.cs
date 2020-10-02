using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace ConsoleAppWriteTo
{
    public class Attendance
    {
        public string AttendanceId { get; set; }
    }
    class Program
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "ConsoleAppWriteTo";
        static string SheetId = "1Tx1Lv46kbe4B2xNbIlKSKNVCOR00VuBoAeBfeFzy50M";
        static void Main(string[] args)
        {
            var service = AuthorizeGoogleApp();
            string newRange = GetRange(service);
            IList<IList<Object>> objNeRecords = GenerateData();
            UpdatGoogleSheetinBatch(objNeRecords, SheetId, newRange, service);
            Console.WriteLine("Inserted");
            Console.Read();
        }


        /// <summary>
        /// Fancy stuff that authorizes our request to access Google's API
        /// </summary>
        /// <returns></returns>
        private static SheetsService AuthorizeGoogleApp()
        {
            UserCredential credential;
            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");
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
            return service;
        }

        /// <summary>
        /// Gets the range of the spreadsheet you will be working will.
        /// If the spreadsheet is empty the range will be defaulted into Range "A:A"
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        protected static string GetRange(SheetsService service)
        {
            // Define request parameters.
            String spreadsheetId = SheetId;
            String range = "A:A";
            SpreadsheetsResource.ValuesResource.GetRequest getRequest =
                       service.Spreadsheets.Values.Get(spreadsheetId, range);
            ValueRange getResponse = getRequest.Execute();
            IList<IList<Object>> getValues = getResponse.Values;
            if (getValues==null)
            {
                String emptyRange = "1:1";
                return emptyRange;
            }
            int currentCount = getValues.Count();
            String newRange = "A" + currentCount + ":A";
            return newRange;
        }


        /// <summary>
        /// Generates the data to put in the spreadsheet
        /// Currently set to 3 rows with just column in it
        /// </summary>
        /// <returns>Returns IList of IList of object</returns>
        private static IList<IList<Object>> GenerateData()
        {
            List<IList<Object>> objNewRecords = new List<IList<Object>>();
            IList<Object> obj = new List<Object>();
            obj.Add("Column - 1");
            obj.Add("Column - 2");
            obj.Add("Column - 3");
            objNewRecords.Add(obj);
            return objNewRecords;
        }


        /// <summary>
        /// Will inset all the things as strings. If you want data in proper format then change the 
        /// ValueInputOptionEnum.RAW to .USERENTERED
        /// </summary>
        private static void UpdatGoogleSheetinBatch(IList<IList<Object>> values, string spreadsheetId, string newRange, SheetsService service)
        {
            SpreadsheetsResource.ValuesResource.AppendRequest request =
               service.Spreadsheets.Values.Append(new ValueRange() { Values = values }, spreadsheetId, newRange);
            request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
            request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var response = request.Execute();
        }
    }
}