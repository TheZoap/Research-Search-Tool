using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ResearchSearchTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                filepathTextbox.Text = file.FileName;
            }
            file.Dispose(); // Dispose the OpenFileDialog object
        }

        private async void readButton_Click(object sender, EventArgs e)
        {
            try
            {
                var excelFilePath = filepathTextbox.Text;

                if (excelFilePath != null && File.Exists(excelFilePath))
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                    var data = await Task.Run(() => ReadExcel.ReadExcelFile(excelFilePath));

                    if (data != null)
                    {
                        dataGridView1.DataSource = data.DefaultView;
                        ColumnHeaders.SetColumnHeaders(dataGridView1);
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

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterData.FilterDataByCategory(dataGridView1,categoryTextBox.Text);
        }

        private void esrsTopicTextBox_TextChanged(object sender, EventArgs e)
        {
            // Add any necessary logic for handling esrsTopicTextBox text change event
        }

        private void materialTextBox_TextChanged(object sender, EventArgs e)
        {
            // Add any necessary logic for handling materialTextBox text change event
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
            // Add your custom logic here, if needed
}
    }
}