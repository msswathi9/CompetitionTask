using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office.Excel;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using DocumentFormat.OpenXml.Spreadsheet;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTable = System.Data.DataTable;

namespace ShareSkill.Utilities
{
    public static class ExcelLib
    {

        private static DataTable ExcelToDataTable(string filename, string sheetName)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            FileStream stream = File.Open(filename, FileMode.Open, FileAccess.Read);
            // FileStream stream1 = File.Open(filename, FileMode.Open, FileAccess.ReadWrite);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);


            DataSet resultSet = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = false
                }

            });
            DataTableCollection table = resultSet.Tables;
            DataTable resultTable = table[sheetName];
            return resultTable;
        }

        public class DataCollection
        {
            public int rowNumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }
        }
        public static void ClearData()
        {
            dataCol.Clear();
        }
        public static void fileClose(string fileName,string sheetName)
        {
            fileClose(fileName, sheetName);
        }
        static List<DataCollection> dataCol = new List<DataCollection>();
        public static void PopulateInCollection(string filename, string sheetName)
        {
            // ExcelLib.ClearData();
            DataTable table = ExcelToDataTable(filename, sheetName);

            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {


                    DataCollection dtTable = new DataCollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    dataCol.Add(dtTable);
                }
            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                IEnumerable<string> enumerable()
                {
                    foreach (var colData in dataCol)
                    {
                        if (colData.colName == columnName && colData.rowNumber == rowNumber)
                        {
                            yield return colData.colValue;
                        }
                    }
                }
                //string data = (from colData in dataCol where colData.colName == columnName && colData.rowNumber == rowNumber select colData.colValue).SingleOrDefault();
                //return data.ToString();
                string data = enumerable().SingleOrDefault();
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }


}

