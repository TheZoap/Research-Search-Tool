using ExcelDataReader;
using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;

namespace ResearchSearchTool
{
    public static class Export
    {
        public static void ExportDataToExcel(DataGridView dataGridView)
        {
            if (dataGridView != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ExcelPackage package = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Data");

                            // Export the column headers
                            for (int i = 0; i < dataGridView.Columns.Count; i++)
                            {
                                worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                            }

                            // Export the data rows
                            for (int i = 0; i < dataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView.Columns.Count; j++)
                                {
                                    var cellValue = dataGridView.Rows[i].Cells[j].Value;
                                    var cellStyle = worksheet.Cells[i + 2, j + 1].Style;

                                    if (cellValue != null)
                                    {
                                        worksheet.Cells[i + 2, j + 1].Value = cellValue.ToString();

                                        // Check if the cell value is a link
                                        if (dataGridView.Rows[i].Cells[j] is DataGridViewLinkCell linkCell)
                                        {
                                            worksheet.Cells[i + 2, j + 1].Hyperlink = new Uri(linkCell.Value.ToString());
                                            cellStyle.Font.UnderLine = true;
                                        }
                                    }
                                }
                            }

                            // Save the Excel package to the specified file
                            File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                        }

                        MessageBox.Show("Data exported successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting data to Excel: {ex.Message}");
                    }
                }
            }
        }
    }
}