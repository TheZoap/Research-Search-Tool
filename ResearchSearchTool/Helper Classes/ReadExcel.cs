using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResearchSearchTool
{
    public static class ReadExcel
    {
        public static async Task<DataTable> ReadExcelFile(string filePath, int sheetIndex = 1)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Invalid file path.");
                    return null;
                }

                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                return await Task.Run(() => ReadDataFromExcel(filePath, sheetIndex));
            }
            catch (Exception ex)
            {
                LogError(ex); // Log the exception for debugging and error tracking
                MessageBox.Show($"Error reading Excel file: {ex.Message}");
                return null;
            }
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

                if (sheetIndex >= 0 && sheetIndex < dataSet.Tables.Count)
                {
                    return dataSet.Tables[sheetIndex];
                }

                throw new IndexOutOfRangeException("Sheet index is out of range.");
            }
        }

        private static void LogError(Exception ex)
        {
            // Implement a logging mechanism (e.g., Serilog, NLog) to log the exception details.
            // You can log to a file, console, or a central logging service.
            // Example: logger.Error(ex, "An error occurred while reading an Excel file.");
        }
    }
}
