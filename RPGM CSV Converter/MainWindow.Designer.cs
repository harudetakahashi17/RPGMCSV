namespace RPGM_CSV_Converter
{
    partial class MainWindow
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
        private void InitializeComponent()
        {
            this.lblInsertCSV = new System.Windows.Forms.Label();
            this.lblSelectOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.RichTextBox();
            this.OpenFileCSV = new System.Windows.Forms.OpenFileDialog();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblOutputDir = new System.Windows.Forms.Label();
            this.tbOutputDir = new System.Windows.Forms.RichTextBox();
            this.btnOutputDir = new System.Windows.Forms.Button();
            this.OutputDir = new System.Windows.Forms.FolderBrowserDialog();
            this.btnConvert = new System.Windows.Forms.Button();
            this.tbInformation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblInsertCSV
            // 
            this.lblInsertCSV.AutoSize = true;
            this.lblInsertCSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInsertCSV.Location = new System.Drawing.Point(45, 54);
            this.lblInsertCSV.Name = "lblInsertCSV";
            this.lblInsertCSV.Size = new System.Drawing.Size(82, 21);
            this.lblInsertCSV.TabIndex = 0;
            this.lblInsertCSV.Text = "Insert CSV";
            this.lblInsertCSV.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSelectOutput
            // 
            this.lblSelectOutput.AutoSize = true;
            this.lblSelectOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectOutput.Location = new System.Drawing.Point(45, 111);
            this.lblSelectOutput.Name = "lblSelectOutput";
            this.lblSelectOutput.Size = new System.Drawing.Size(104, 21);
            this.lblSelectOutput.TabIndex = 1;
            this.lblSelectOutput.Text = "Select Output";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(527, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(155, 54);
            this.tbFileName.Multiline = false;
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.ReadOnly = true;
            this.tbFileName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbFileName.Size = new System.Drawing.Size(366, 21);
            this.tbFileName.TabIndex = 3;
            this.tbFileName.Text = "";
            this.tbFileName.TextChanged += new System.EventHandler(this.tbFileName_TextChanged);
            // 
            // OpenFileCSV
            // 
            this.OpenFileCSV.Filter = "CSV files|*.csv";
            this.OpenFileCSV.Title = "Select CSV File";
            this.OpenFileCSV.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileCSV_FileOk);
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.FormattingEnabled = true;
            this.cbType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbType.Items.AddRange(new object[] {
            "Armors",
            "Classes",
            "Enemies",
            "Items",
            "Skills",
            "Types",
            "Weapons"});
            this.cbType.Location = new System.Drawing.Point(155, 111);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(366, 23);
            this.cbType.Sorted = true;
            this.cbType.TabIndex = 4;
            this.cbType.Text = "Select Output Type";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblOutputDir
            // 
            this.lblOutputDir.AutoSize = true;
            this.lblOutputDir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutputDir.Location = new System.Drawing.Point(45, 173);
            this.lblOutputDir.Name = "lblOutputDir";
            this.lblOutputDir.Size = new System.Drawing.Size(84, 21);
            this.lblOutputDir.TabIndex = 5;
            this.lblOutputDir.Text = "Output Dir";
            this.lblOutputDir.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tbOutputDir
            // 
            this.tbOutputDir.Location = new System.Drawing.Point(155, 173);
            this.tbOutputDir.Multiline = false;
            this.tbOutputDir.Name = "tbOutputDir";
            this.tbOutputDir.ReadOnly = true;
            this.tbOutputDir.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbOutputDir.Size = new System.Drawing.Size(366, 21);
            this.tbOutputDir.TabIndex = 6;
            this.tbOutputDir.Text = "";
            // 
            // btnOutputDir
            // 
            this.btnOutputDir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOutputDir.Location = new System.Drawing.Point(527, 173);
            this.btnOutputDir.Name = "btnOutputDir";
            this.btnOutputDir.Size = new System.Drawing.Size(95, 21);
            this.btnOutputDir.TabIndex = 7;
            this.btnOutputDir.Text = "Browse";
            this.btnOutputDir.UseVisualStyleBackColor = true;
            this.btnOutputDir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(155, 215);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(366, 21);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // tbInformation
            // 
            this.tbInformation.Location = new System.Drawing.Point(45, 266);
            this.tbInformation.Name = "tbInformation";
            this.tbInformation.ReadOnly = true;
            this.tbInformation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbInformation.Size = new System.Drawing.Size(577, 150);
            this.tbInformation.TabIndex = 9;
            this.tbInformation.Text = "";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.tbInformation);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnOutputDir);
            this.Controls.Add(this.tbOutputDir);
            this.Controls.Add(this.lblOutputDir);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSelectOutput);
            this.Controls.Add(this.lblInsertCSV);
            this.Name = "MainWindow";
            this.Text = "RPG Maker CSV Converter V1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInsertCSV;
        private Label lblSelectOutput;
        private Button button1;
        private RichTextBox tbFileName;
        private ComboBox cbType;
        public OpenFileDialog OpenFileCSV;
        private Label lblOutputDir;
        private RichTextBox tbOutputDir;
        private Button btnOutputDir;
        private FolderBrowserDialog OutputDir;
        private Button btnConvert;
        private RichTextBox tbInformation;
    }
}