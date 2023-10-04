namespace ResearchSearchTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 


        private BindingSource bindingSource = new BindingSource();

        private void InitializeComponent()
        {
            BrowseButton = new Button();
            dataGridView = new DoubleBufferedDataGridView();
            categoryLabel = new Label();
            esrsTopicLabel = new Label();
            materialLabel = new Label();
            filepathTextbox = new TextBox();
            subtopicLabel = new Label();
            geographyLabel = new Label();
            label1 = new Label();
            industryLabel = new Label();
            naceLabel = new Label();
            exportButton = new Button();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            additionalTextBox = new TextBox();
            additionalLabel = new Label();
            categoryComboBox = new ComboBox();
            esrsTopicComboBox = new ComboBox();
            subTopicComboBox = new ComboBox();
            geographyComboBox = new ComboBox();
            industryComboBox = new ComboBox();
            naceComboBox = new ComboBox();
            materialComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // BrowseButton
            // 
            BrowseButton.Location = new Point(14, 32);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(112, 32);
            BrowseButton.TabIndex = 1;
            BrowseButton.Text = "Browse file";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(168, 98);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.ShowCellToolTips = false;
            dataGridView.Size = new Size(1100, 610);
            dataGridView.TabIndex = 20;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(12, 98);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(84, 25);
            categoryLabel.TabIndex = 3;
            categoryLabel.Text = "Category";
            // 
            // esrsTopicLabel
            // 
            esrsTopicLabel.AutoSize = true;
            esrsTopicLabel.Location = new Point(14, 160);
            esrsTopicLabel.Name = "esrsTopicLabel";
            esrsTopicLabel.Size = new Size(98, 25);
            esrsTopicLabel.TabIndex = 4;
            esrsTopicLabel.Text = "ESRS Topic";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new Point(10, 470);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(75, 25);
            materialLabel.TabIndex = 6;
            materialLabel.Text = "Material";
            // 
            // filepathTextbox
            // 
            filepathTextbox.Location = new Point(147, 32);
            filepathTextbox.Name = "filepathTextbox";
            filepathTextbox.Size = new Size(871, 31);
            filepathTextbox.TabIndex = 0;
            // 
            // subtopicLabel
            // 
            subtopicLabel.AutoSize = true;
            subtopicLabel.Location = new Point(12, 222);
            subtopicLabel.Name = "subtopicLabel";
            subtopicLabel.Size = new Size(91, 25);
            subtopicLabel.TabIndex = 10;
            subtopicLabel.Text = "Sub-Topic";
            // 
            // geographyLabel
            // 
            geographyLabel.AutoSize = true;
            geographyLabel.Location = new Point(12, 284);
            geographyLabel.Name = "geographyLabel";
            geographyLabel.Size = new Size(100, 25);
            geographyLabel.TabIndex = 12;
            geographyLabel.Text = "Geography";
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // industryLabel
            // 
            industryLabel.AutoSize = true;
            industryLabel.Location = new Point(12, 346);
            industryLabel.Name = "industryLabel";
            industryLabel.Size = new Size(77, 25);
            industryLabel.TabIndex = 17;
            industryLabel.Text = "Industry";
            // 
            // naceLabel
            // 
            naceLabel.AutoSize = true;
            naceLabel.Location = new Point(12, 408);
            naceLabel.Name = "naceLabel";
            naceLabel.Size = new Size(57, 25);
            naceLabel.TabIndex = 19;
            naceLabel.Text = "NACE";
            // 
            // exportButton
            // 
            exportButton.Location = new Point(1041, 32);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(112, 32);
            exportButton.TabIndex = 21;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 560);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(150, 31);
            descriptionTextBox.TabIndex = 23;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(8, 532);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(102, 25);
            descriptionLabel.TabIndex = 22;
            descriptionLabel.Text = "Description";
            // 
            // additionalTextBox
            // 
            additionalTextBox.Location = new Point(12, 622);
            additionalTextBox.Name = "additionalTextBox";
            additionalTextBox.Size = new Size(150, 31);
            additionalTextBox.TabIndex = 25;
            additionalTextBox.TextChanged += additionalTextBox_TextChanged;
            // 
            // additionalLabel
            // 
            additionalLabel.AutoSize = true;
            additionalLabel.Location = new Point(8, 594);
            additionalLabel.Name = "additionalLabel";
            additionalLabel.Size = new Size(130, 25);
            additionalLabel.TabIndex = 24;
            additionalLabel.Text = "Additional info";
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(12, 126);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(150, 33);
            categoryComboBox.TabIndex = 3;
            categoryComboBox.TextChanged += categoryComboBox_TextChanged;
            // 
            // esrsTopicComboBox
            // 
            esrsTopicComboBox.FormattingEnabled = true;
            esrsTopicComboBox.Location = new Point(12, 188);
            esrsTopicComboBox.Name = "esrsTopicComboBox";
            esrsTopicComboBox.Size = new Size(150, 33);
            esrsTopicComboBox.TabIndex = 5;
            esrsTopicComboBox.TextChanged += EsrsTopicComboBox_TextChanged;
            // 
            // subTopicComboBox
            // 
            subTopicComboBox.FormattingEnabled = true;
            subTopicComboBox.Location = new Point(12, 248);
            subTopicComboBox.Name = "subTopicComboBox";
            subTopicComboBox.Size = new Size(150, 33);
            subTopicComboBox.TabIndex = 7;
            subTopicComboBox.TextChanged += SubTopicComboBox_TextChanged;
            // 
            // geographyComboBox
            // 
            geographyComboBox.FormattingEnabled = true;
            geographyComboBox.Location = new Point(12, 312);
            geographyComboBox.Name = "geographyComboBox";
            geographyComboBox.Size = new Size(150, 33);
            geographyComboBox.TabIndex = 9;
            geographyComboBox.TextChanged += GeographyComboBox_TextChanged;
            // 
            // industryComboBox
            // 
            industryComboBox.FormattingEnabled = true;
            industryComboBox.Location = new Point(12, 374);
            industryComboBox.Name = "industryComboBox";
            industryComboBox.Size = new Size(150, 33);
            industryComboBox.TabIndex = 11;
            industryComboBox.TextChanged += IndustryComboBox_TextChanged;
            // 
            // naceComboBox
            // 
            naceComboBox.Location = new Point(12, 436);
            naceComboBox.Name = "naceComboBox";
            naceComboBox.Size = new Size(150, 33);
            naceComboBox.TabIndex = 13;
            naceComboBox.TextChanged += NaceComboBox_TextChanged;
            // 
            // materialComboBox
            // 
            materialComboBox.Location = new Point(12, 498);
            materialComboBox.Name = "materialComboBox";
            materialComboBox.Size = new Size(150, 33);
            materialComboBox.TabIndex = 15;
            materialComboBox.TextChanged += MaterialComboBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(materialComboBox);
            Controls.Add(naceComboBox);
            Controls.Add(industryComboBox);
            Controls.Add(geographyComboBox);
            Controls.Add(subTopicComboBox);
            Controls.Add(esrsTopicComboBox);
            Controls.Add(categoryComboBox);
            Controls.Add(additionalTextBox);
            Controls.Add(additionalLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(exportButton);
            Controls.Add(naceLabel);
            Controls.Add(industryLabel);
            Controls.Add(geographyLabel);
            Controls.Add(subtopicLabel);
            Controls.Add(filepathTextbox);
            Controls.Add(materialLabel);
            Controls.Add(esrsTopicLabel);
            Controls.Add(categoryLabel);
            Controls.Add(dataGridView);
            Controls.Add(BrowseButton);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void categoryLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button BrowseButton;
        private DoubleBufferedDataGridView dataGridView;
        private Label categoryLabel;
        private Label esrsTopicLabel;
        private TextBox esrsTopicTextBox;
        private TextBox materialTextBox;
        private Label materialLabel;
        private TextBox filepathTextbox;
        private TextBox subtopictextBox;
        private Label subtopicLabel;
        private TextBox geographytextBox;
        private Label geographyLabel;
        private TextBox industryTextBox;
        private Label label1;
        private Label industryLabel;
        private Label naceLabel;
        private TextBox naceTextBox;
        private Button exportButton;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private TextBox additionalTextBox;
        private Label additionalLabel;
        private ComboBox categoryComboBox;
        private ComboBox esrsTopicComboBox;
        private ComboBox subTopicComboBox;
        private ComboBox geographyComboBox;
        private ComboBox industryComboBox;
        private ComboBox naceComboBox;
        private ComboBox materialComboBox;
    }
}