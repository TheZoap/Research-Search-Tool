using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ResearchSearchTool
{
    public static class ReadExcel
    {
        public static async Task<DataTable> ReadExcelFile(string filePath, int sheetIndex = 1)
        {
            try
            {
                var excelFilePath = filePath;

                if (excelFilePath != null && File.Exists(excelFilePath))
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                    var data = await Task.Run(() => ReadDataFromExcel(excelFilePath, sheetIndex));

                    return data;
                }
                else
                {
                    MessageBox.Show("Invalid file path.");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"An I/O error occurred while reading the Excel file: {ex.Message}");
            }
            catch (InvalidDataException ex)
            {
                MessageBox.Show($"The Excel file is not in a valid format: {ex.Message}");
            }
            catch (NotSupportedException ex)
            {
                MessageBox.Show($"The Excel file format is not supported: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading Excel file: {ex.Message}");
            }

            return null;
        }

        private static DataTable ReadDataFromExcel(string filePath, int sheetIndex)
        {
            using (var stream = File.OpenRead(filePath))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true
                    }
                });

                if (dataSet.Tables.Count > sheetIndex)
                {
                    return dataSet.Tables[sheetIndex];
                }

                throw new IndexOutOfRangeException("Sheet index is out of range.");
            }
        }
    }
}