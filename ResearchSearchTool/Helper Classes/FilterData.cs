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

        public static string BuildFilterExpression(string category, string esrsTopic, string subTopic,
        string geography,string industry, string nace, string material)
        {
            var filterExpression = new StringBuilder();

            AppendFilterExpression(category, "Category", filterExpression);
            AppendFilterExpression(esrsTopic, "[ESRS Topic]", filterExpression);
            AppendFilterExpression(subTopic, "[Sub-Topic]", filterExpression);
            AppendFilterExpression(geography, "Geography", filterExpression);
            AppendFilterExpression(industry, "Industry", filterExpression);
            AppendFilterExpression(nace, "NACE", filterExpression);
            AppendFilterExpression(material, "Material", filterExpression);

            return filterExpression.ToString();
        }

        private static void AppendFilterExpression(string filterText, string columnName, StringBuilder filterExpression)
        {
            if (!string.IsNullOrWhiteSpace(filterText))
            {
                if (filterExpression.Length > 0)
                {
                    filterExpression.Append(" AND ");
                }
                filterExpression.Append(columnName);
                filterExpression.Append(" LIKE '%");
                filterExpression.Append(filterText);
                filterExpression.Append("%'");
            }
        }

    }
}