using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ResearchSearchTool
{
    public static class FilterData
    {
        public static string BuildFilterExpression(string categoryComboBox, string esrsTopic, string subTopic,
        string geography,string industry, string nace, string material, string description,
        string additional, string esrsTopicComboBox, string subTopicComboBox,
        string geographyComboBox, string industryComboBox, string naceComboBox, string materialComboBox)
        {
            var filterExpression = new StringBuilder();

            AppendFilterExpression(categoryComboBox, "Category", filterExpression);
            AppendFilterExpression(esrsTopic, "[ESRS Topic]", filterExpression);
            AppendFilterExpression(subTopic, "[Sub-Topic]", filterExpression);
            AppendFilterExpression(geography, "Geography", filterExpression);
            AppendFilterExpression(industry, "Industry", filterExpression);
            AppendFilterExpression(nace, "NACE", filterExpression);
            AppendFilterExpression(material, "Material", filterExpression);
            AppendFilterExpression(description, "Description", filterExpression);
            AppendFilterExpression(additional, "[Additional information]", filterExpression);
            AppendFilterExpression(esrsTopicComboBox, "[ESRS Topic]", filterExpression);
            AppendFilterExpression(subTopicComboBox, "[Sub-Topic]", filterExpression);
            AppendFilterExpression(geographyComboBox, "Geography", filterExpression);
            AppendFilterExpression(industryComboBox, "Industry", filterExpression);
            AppendFilterExpression(naceComboBox, "NACE", filterExpression);
            AppendFilterExpression(materialComboBox, "Material", filterExpression);

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