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
            categoryTextBox = new TextBox();
            categoryLabel = new Label();
            esrsTopicLabel = new Label();
            esrsTopicTextBox = new TextBox();
            materialTextBox = new TextBox();
            materialLabel = new Label();
            filepathTextbox = new TextBox();
            subtopictextBox = new TextBox();
            subtopicLabel = new Label();
            geographytextBox = new TextBox();
            geographyLabel = new Label();
            industryTextBox = new TextBox();
            label1 = new Label();
            industryLabel = new Label();
            naceLabel = new Label();
            naceTextBox = new TextBox();
            exportButton = new Button();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            additionalTextBox = new TextBox();
            additionalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // BrowseButton
            // 
            BrowseButton.Location = new Point(12, 29);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(112, 34);
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
            dataGridView.Location = new Point(187, 98);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(972, 537);
            dataGridView.TabIndex = 20;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // categoryTextBox
            // 
            categoryTextBox.Location = new Point(12, 98);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.Size = new Size(150, 31);
            categoryTextBox.TabIndex = 2;
            categoryTextBox.TextChanged += categoryTextBox_TextChanged;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(16, 70);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(84, 25);
            categoryLabel.TabIndex = 3;
            categoryLabel.Text = "Category";
            // 
            // esrsTopicLabel
            // 
            esrsTopicLabel.AutoSize = true;
            esrsTopicLabel.Location = new Point(18, 132);
            esrsTopicLabel.Name = "esrsTopicLabel";
            esrsTopicLabel.Size = new Size(98, 25);
            esrsTopicLabel.TabIndex = 4;
            esrsTopicLabel.Text = "ESRS Topic";
            // 
            // esrsTopicTextBox
            // 
            esrsTopicTextBox.Location = new Point(12, 160);
            esrsTopicTextBox.Name = "esrsTopicTextBox";
            esrsTopicTextBox.Size = new Size(150, 31);
            esrsTopicTextBox.TabIndex = 5;
            esrsTopicTextBox.TextChanged += esrsTopicTextBox_TextChanged;
            // 
            // materialTextBox
            // 
            materialTextBox.Location = new Point(10, 470);
            materialTextBox.Name = "materialTextBox";
            materialTextBox.Size = new Size(150, 31);
            materialTextBox.TabIndex = 15;
            materialTextBox.TextChanged += materialTextBox_TextChanged;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new Point(14, 442);
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
            // subtopictextBox
            // 
            subtopictextBox.Location = new Point(12, 222);
            subtopictextBox.Name = "subtopictextBox";
            subtopictextBox.Size = new Size(150, 31);
            subtopictextBox.TabIndex = 7;
            subtopictextBox.TextChanged += subtopictextBox_TextChanged;
            // 
            // subtopicLabel
            // 
            subtopicLabel.AutoSize = true;
            subtopicLabel.Location = new Point(16, 194);
            subtopicLabel.Name = "subtopicLabel";
            subtopicLabel.Size = new Size(91, 25);
            subtopicLabel.TabIndex = 10;
            subtopicLabel.Text = "Sub-Topic";
            // 
            // geographytextBox
            // 
            geographytextBox.Location = new Point(12, 284);
            geographytextBox.Name = "geographytextBox";
            geographytextBox.Size = new Size(150, 31);
            geographytextBox.TabIndex = 9;
            geographytextBox.TextChanged += geographytextBox_TextChanged;
            // 
            // geographyLabel
            // 
            geographyLabel.AutoSize = true;
            geographyLabel.Location = new Point(16, 256);
            geographyLabel.Name = "geographyLabel";
            geographyLabel.Size = new Size(100, 25);
            geographyLabel.TabIndex = 12;
            geographyLabel.Text = "Geography";
            // 
            // industryTextBox
            // 
            industryTextBox.Location = new Point(12, 346);
            industryTextBox.Name = "industryTextBox";
            industryTextBox.Size = new Size(150, 31);
            industryTextBox.TabIndex = 11;
            industryTextBox.TextChanged += industryTextBox_TextChanged;
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
            industryLabel.Location = new Point(16, 318);
            industryLabel.Name = "industryLabel";
            industryLabel.Size = new Size(77, 25);
            industryLabel.TabIndex = 17;
            industryLabel.Text = "Industry";
            // 
            // naceLabel
            // 
            naceLabel.AutoSize = true;
            naceLabel.Location = new Point(16, 380);
            naceLabel.Name = "naceLabel";
            naceLabel.Size = new Size(57, 25);
            naceLabel.TabIndex = 19;
            naceLabel.Text = "NACE";
            // 
            // naceTextBox
            // 
            naceTextBox.Location = new Point(12, 408);
            naceTextBox.Name = "naceTextBox";
            naceTextBox.Size = new Size(150, 31);
            naceTextBox.TabIndex = 13;
            naceTextBox.TextChanged += naceTextBox_TextChanged;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(1047, 29);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(112, 34);
            exportButton.TabIndex = 21;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(8, 532);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(150, 31);
            descriptionTextBox.TabIndex = 23;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(12, 504);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(102, 25);
            descriptionLabel.TabIndex = 22;
            descriptionLabel.Text = "Description";
            // 
            // additionalTextBox
            // 
            additionalTextBox.Location = new Point(8, 594);
            additionalTextBox.Name = "additionalTextBox";
            additionalTextBox.Size = new Size(150, 31);
            additionalTextBox.TabIndex = 25;
            additionalTextBox.TextChanged += additionalTextBox_TextChanged;
            // 
            // additionalLabel
            // 
            additionalLabel.AutoSize = true;
            additionalLabel.Location = new Point(12, 566);
            additionalLabel.Name = "additionalLabel";
            additionalLabel.Size = new Size(130, 25);
            additionalLabel.TabIndex = 24;
            additionalLabel.Text = "Additional info";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 647);
            Controls.Add(additionalTextBox);
            Controls.Add(additionalLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(exportButton);
            Controls.Add(naceLabel);
            Controls.Add(naceTextBox);
            Controls.Add(industryLabel);
            Controls.Add(industryTextBox);
            Controls.Add(geographytextBox);
            Controls.Add(geographyLabel);
            Controls.Add(subtopictextBox);
            Controls.Add(subtopicLabel);
            Controls.Add(filepathTextbox);
            Controls.Add(materialTextBox);
            Controls.Add(materialLabel);
            Controls.Add(esrsTopicTextBox);
            Controls.Add(esrsTopicLabel);
            Controls.Add(categoryLabel);
            Controls.Add(categoryTextBox);
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
        private TextBox categoryTextBox;
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
    }
}