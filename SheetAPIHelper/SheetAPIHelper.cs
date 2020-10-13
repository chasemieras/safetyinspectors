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

namespace GoogleSheetHelper
{
    public class GoogleSheetHelper
    {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/sheets.googleapis.com-dotnet-quickstart.json
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "ConsoleAppWriteTo";
        static string SheetId = "1Tx1Lv46kbe4B2xNbIlKSKNVCOR00VuBoAeBfeFzy50M";

        static void Main(string[] args)
        {
            ItemFinder(SheetId, "A1:D10", "Column - 1", 4);
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
            if (getValues == null)
            {
                String emptyRange = "1:1";
                return emptyRange;
            }
            int currentCount = getValues.Count();
            String newRange = "A" + currentCount + ":A";
            return newRange;
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



        /// <summary>
        /// Authorizes our request to access Google's API
        /// </summary>
        /// <returns></returns>
        private static SheetsService AuthorizeAccess()
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
        /// Searches the google sheet between a certain range and grabs all in the range.
        /// </summary>
        /// <param name="link"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public static IList<IList<Object>> SearchSheet(string link, string range)
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
        /// Gets a row(s)
        /// </summary>
        /// <param name="link">The link to the google sheet you want to look at.</param>
        /// <param name="range">The range you want to search through.</param>
        /// <param name="item">The item you want to find.</param>
        /// <returns></returns>
        public static void ItemFinder(string link, string range, string item, int howFar)
        {
            IList<IList<Object>> values = SearchSheet(link, range);

            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    if (row != null && row.Count > 0 && row[0] != null)
                    {
                        // Print columns A and E, which correspond to indices 0 and 4.
                        if (row[0].ToString() == item && row[0] != null)
                        {
                            if(row.Count < howFar)
                            {
                                for (int i = 0; i < row.Count; i++)
                                {
                                    if (row[i] != "")
                                    {
                                        Console.Write(row[i] + ", ");
                                    }
                                }
                            }else
                            {
                                for (int i = 0; i < howFar; i++)
                                {
                                    if (row[i] != "")
                                    {
                                        Console.Write(row[i] + ", ");
                                    }
                                }
                            }
                        }
                        Console.WriteLine("Next Item");
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
