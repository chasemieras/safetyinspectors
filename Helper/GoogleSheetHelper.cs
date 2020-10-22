﻿using Google.Apis.Auth.OAuth2;
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
            List<IList<Object>> objNewRecords = new List<IList<Object>>(); 
            IList<Object> obj = new List<Object>(); 
            obj.Add("Column - 1"); 
            obj.Add("Column - 2");
            obj.Add("");
            obj.Add("Column - 3"); 
            objNewRecords.Add(obj);
            //NextLinePrint(objNewRecords, SheetId, "A7:D7", AuthorizeAccess());
            findThis(SheetId, "A1:D10", "Column - 2", 4);
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
        private static void NextLinePrint(IList<IList<Object>> values, string spreadsheetId, string newRange, SheetsService service)
        {
            SpreadsheetsResource.ValuesResource.AppendRequest request =
               service.Spreadsheets.Values.Append(new ValueRange() { Values = values }, spreadsheetId, newRange);
            request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
            request.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var response = request.Execute();
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
        /// 
        /// </summary>
        /// <param name="SheetLink"></param>
        /// <param name="RangeOnSheet"></param>
        /// <param name="DataWanted"></param>
        /// <param name="HowFarToGo"></param>
        public static void DataFinder(string SheetLink, string RangeOnSheet, string DataWanted, int HowFarToGo)
        {
            IList<IList<Object>> values = SearchSheet(SheetLink, RangeOnSheet);
            int valuesCount = 0;

            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    //valuesCount++;
                    if (row != null && row.Count > 0 && row[0] != null)
                    {

                        // Print columns A and E, which correspond to indices 0 and 4.
                        if (row[0].ToString() == DataWanted && row[0] != null)
                        {
                            if (row.Count < HowFarToGo)
                            {
                                for (int i = 0; i < row.Count; i++)
                                {
                                    if (row[i] != "")
                                    {
                                        valuesCount++;
                                        //Console.Write(row[i] + ", ");
                                        Console.WriteLine(i + " " + valuesCount);
                                    }
                                }
                            }else
                            {
                                for (int i = 0; i < HowFarToGo; i++)
                                {
                                    if (row[i] != "")
                                    {
                                        valuesCount++;
                                        //Console.Write(row[i] + ", ");
                                        Console.WriteLine(i + " " + valuesCount);
                                    }
                                }
                            }
                        }
                        //Console.WriteLine("Next Item");
                    }
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
            Console.Read();
        }

        public static void findThis(string SheetLink, string RangeOnSheet, string DataWanted, int HowFarToGo)
        {
            IList<IList<Object>> values = SearchSheet(SheetLink, RangeOnSheet);
            int rowCounter = 0;
            int columnCounter = 0;

            if (values != null && values.Count > 0)
            {
                foreach (var row in values) //for each row in the sheet
                {
                    columnCounter = 0;
                    rowCounter++;
                    if (row != null && row.Count > 0 && row[0] != null) //if the row is not null or empty.
                    {
                        // Print columns A and E, which correspond to indices 0 and 4.
                        if (row[1].ToString() == DataWanted && row[1] != null)
                        {
                            if (row.Count < HowFarToGo)
                            {
                                for (int i = 0; i < row.Count; i++)// prints contents of row
                                {
                                    if (row[i] != "")
                                    {
                                        Console.Write(row[i] + ", ");
                                        //Console.WriteLine("Row " + rowCounter+": Column " + GetColumnName(i));
                                        Console.WriteLine(GetColumnName(columnCounter) + ":" + rowCounter);
                                    }
                                    columnCounter++;
                                }
                            }
                            else
                            {
                                for (int i = 0; i < HowFarToGo; i++)
                                {
                                    if (row[i] != "")
                                    {
                                        Console.Write(row[i] + ", ");
                                        Console.WriteLine(values[i]);
                                    }
                                }
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



        /// <summary>
        /// Gets Column's letters, starts at A no matter where the item actually is.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        static string GetColumnName(int index)
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var value = "";

            if (index >= letters.Length)
            {
                value += letters[index / letters.Length - 1];
            }

            value += letters[index % letters.Length];

            return value;
        }

    }
}