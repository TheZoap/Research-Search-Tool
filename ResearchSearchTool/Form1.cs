using ExcelDataReader;
using OfficeOpenXml;
using ResearchSearchTool.Helper_Classes;
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
                        // Find the column by its header text and rename it
                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            if (column.HeaderText == "Links plaintext")
                            {
                                column.HeaderText = "Links click here";
                                break; // Once you've found and renamed the column, exit the loop
                            }
                        }
                        PopulateComboBox(categoryComboBox, "Category");
                        PopulateComboBox(esrsTopicComboBox, "ESRS Topic");
                        PopulateComboBox(subTopicComboBox, "Sub-Topic");
                        PopulateComboBox(geographyComboBox, "Geography");
                        PopulateComboBox(industryComboBox, "Industry");
                        PopulateComboBox(naceComboBox, "NACE");
                        PopulateComboBox(materialComboBox, "Material");
                        
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
            int columnIndex = e.ColumnIndex;

            if (columnIndex >= 0 && rowIndex >= 0)
            {
                DataGridViewCell cell = dataGridView.Rows[rowIndex].Cells[columnIndex];

                // Check if the clicked cell is a link
                if (dataGridView.Columns[columnIndex].HeaderText == "Links"
                    || dataGridView.Columns[columnIndex].HeaderText == "Links click here"
                    || dataGridView.Columns[columnIndex].HeaderText == "Sources plaintext")
                {
                    // Open the link using CheckLinks.ClickCheckLink()
                    CheckLinks.ClickCheckLink(dataGridView, rowIndex, columnIndex);
                    return; // Exit the method to prevent CellClick.OnClick() from being called
                }

                // If it's not a link, call CellClick.OnClick()
                CellClick.OnCellClick(dataGridView, rowIndex, columnIndex);
            }
        }


        private void ApplyFilters()
        {
            if (dataView != null)
            {
                var filterExpression = FilterData.BuildFilterExpression(
                    categoryComboBox.Text,
                    esrsTopicTextBox.Text,
                    subtopictextBox.Text,
                    geographytextBox.Text,
                    industryTextBox.Text,
                    naceTextBox.Text,
                    materialTextBox.Text,
                    descriptionTextBox.Text,
                    additionalTextBox.Text,
                    esrsTopicComboBox.Text,
                    subTopicComboBox.Text,
                    geographyComboBox.Text,
                    industryComboBox.Text,
                    naceComboBox.Text,
                    materialComboBox.Text);

                dataView.RowFilter = filterExpression;
            }
        }

        private void PopulateComboBox(ComboBox comboBox, string columnName)
        {
            DataGridViewColumn column = dataGridView.Columns[columnName];
            if (column != null)
            {
                // Create a HashSet to store unique values
                HashSet<string> uniqueValues = new HashSet<string>();

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    object cellValue = row.Cells[column.Index].Value;
                    if (cellValue != null)
                    {
                        string value = cellValue.ToString().Trim(); // Trim the value to remove leading and trailing spaces
                        if (!string.IsNullOrWhiteSpace(value) && !uniqueValues.Contains(value))
                        {
                            uniqueValues.Add(value);
                        }
                    }
                }

                // Clear existing items in the ComboBox and populate with unique values
                comboBox.Items.Clear();
                comboBox.Items.AddRange(uniqueValues.ToArray());

                // Enable AutoComplete for ComboBox
                comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void categoryComboBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void EsrsTopicComboBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void SubTopicComboBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void GeographyComboBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void IndustryComboBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void NaceComboBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void MaterialComboBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
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