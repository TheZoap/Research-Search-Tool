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

                        // Set the DropdownWidth for ComboBoxes to accommodate longer text
                        categoryComboBox.DropDownWidth = CalculateDropDownWidth(categoryComboBox);
                        esrsTopicComboBox.DropDownWidth = CalculateDropDownWidth(esrsTopicComboBox);
                        subTopicComboBox.DropDownWidth = CalculateDropDownWidth(subTopicComboBox);
                        geographyComboBox.DropDownWidth = CalculateDropDownWidth(geographyComboBox);
                        industryComboBox.DropDownWidth = CalculateDropDownWidth(industryComboBox);
                        naceComboBox.DropDownWidth = CalculateDropDownWidth(naceComboBox);
                        materialComboBox.DropDownWidth = CalculateDropDownWidth(materialComboBox);

                    }
                    else
                    {
                        MessageBox.Show("No data available to display.");
                    }
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
            FilterData.ApplyFilters(
                dataView, 
                categoryComboBox.Text, 
                descriptionTextBox.Text, 
                additionalTextBox.Text, 
                esrsTopicComboBox.Text, 
                subTopicComboBox.Text, 
                geographyComboBox.Text, 
                industryComboBox.Text, 
                naceComboBox.Text, 
                materialComboBox.Text);
        }



        private void PopulateComboBox(ComboBox comboBox, string columnName)
        {
            FilterData.PopulateComboBox(comboBox, dataGridView, columnName);
        }


        private int CalculateDropDownWidth(ComboBox comboBox)
        {
            int maxWidth = 0;
            foreach (object item in comboBox.Items)
            {
                int itemWidth = TextRenderer.MeasureText(item.ToString(), comboBox.Font).Width;
                maxWidth = Math.Max(maxWidth, itemWidth);
            }
            return maxWidth + SystemInformation.VerticalScrollBarWidth;
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