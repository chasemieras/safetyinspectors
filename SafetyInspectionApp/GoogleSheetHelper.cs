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

namespace SafetyInspectionApp
{
    public class GoogleSheetHelper
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        string[] Scopes = { SheetsService.Scope.Spreadsheets };
        public string sheetID;

        public void GetSheetID()
        {
            foreach (string line in File.ReadLines(@"SheetID.txt"))
            {
                sheetID = line;
            }
        }

        /// <summary>
        /// Authorizes our request to access Google's API
        /// </summary>
        /// <returns></returns>
        private SheetsService AuthorizeAccess()
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
            });
            return service;
        }

        /// <summary>
        /// Searches the google sheet between a certain range and grabs all in the range.
        /// </summary>
        /// <param name="link"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public IList<IList<Object>> SearchSheet(string link, string range)
        {
            // Define request parameters.
            String spreadsheetId = link;
            String where = range;
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    AuthorizeAccess().Spreadsheets.Values.Get(spreadsheetId, where);

            // Prints the names and majors of students in a sample spreadsheet:
            // https://docs.google.com/spreadsheets/d/1BxiMVs0XRA5nFMdKvBdBZjgmUUqptlbs74OgvE2upms/edit
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            return values;
        }

        /// <summary>
        /// Get's all of the names in the "Form List", this is column B
        /// </summary>
        /// <returns>The String Array of all names</returns>
        public string[] getFormName()
        {

            int ColumnLength = getNumberCurrentForms();

            string[] cells = new string[(ColumnLength + 1)];

            SpreadsheetsResource.ValuesResource.GetRequest request =
                    AuthorizeAccess().Spreadsheets.Values.Get(sheetID, "B2:B" + (ColumnLength + 1));

            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            int i = 0;
            foreach (var row in values)
            {
                cells[i] = (string)row[0];
                i++;
            }
            return cells;
        }

        /// <summary>
        /// Get's all of the names in the "Form List", this is column D
        /// </summary>
        /// <returns>The String Array of all links</returns>
        public string[] getFormLink()
        {
            int ColumnLength = getNumberCurrentForms();

            string[] cells = new string[(ColumnLength + 1)];

            SpreadsheetsResource.ValuesResource.GetRequest request =
                    AuthorizeAccess().Spreadsheets.Values.Get(sheetID, "D2:D" + (ColumnLength + 1));

            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            int i = 0;
            foreach (var row in values)
            {
                cells[i] = (string)row[0];
                i++;
            }
            return cells;
        }

        /// <summary>
        /// Get's all of the names in the "Form List", this is cell A2
        /// </summary>
        /// <returns>The number of google forms</returns>
        public int getNumberCurrentForms()
        {
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    AuthorizeAccess().Spreadsheets.Values.Get(sheetID, "A2:A2");
            ValueRange response = request.Execute();
            IList<IList<Object>> values = response.Values;
            foreach (var row in values)
            {
                return Int32.Parse((string)row[0]);
            }
            return 100;
        }

    }
}
