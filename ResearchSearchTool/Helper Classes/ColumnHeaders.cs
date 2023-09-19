using System.Data;
using System.Windows.Forms;

namespace ResearchSearchTool
{
    public static class ColumnHeaders
    {
        public static void SetColumnHeaders(DataGridView dataGridView)
        {
            var excelTable = dataGridView.DataSource as DataTable;

            if (excelTable != null && excelTable.Rows.Count > 0)
            {
                var firstRow = excelTable.Rows[0];

                for (int i = 0; i < firstRow.ItemArray.Length; i++)
                {
                    dataGridView.Columns[i].HeaderText = firstRow[i].ToString();
                }
            }
        }
    }
}