using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ResearchSearchTool.Helper_Classes
{
    public class CheckLinks
    {
        public static void ClickCheckLink(DataGridView dataGridView, int rowIndex, int columnIndex)
        {
            DataGridViewCell cell = dataGridView.Rows[rowIndex].Cells[columnIndex];

                string linkText = cell.Value as string;

                if (Uri.IsWellFormedUriString(linkText, UriKind.Absolute))
                {
                    string browserPath = GetPreferredBrowserPath(); // Get the preferred browser path

                    try
                    {
                        Process.Start(browserPath, linkText);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening URL with the selected browser: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid URL");
                }
        }

        private static string GetPreferredBrowserPath()
        {
            // Add your logic here to determine the preferred browser
            string preferredBrowser = "Chrome"; // Replace with your actual logic
            string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
            string firefoxPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            string edgePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";

            switch (preferredBrowser)
            {
                case "Chrome":
                    return chromePath;
                case "Edge":
                    return edgePath;
                case "Firefox":
                    return firefoxPath;
                default:
                    return chromePath; // Default to Chrome if the preference is not recognized
            }
        }
    }
}
