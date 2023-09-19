using ExcelDataReader;
using System;
using System.Data;
using System.IO;

namespace ResearchSearchTool
{
    public static class ReadExcel
    {
        public static DataTable ReadExcelFile(string filePath)
        {
            try
            {
                using (var stream = File.OpenRead(filePath))
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var data = reader.AsDataSet(new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true,
                        }
                    });

                    return data.Tables[0];
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
    }
}