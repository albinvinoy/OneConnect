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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_newDb = new System.Windows.Forms.Button();
            this.btn_openDb = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_schema
            // 
            this.txt_schema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_schema.Location = new System.Drawing.Point(230, 797);
            this.txt_schema.Multiline = true;
            this.txt_schema.Name = "txt_schema";
            this.txt_schema.Size = new System.Drawing.Size(1165, 335);
            this.txt_schema.TabIndex = 0;
            this.txt_schema.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_schema_KeyUp);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(230, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1715, 604);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 740);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Database Query";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2740, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_newDb
            // 
            this.btn_newDb.Location = new System.Drawing.Point(12, 124);
            this.btn_newDb.Name = "btn_newDb";
            this.btn_newDb.Size = new System.Drawing.Size(198, 81);
            this.btn_newDb.TabIndex = 4;
            this.btn_newDb.Text = "Create Database";
            this.btn_newDb.UseVisualStyleBackColor = true;
            // 
            // btn_openDb
            // 
            this.btn_openDb.Location = new System.Drawing.Point(12, 276);
            this.btn_openDb.Name = "btn_openDb";
            this.btn_openDb.Size = new System.Drawing.Size(198, 81);
            this.btn_openDb.TabIndex = 5;
            this.btn_openDb.Text = "Open Database";
            this.btn_openDb.UseVisualStyleBackColor = true;
            this.btn_openDb.Click += new System.EventHandler(this.btn_openDb_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(230, 1153);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(100, 55);
            this.btn_Run.TabIndex = 6;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2740, 1653);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_openDb);
            this.Controls.Add(this.btn_newDb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txt_schema);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(2772, 1741);
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_schema;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_newDb;
        private System.Windows.Forms.Button btn_openDb;
        private System.Windows.Forms.Button btn_Run;
    }
}

