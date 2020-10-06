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

namespace Helper
{
    public class Helper
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "ConsoleAppWriteTo";
        static string SheetId = "1Tx1Lv46kbe4B2xNbIlKSKNVCOR00VuBoAeBfeFzy50M";

        static void Main(string[] args)
        {
            UserCredential credential;

            SheetLineFinder(SheetId, "A1:D10", "Column - 1", 2);
        }

        /// <summary>
        /// Gets a row(s)
        /// </summary>
        /// <param name="link">The link to the google sheet you want to look at.</param>
        /// <param name="range">The range you want to search through.</param>
        /// <param name="item">The item you want to find.</param>
        /// <returns></returns>
        public static void SheetLineFinder(string link, string range, string item, int howFar)
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
            string columns = "";
            string rows = "";
            if (values != null && values.Count > 0)
            {
                //onsole.WriteLine("Name, Major");
                foreach (var row in values)
                {
                    if (row != null && row.Count > 0 && row[0] != null)
                    {
                        //Console.WriteLine(row[0].ToString());
                        // Print columns A and E, which correspond to indices 0 and 4.
                        if (row[0].ToString() == item && row[0] != null)
                        {
                            //Console.WriteLine("{0}, {1}, {2}", row[0], row[1], row[2]);
                            for(int i = 0; i < howFar; i++)
                            {
                                columns = columns + ("{" + i + "},");
                                rows = rows + row[i] + " ";
                            }
                            for (int i = 0; i < howFar; i++)
                            {
                                Console.WriteLine(rows);
                            }
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
