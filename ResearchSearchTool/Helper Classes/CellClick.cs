using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchSearchTool.Helper_Classes
{
    public class CellClick
    {
        public static void OnCellClick(DataGridView dataGridView, int rowIndex, int columnIndex)
        {
            DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];
            DataGridViewCell selectedCell = selectedRow.Cells[columnIndex];

            // Check if the clicked cell is already expanded
            bool isExpanded = (bool)(selectedCell.Tag ?? false);

            if (isExpanded)
            {
                // Reset the row height to the original height
                selectedRow.Height = dataGridView.RowTemplate.Height;
                selectedCell.Tag = false;
                selectedCell.Style.WrapMode = DataGridViewTriState.False; // Disable text wrapping
            }
            else
            {
                // Store the original row height
                int originalHeight = selectedRow.Height;

                // Calculate the required height to accommodate the cell's content
                int requiredHeight = CellHeight.GetRequiredHeight(selectedCell);

                // Set the row height to the required height
                selectedRow.Height = requiredHeight;

                // Update the selected cell's tag to indicate it is expanded
                selectedCell.Tag = true;
                selectedCell.Style.WrapMode = DataGridViewTriState.True; // Enable text wrapping
                selectedCell.Style.Alignment = DataGridViewContentAlignment.TopLeft; // Set vertical alignment to top
            }
        }
    }
}
