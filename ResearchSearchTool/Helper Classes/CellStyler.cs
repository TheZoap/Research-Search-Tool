using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchSearchTool.Helper_Classes
{
    public static class CellStyler
    {
        public static void ResetRowStyles(DataGridViewRow row)
        {
            row.Height = row.DataGridView.RowTemplate.Height;
            row.Cells.Cast<DataGridViewCell>()
                .ToList()
                .ForEach(cell => ResetCellStyle(cell));
        }

        public static void ExpandRowStyles(DataGridViewRow row, DataGridViewCell cell)
        {
            int originalHeight = row.Height;
            int requiredHeight = CellHeight.GetRequiredHeight(cell);

            row.Height = requiredHeight;
            row.Cells.Cast<DataGridViewCell>()
                .ToList()
                .ForEach(expandedCell => ExpandCellStyle(expandedCell));

            cell.Style.Alignment = DataGridViewContentAlignment.TopLeft;
        }

        public static void ResetCellStyle(DataGridViewCell cell)
        {
            cell.Style.WrapMode = DataGridViewTriState.False;
            // Reset other cell styles if needed
        }

        public static void ExpandCellStyle(DataGridViewCell cell)
        {
            cell.Style.WrapMode = DataGridViewTriState.True;
            // Apply other cell styles if needed
        }
    }
}
