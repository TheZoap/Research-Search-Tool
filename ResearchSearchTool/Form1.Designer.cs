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
            dataGridView1 = new DoubleBufferedDataGridView();
            categoryTextBox = new TextBox();
            categoryLabel = new Label();
            esrsTopicLabel = new Label();
            esrsTopicTextBox = new TextBox();
            materialTextBox = new TextBox();
            materialLabel = new Label();
            readButton = new Button();
            filepathTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BrowseButton
            // 
            BrowseButton.Location = new Point(918, 32);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(112, 34);
            BrowseButton.TabIndex = 0;
            BrowseButton.Text = "Browse File";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(187, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(972, 537);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            categoryLabel.Location = new Point(12, 70);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(84, 25);
            categoryLabel.TabIndex = 3;
            categoryLabel.Text = "Category";
            // 
            // esrsTopicLabel
            // 
            esrsTopicLabel.AutoSize = true;
            esrsTopicLabel.Location = new Point(12, 146);
            esrsTopicLabel.Name = "esrsTopicLabel";
            esrsTopicLabel.Size = new Size(98, 25);
            esrsTopicLabel.TabIndex = 4;
            esrsTopicLabel.Text = "ESRS Topic";
            // 
            // esrsTopicTextBox
            // 
            esrsTopicTextBox.Location = new Point(12, 174);
            esrsTopicTextBox.Name = "esrsTopicTextBox";
            esrsTopicTextBox.Size = new Size(150, 31);
            esrsTopicTextBox.TabIndex = 5;
            esrsTopicTextBox.TextChanged += esrsTopicTextBox_TextChanged;
            // 
            // materialTextBox
            // 
            materialTextBox.Location = new Point(12, 254);
            materialTextBox.Name = "materialTextBox";
            materialTextBox.Size = new Size(150, 31);
            materialTextBox.TabIndex = 7;
            materialTextBox.TextChanged += materialTextBox_TextChanged;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Location = new Point(12, 226);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(75, 25);
            materialLabel.TabIndex = 6;
            materialLabel.Text = "Material";
            // 
            // readButton
            // 
            readButton.Location = new Point(1036, 32);
            readButton.Name = "readButton";
            readButton.Size = new Size(112, 34);
            readButton.TabIndex = 8;
            readButton.Text = "Read";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += readButton_Click;
            // 
            // filepathTextbox
            // 
            filepathTextbox.Location = new Point(12, 32);
            filepathTextbox.Name = "filepathTextbox";
            filepathTextbox.Size = new Size(871, 31);
            filepathTextbox.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 647);
            Controls.Add(filepathTextbox);
            Controls.Add(readButton);
            Controls.Add(materialTextBox);
            Controls.Add(materialLabel);
            Controls.Add(esrsTopicTextBox);
            Controls.Add(esrsTopicLabel);
            Controls.Add(categoryLabel);
            Controls.Add(categoryTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(BrowseButton);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void categoryLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button BrowseButton;
        private DoubleBufferedDataGridView dataGridView1;
        private TextBox categoryTextBox;
        private Label categoryLabel;
        private Label esrsTopicLabel;
        private TextBox esrsTopicTextBox;
        private TextBox materialTextBox;
        private Label materialLabel;
        private Button readButton;
        private TextBox filepathTextbox;
    }
}