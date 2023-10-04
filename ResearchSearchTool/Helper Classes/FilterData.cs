using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ResearchSearchTool
{
    public static class FilterData
    {
        public static string BuildFilterExpression(string categoryComboBox,string description,
        string additional, string esrsTopicComboBox, string subTopicComboBox,
        string geographyComboBox, string industryComboBox, string naceComboBox, string materialComboBox)
        {
            var filterExpression = new StringBuilder();

            AppendFilterExpression(categoryComboBox, "Category", filterExpression);
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

        public static void ApplyFilters(DataView dataView, string categoryComboBox, string description, string additional, string esrsTopicComboBox, string subTopicComboBox, string geographyComboBox, string industryComboBox, string naceComboBox, string materialComboBox)
        {
            if (dataView != null)
            {
                var filterExpression = BuildFilterExpression(categoryComboBox, description, additional, esrsTopicComboBox, subTopicComboBox, geographyComboBox, industryComboBox, naceComboBox, materialComboBox);

                dataView.RowFilter = filterExpression;
            }
        }


        public static void PopulateComboBox(ComboBox comboBox, DataGridView dataGridView, string columnName)
        {
            DataGridViewColumn column = dataGridView.Columns[columnName];
            if (column != null)
            {
                // Create a HashSet to store unique values
                HashSet<string> uniqueValues = new HashSet<string>();

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    object cellValue = row.Cells[column.Index].Value;
                    if (cellValue != null)
                    {
                        string value = cellValue.ToString().Trim(); // Trim the value to remove leading and trailing spaces
                        if (!string.IsNullOrWhiteSpace(value))
                        {
                            // Capitalize the first letter and convert the rest to lowercase
                            value = char.ToUpper(value[0]) + value.Substring(1).ToLower();

                            if (!uniqueValues.Contains(value))
                            {
                                uniqueValues.Add(value);
                            }
                        }
                    }
                }

                // Sort the unique values alphabetically
                List<string> sortedValues = new List<string>(uniqueValues);
                sortedValues.Sort();

                // Clear existing items in the ComboBox and populate with sorted unique values
                comboBox.Items.Clear();
                comboBox.Items.AddRange(sortedValues.ToArray());

                // Enable AutoComplete for ComboBox
                comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }
    }
}