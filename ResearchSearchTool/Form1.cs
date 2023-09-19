using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ResearchSearchTool
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.TextBox[] textBoxes;
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

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterData.FilterDataByCategory(dataGridView, categoryTextBox.Text);
        }

        private void esrsTopicTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterData.FilterDataByESRSTopic(dataGridView, esrsTopicTextBox.Text);
        }

        private void subtopictextBox_TextChanged(object sender, EventArgs e)
        {
            FilterData.FilterDataBySubTopic(dataGridView, subtopictextBox.Text);
        }

        private void geographytextBox_TextChanged(object sender, EventArgs e)
        {
            FilterData.FilterDataByGeography(dataGridView, geographytextBox.Text);
        }

        private void industryTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterData.FilterDataByIndustry(dataGridView, industryTextBox.Text);
        }

        private void naceTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterData.FilterDataByNACE(dataGridView, naceTextBox.Text);
        }

        private void materialTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterData.FilterDataByMaterial(dataGridView, materialTextBox.Text);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add your custom logic here, if needed
        }

        
    }
}