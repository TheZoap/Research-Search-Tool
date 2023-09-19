using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ResearchSearchTool
{
    public static class FilterData
    {
        public static void FilterDataByCategory(DataGridView dataGridView, string filterText)
        {
            var dv = dataGridView.DataSource as DataView;

            var filterExpression = new StringBuilder();
            filterExpression.Append("Category LIKE '%");
            filterExpression.Append(filterText);
            filterExpression.Append("%'");

            dv.RowFilter = filterExpression.ToString();
        }
    }
}