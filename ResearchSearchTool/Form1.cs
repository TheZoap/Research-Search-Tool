using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;
using Range = Microsoft.Office.Interop.Excel.Range;

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

        }

        private void readButton_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(filepathTextbox.Text, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // Specify that the first row should be treated as headers
                    var data = reader.AsDataSet(new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true,
                        }
                    });

                    // Access the "Category" column by name
                    System.Data.DataTable excelTable = data.Tables[0];
                    // Check if the "Category" column exists in the DataTable
                    if (excelTable.Columns.Contains("Category"))
                    {
                        // You can access the data in the "Category" column
                        dataGridView1.DataSource = excelTable.DefaultView;

                        // Set the column headers
                        SetColumnHeaders();
                    }
                    else
                    {
                        MessageBox.Show("The 'Category' column was not found in the Excel file.");
                    }
                }
            }

            // Apply the filter if text is entered in categoryTextBox
            if (!string.IsNullOrEmpty(categoryTextBox.Text))
            {
                FilterDataByCategory(categoryTextBox.Text);
            }
        }


        private void SetColumnHeaders()
        {
            // Set the column headers as you did before
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Client";
            dataGridView1.Columns[2].HeaderText = "Category";
            dataGridView1.Columns[3].HeaderText = "ESRS Topic";
            dataGridView1.Columns[4].HeaderText = "Sub-topic";
            dataGridView1.Columns[5].HeaderText = "Geography";
            dataGridView1.Columns[6].HeaderText = "Industry";
            dataGridView1.Columns[7].HeaderText = "NACE";
            dataGridView1.Columns[8].HeaderText = "Material";
            dataGridView1.Columns[9].HeaderText = "Description";
            dataGridView1.Columns[10].HeaderText = "Source";
            dataGridView1.Columns[11].HeaderText = "Links";
            dataGridView1.Columns[12].HeaderText = "Additional information";
            dataGridView1.Columns[13].HeaderText = "Additional sources";
        }

        private void FilterDataByCategory(string filterText)
        {
            // Get the DataView from the DataGridView's DataSource
            DataView dv = (DataView)dataGridView1.DataSource;

            // Apply the filter to the "Category" column
            dv.RowFilter = $"Category LIKE '%{filterText}%'";

            // No need to re-bind the filtered DataView to the DataGridView
            // It will automatically reflect the filtered data
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            // Filter the data based on the text in categoryTextBox
            FilterDataByCategory(categoryTextBox.Text);
        }

        private void esrsTopicTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}