using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResearchSearchTool.Helper_Classes
{
    public class CellClick
    {
        public static void OnCellClick(DataGridView dataGridView, int rowIndex, int columnIndex)
        {
            DataGridViewRow selectedRow = dataGridView.Rows[rowIndex];
            DataGridViewCell selectedCell = selectedRow.Cells[columnIndex];

            // Check if the cell's value is not empty or null
            if (selectedCell.Value != null && !string.IsNullOrEmpty(selectedCell.Value.ToString()))
            {
                bool isExpanded = (bool)(selectedCell.Tag ?? false);

                if (isExpanded)
                {
                    CellStyler.ResetRowStyles(selectedRow);
                    selectedCell.Tag = false;
                }
                else
                {
                    CellStyler.ExpandRowStyles(selectedRow, selectedCell);
                    selectedCell.Tag = true;
                }
            }
        }
    }
}
