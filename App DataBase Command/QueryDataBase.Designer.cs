namespace App_DataBase_Command
{
    partial class QueryDataBase
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            OpenMenuItem = new ToolStripMenuItem();
            SaveMenuItem = new ToolStripMenuItem();
            SaveHowMenuItem = new ToolStripMenuItem();
            convertoToolStripMenuItem = new ToolStripMenuItem();
            EportMenuItemExport = new ToolStripMenuItem();
            ShowMenuItem = new ToolStripMenuItem();
            dataFile = new DataGridView();
            fileNameLBL = new Label();
            QueryTxb = new TextBox();
            QueryBtm = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataFile).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, convertoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1127, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenMenuItem, SaveMenuItem, SaveHowMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 25);
            fileToolStripMenuItem.Text = "File";
            // 
            // OpenMenuItem
            // 
            OpenMenuItem.Name = "OpenMenuItem";
            OpenMenuItem.Size = new Size(145, 26);
            OpenMenuItem.Text = "Open";
            OpenMenuItem.Click += OpenMenuItem_Click;
            // 
            // SaveMenuItem
            // 
            SaveMenuItem.Name = "SaveMenuItem";
            SaveMenuItem.Size = new Size(145, 26);
            SaveMenuItem.Text = "Save";
            SaveMenuItem.Click += SaveMenuItem_Click;
            // 
            // SaveHowMenuItem
            // 
            SaveHowMenuItem.Name = "SaveHowMenuItem";
            SaveHowMenuItem.Size = new Size(145, 26);
            SaveHowMenuItem.Text = "SaveHow";
            SaveHowMenuItem.Click += SaveHowMenuItem_Click;
            // 
            // convertoToolStripMenuItem
            // 
            convertoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { EportMenuItemExport, ShowMenuItem });
            convertoToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            convertoToolStripMenuItem.Name = "convertoToolStripMenuItem";
            convertoToolStripMenuItem.Size = new Size(86, 25);
            convertoToolStripMenuItem.Text = "DataBase";
            // 
            // EportMenuItemExport
            // 
            EportMenuItemExport.Name = "EportMenuItemExport";
            EportMenuItemExport.Size = new Size(124, 26);
            EportMenuItemExport.Text = "Export";
            EportMenuItemExport.Click += ExportMenuItemExport_Click;
            // 
            // ShowMenuItem
            // 
            ShowMenuItem.Name = "ShowMenuItem";
            ShowMenuItem.Size = new Size(124, 26);
            ShowMenuItem.Text = "Show";
            ShowMenuItem.Click += ShowMenuItem_Click;
            // 
            // dataFile
            // 
            dataFile.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataFile.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFile.Location = new Point(335, 53);
            dataFile.Name = "dataFile";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataFile.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataFile.Size = new Size(780, 420);
            dataFile.TabIndex = 1;
            // 
            // fileNameLBL
            // 
            fileNameLBL.AutoSize = true;
            fileNameLBL.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileNameLBL.Location = new Point(12, 53);
            fileNameLBL.Name = "fileNameLBL";
            fileNameLBL.Size = new Size(179, 25);
            fileNameLBL.TabIndex = 2;
            fileNameLBL.Text = "Nombre del archivo";
            // 
            // QueryTxb
            // 
            QueryTxb.Location = new Point(12, 267);
            QueryTxb.Multiline = true;
            QueryTxb.Name = "QueryTxb";
            QueryTxb.Size = new Size(317, 170);
            QueryTxb.TabIndex = 3;
            // 
            // QueryBtm
            // 
            QueryBtm.Font = new Font("Segoe UI", 12F);
            QueryBtm.Location = new Point(12, 443);
            QueryBtm.Name = "QueryBtm";
            QueryBtm.Size = new Size(157, 33);
            QueryBtm.TabIndex = 4;
            QueryBtm.Text = "Consulta";
            QueryBtm.UseVisualStyleBackColor = true;
            QueryBtm.Click += QueryBtm_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 29);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 104);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 5;
            label1.Text = "Selecciona una tabla";
            // 
            // QueryDataBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 485);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(QueryBtm);
            Controls.Add(QueryTxb);
            Controls.Add(fileNameLBL);
            Controls.Add(dataFile);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "QueryDataBase";
            Text = "Form1";
            Load += QueryDataBase_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataFile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem OpenMenuItem;
        private ToolStripMenuItem SaveMenuItem;
        private ToolStripMenuItem SaveHowMenuItem;
        private ToolStripMenuItem convertoToolStripMenuItem;
        private ToolStripMenuItem CSVMenuItemExport;
        private ToolStripMenuItem XMLMenuItemExport;
        private ToolStripMenuItem EportMenuItemExport;
        private DataGridView dataFile;
        private Label fileNameLBL;
        private ToolStripMenuItem ShowMenuItem;
        private TextBox QueryTxb;
        private Button QueryBtm;
        private ComboBox comboBox1;
        private Label label1;
    }
}
