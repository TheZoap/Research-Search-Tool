using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
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

            file.ShowDialog();
            string path = file.FileName.ToString();

            ExcelFileReader(path);
        }


        private void ExcelFileReader(string path)
        {

            var stream = File.Open(path, FileMode.Open, FileAccess.Read);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var result = reader.AsDataSet();
            var tables = result.Tables.Cast<System.Data.DataTable>();
            foreach (DataTable table in tables)
            {
                dataGridView1.DataSource = table;
            }

        }

        private void readExcel()
        {
            string filepath = "c:\\Users\\lucas\\Documents\\Visual Studio Code\\Python\\issue_database.xlsx";
            Application excelApp = new Application();
            Workbook excelWB;
            Worksheet excelWS;
            Range excelRange;
            excelWB = excelApp.Workbooks.Open(filepath);
            excelWS = excelWB.Worksheets[2];
            excelRange = excelWS.UsedRange;

            int rowCount = excelRange.Rows.Count;
            int columnCount = excelRange.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= columnCount; j++)
                {
                    if (excelRange.Cells[i, j] != null)
                    {

                        Console.Write(excelRange.Cells[i, j].Value2.ToString());
                    }
                }
            }

            Console.ReadKey();
            Marshal.ReleaseComObject(excelWS);
            Marshal.ReleaseComObject(excelRange);
            excelWB.Close();
            Marshal.ReleaseComObject(excelWB);
            excelApp.Quit();
            Marshal.ReleaseComObject(excelApp);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ApplyFilters()
        {
            // Get the user's input for Category, ESRS Topic, and Material.
            string categoryFilter = categoryTextBox.Text;
            string esrsTopicFilter = esrsTopicTextBox.Text;
            string materialFilter = materialTextBox.Text;

            // Build a filter string based on the user's input.
            StringBuilder filterBuilder = new StringBuilder();

            if (!string.IsNullOrEmpty(categoryFilter))
            {
                filterBuilder.Append($"[Category] LIKE '%{categoryFilter}%'");
            }

            if (!string.IsNullOrEmpty(esrsTopicFilter))
            {
                if (filterBuilder.Length > 0)
                    filterBuilder.Append(" AND ");
                filterBuilder.Append($"[ESRS Topic] LIKE '%{esrsTopicFilter}%'");
            }

            if (!string.IsNullOrEmpty(materialFilter))
            {
                if (filterBuilder.Length > 0)
                    filterBuilder.Append(" AND ");
                filterBuilder.Append($"[Material] LIKE '%{materialFilter}%'");
            }

            // Apply the filter to the BindingSource.
            bindingSource.Filter = filterBuilder.ToString();
        }

        private void categoryTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void esrsTopicTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void materialTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

    }
}