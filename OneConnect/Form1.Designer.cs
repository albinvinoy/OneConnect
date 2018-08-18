namespace OneConnect
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
            this.txt_schema = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Run = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlLiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySqlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_databaseName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_schema
            // 
            this.txt_schema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_schema.Location = new System.Drawing.Point(65, 896);
            this.txt_schema.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_schema.Multiline = true;
            this.txt_schema.Name = "txt_schema";
            this.txt_schema.Size = new System.Drawing.Size(1165, 336);
            this.txt_schema.TabIndex = 0;
            this.txt_schema.TextChanged += new System.EventHandler(this.txt_schema_TextChanged);
            this.txt_schema.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_schema_KeyUp);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(65, 130);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1524, 639);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 838);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database Query";
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(65, 1252);
            this.btn_Run.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(100, 54);
            this.btn_Run.TabIndex = 6;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(60, 1412);
            this.lbl_Error.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 32);
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
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(235, 45);
            this.openDatabaseToolStripMenuItem.Text = "Open Database";
            // 
            // sqlLiteToolStripMenuItem
            // 
            this.sqlLiteToolStripMenuItem.Name = "sqlLiteToolStripMenuItem";
            this.sqlLiteToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.sqlLiteToolStripMenuItem.Text = "Sql Lite";
            this.sqlLiteToolStripMenuItem.Click += new System.EventHandler(this.sqlLiteToolStripMenuItem_Click);
            // 
            // mySqlToolStripMenuItem
            // 
            this.mySqlToolStripMenuItem.Name = "mySqlToolStripMenuItem";
            this.mySqlToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
            this.mySqlToolStripMenuItem.Text = "My Sql";
            // 
            // createDatabaseToolStripMenuItem
            // 
            this.createDatabaseToolStripMenuItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.createDatabaseToolStripMenuItem.Name = "createDatabaseToolStripMenuItem";
            this.createDatabaseToolStripMenuItem.Size = new System.Drawing.Size(247, 45);
            this.createDatabaseToolStripMenuItem.Text = "Create Database";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDatabaseToolStripMenuItem,
            this.createDatabaseToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(3187, 51);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Location = new System.Drawing.Point(0, 51);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(3187, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_databaseName
            // 
            this.lbl_databaseName.AutoSize = true;
            this.lbl_databaseName.Location = new System.Drawing.Point(60, 75);
            this.lbl_databaseName.Name = "lbl_databaseName";
            this.lbl_databaseName.Size = new System.Drawing.Size(0, 32);
            this.lbl_databaseName.TabIndex = 9;
            this.lbl_databaseName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3187, 1943);
            this.Controls.Add(this.lbl_databaseName);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txt_schema);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(2764, 1723);
            this.Name = "Form1";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_schema;
        private System.Windows.Forms.ListView listView1;
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
    }
}

