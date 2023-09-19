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

        public static void FilterDataByESRSTopic(DataGridView dataGridView, string filterText)
        {
            var dv = dataGridView.DataSource as DataView;

            var filterExpression = new StringBuilder();
            filterExpression.Append("[ESRS Topic]  LIKE '%");
            filterExpression.Append(filterText);
            filterExpression.Append("%'");

            dv.RowFilter = filterExpression.ToString();
        }

        public static void FilterDataBySubTopic(DataGridView dataGridView, string filterText)
        {
            var dv = dataGridView.DataSource as DataView;

            var filterExpression = new StringBuilder();
            filterExpression.Append("[Sub-Topic]  LIKE '%");
            filterExpression.Append(filterText);
            filterExpression.Append("%'");

            dv.RowFilter = filterExpression.ToString();
        }

        public static void FilterDataByGeography(DataGridView dataGridView, string filterText)
        {
            var dv = dataGridView.DataSource as DataView;

            var filterExpression = new StringBuilder();
            filterExpression.Append("Geography  LIKE '%");
            filterExpression.Append(filterText);
            filterExpression.Append("%'");

            dv.RowFilter = filterExpression.ToString();
        }

        public static void FilterDataByIndustry(DataGridView dataGridView, string filterText)
        {
            var dv = dataGridView.DataSource as DataView;

            var filterExpression = new StringBuilder();
            filterExpression.Append("Industry  LIKE '%");
            filterExpression.Append(filterText);
            filterExpression.Append("%'");

            dv.RowFilter = filterExpression.ToString();
        }

        public static void FilterDataByNACE(DataGridView dataGridView, string filterText)
        {
            var dv = dataGridView.DataSource as DataView;

            var filterExpression = new StringBuilder();
            filterExpression.Append("NACE  LIKE '%");
            filterExpression.Append(filterText);
            filterExpression.Append("%'");

            dv.RowFilter = filterExpression.ToString();
        }

        public static void FilterDataByMaterial(DataGridView dataGridView, string filterText)
        {
            var dv = dataGridView.DataSource as DataView;

            var filterExpression = new StringBuilder();
            filterExpression.Append("Material  LIKE '%");
            filterExpression.Append(filterText);
            filterExpression.Append("%'");

            dv.RowFilter = filterExpression.ToString();
        }
        
    }
}