using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResearchSearchTool.Helper_Classes
{
    public class CellHeight
    {
        public static int GetRequiredHeight(DataGridViewCell cell)
        {
            using (Graphics graphics = cell.DataGridView.CreateGraphics())
            {
                string cellText = cell.Value?.ToString() ?? string.Empty;
                SizeF textSize = graphics.MeasureString(cellText, cell.DataGridView.Font, cell.Size.Width - 2);

                // Calculate the required height with the desired factor
                int requiredHeight = (int)(textSize.Height * 1.05f);

                return requiredHeight;
            }
        }
    }
}
