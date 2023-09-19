using ExcelDataReader;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ResearchSearchTool
{
    public partial class Form1 : Form
    {
        private DataView dataView;
        public Form1()
        {
            InitializeComponent();

        }

        private async void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                filepathTextbox.Text = file.FileName;

                try
                {
                    var excelFilePath = filepathTextbox.Text;

                    if (excelFilePath != null && File.Exists(excelFilePath))
                    {
                        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                        var data = await Task.Run(() => ReadExcel.ReadExcelFile(excelFilePath));

                        if (data != null)
                        {
                            dataView = data.DefaultView;
                            dataGridView.DataSource = data.DefaultView;
                            ColumnHeaders.SetColumnHeaders(dataGridView);
                        }
                        else
                        {
                            MessageBox.Show("No data available to display.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid file path.");
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"An I/O error occurred while reading the file: {ex.Message}");
                }
                catch (InvalidDataException ex)
                {
                    MessageBox.Show($"The file is not in a valid format: {ex.Message}");
                }
                catch (NotSupportedException ex)
                {
                    MessageBox.Show($"The file format is not supported: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading Excel file: {ex.Message}");
                }
            }
            file.Dispose(); // Dispose the OpenFileDialog object
        }
        private void ApplyFilters()
        {
            if (dataView != null)
            {
                var filterExpression = FilterData.BuildFilterExpression(
                    categoryTextBox.Text,
                    esrsTopicTextBox.Text,
                    subtopictextBox.Text,
                    geographytextBox.Text,
                    industryTextBox.Text,
                    naceTextBox.Text,
                    materialTextBox.Text);

                dataView.RowFilter = filterExpression;
            }
        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void esrsTopicTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void subtopictextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void geographytextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void industryTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void naceTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void materialTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add your custom logic here, if needed
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (dataView != null)
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