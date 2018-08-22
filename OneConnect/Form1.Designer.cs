<<<<<<< HEAD
﻿namespace OneConnect
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
=======
﻿namespace OneConnect
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> 4ed131db0ebc02d2bad867e92add927eca4d04c6
            this.txt_schema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Run = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqliteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_databaseName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_getSchema = new System.Windows.Forms.Button();
            this.cmb_tableName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_schema
            // 
            this.txt_schema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_schema.Location = new System.Drawing.Point(27, 649);
            this.txt_schema.Margin = new System.Windows.Forms.Padding(2);
            this.txt_schema.Multiline = true;
            this.txt_schema.Name = "txt_schema";
            this.txt_schema.Size = new System.Drawing.Size(657, 218);
            this.txt_schema.TabIndex = 0;
            this.txt_schema.TextChanged += new System.EventHandler(this.txt_schema_TextChanged);
            this.txt_schema.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_schema_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 612);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database Query";
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(27, 879);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(56, 35);
            this.btn_Run.TabIndex = 6;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(34, 911);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 20);
            this.lbl_Error.TabIndex = 7;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.openDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sqlLiteToolStripMenuItem,
            this.mySqlToolStripMenuItem});
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            this.openDatabaseToolStripMenuItem.Text = "Open Database";
            // 
            // sqlLiteToolStripMenuItem
            // 
            this.sqlLiteToolStripMenuItem.Name = "sqlLiteToolStripMenuItem";
            this.sqlLiteToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.sqlLiteToolStripMenuItem.Text = "Sql Lite";
            this.sqlLiteToolStripMenuItem.Click += new System.EventHandler(this.sqlLiteToolStripMenuItem_Click);
            // 
            // mySqlToolStripMenuItem
            // 
            this.mySqlToolStripMenuItem.Name = "mySqlToolStripMenuItem";
            this.mySqlToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.mySqlToolStripMenuItem.Text = "SQL";
            this.mySqlToolStripMenuItem.Click += new System.EventHandler(this.mySqlToolStripMenuItem_Click);
            // 
            // createDatabaseToolStripMenuItem
            // 
            this.createDatabaseToolStripMenuItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.createDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sqliteToolStripMenuItem,
            this.sQLToolStripMenuItem});
            this.createDatabaseToolStripMenuItem.Name = "createDatabaseToolStripMenuItem";
            this.createDatabaseToolStripMenuItem.Size = new System.Drawing.Size(153, 29);
            this.createDatabaseToolStripMenuItem.Text = "Create Database";
            this.createDatabaseToolStripMenuItem.Click += new System.EventHandler(this.createDatabaseToolStripMenuItem_Click);
            // 
            // sqliteToolStripMenuItem
            // 
            this.sqliteToolStripMenuItem.Name = "sqliteToolStripMenuItem";
            this.sqliteToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.sqliteToolStripMenuItem.Text = "Sqlite";
            this.sqliteToolStripMenuItem.Click += new System.EventHandler(this.sqliteToolStripMenuItem_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDatabaseToolStripMenuItem,
            this.createDatabaseToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1793, 33);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1793, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_databaseName
            // 
            this.lbl_databaseName.AutoSize = true;
            this.lbl_databaseName.Location = new System.Drawing.Point(24, 119);
            this.lbl_databaseName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_databaseName.Name = "lbl_databaseName";
            this.lbl_databaseName.Size = new System.Drawing.Size(0, 20);
            this.lbl_databaseName.TabIndex = 9;
            this.lbl_databaseName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(27, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 450);
            this.dataGridView1.TabIndex = 10;
            // 
            // btn_getSchema
            // 
            this.btn_getSchema.Location = new System.Drawing.Point(93, 879);
            this.btn_getSchema.Margin = new System.Windows.Forms.Padding(2);
            this.btn_getSchema.Name = "btn_getSchema";
            this.btn_getSchema.Size = new System.Drawing.Size(119, 35);
            this.btn_getSchema.TabIndex = 11;
            this.btn_getSchema.Text = "Get Schema";
            this.btn_getSchema.UseVisualStyleBackColor = true;
            this.btn_getSchema.Click += new System.EventHandler(this.btn_getSchema_Click);
            // 
            // cmb_tableName
            // 
            this.cmb_tableName.FormattingEnabled = true;
            this.cmb_tableName.Location = new System.Drawing.Point(27, 60);
            this.cmb_tableName.Name = "cmb_tableName";
            this.cmb_tableName.Size = new System.Drawing.Size(455, 28);
            this.cmb_tableName.TabIndex = 12;
            this.cmb_tableName.SelectedIndexChanged += new System.EventHandler(this.cmb_tableName_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 1254);
            this.Controls.Add(this.cmb_tableName);
            this.Controls.Add(this.btn_getSchema);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_databaseName);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_schema);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1564, 1131);
            this.Name = "Form1";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_schema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label lbl_Error;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sqlLiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mySqlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDatabaseToolStripMenuItem;
        private System.Windows.Forms.Label lbl_databaseName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_getSchema;
        private System.Windows.Forms.ToolStripMenuItem sqliteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
<<<<<<< HEAD
        private System.Windows.Forms.ComboBox cmb_tableName;
    }
}

=======
    }
}

>>>>>>> 4ed131db0ebc02d2bad867e92add927eca4d04c6
