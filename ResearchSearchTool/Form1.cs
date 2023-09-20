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

                    var data = await ReadExcel.ReadExcelFile(excelFilePath);

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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];
            DataGridViewCell selectedCell = selectedRow.Cells[e.ColumnIndex];

            // Check if the clicked cell is already expanded
            bool isExpanded = (bool)(selectedCell.Tag ?? false);

            if (isExpanded)
            {
                // Reset the row height to the original height
                selectedRow.Height = dataGridView.RowTemplate.Height;
                selectedCell.Tag = false;
                selectedCell.Style.WrapMode = DataGridViewTriState.False; // Disable text wrapping
            }
            else
            {
                // Store the original row height
                int originalHeight = selectedRow.Height;

                // Calculate the required height to accommodate the cell's content
                int requiredHeight = GetRequiredHeight(selectedCell);

                // Set the row height to the required height
                selectedRow.Height = requiredHeight;

                // Update the selected cell's tag to indicate it is expanded
                selectedCell.Tag = true;
                selectedCell.Style.WrapMode = DataGridViewTriState.True; // Enable text wrapping
                selectedCell.Style.Alignment = DataGridViewContentAlignment.TopLeft; // Set vertical alignment to top

            }
        }

        private int GetRequiredHeight(DataGridViewCell cell)
        {
            using (Graphics graphics = cell.DataGridView.CreateGraphics())
            {
                string cellText = cell.Value?.ToString() ?? string.Empty;
                SizeF textSize = graphics.MeasureString(cellText, cell.DataGridView.Font, cell.Size.Width - 2);

                // Calculate the required height with the desired factor
                int requiredHeight = (int)(textSize.Height * 1.05f);

                return requiredHeight;
            }
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
                    materialTextBox.Text,
                    descriptionTextBox.Text,
                    additionalTextBox.Text);

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

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void additionalTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Export.ExportDataToExcel(dataGridView);
        }
    }
}