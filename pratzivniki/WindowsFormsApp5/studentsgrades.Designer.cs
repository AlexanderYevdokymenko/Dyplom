namespace WindowsFormsApp5
{
    partial class studentsgrades
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.головнеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.групиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.викладачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисципліниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиТаЇхОцінкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиТаГрупиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлінняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.головнеМенюToolStripMenuItem,
            this.дляToolStripMenuItem,
            this.інформаціяToolStripMenuItem,
            this.управлінняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 41;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // головнеМенюToolStripMenuItem
            // 
            this.головнеМенюToolStripMenuItem.Name = "головнеМенюToolStripMenuItem";
            this.головнеМенюToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.головнеМенюToolStripMenuItem.Text = "Головне меню";
            this.головнеМенюToolStripMenuItem.Click += new System.EventHandler(this.головнеМенюToolStripMenuItem_Click);
            // 
            // дляToolStripMenuItem
            // 
            this.дляToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентиToolStripMenuItem,
            this.групиToolStripMenuItem,
            this.викладачіToolStripMenuItem,
            this.дисципліниToolStripMenuItem});
            this.дляToolStripMenuItem.Name = "дляToolStripMenuItem";
            this.дляToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.дляToolStripMenuItem.Text = "Довідники";
            // 
            // студентиToolStripMenuItem
            // 
            this.студентиToolStripMenuItem.Name = "студентиToolStripMenuItem";
            this.студентиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.студентиToolStripMenuItem.Text = "Працівники";
            this.студентиToolStripMenuItem.Click += new System.EventHandler(this.студентиToolStripMenuItem_Click);
            // 
            // групиToolStripMenuItem
            // 
            this.групиToolStripMenuItem.Name = "групиToolStripMenuItem";
            this.групиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.групиToolStripMenuItem.Text = "Комісії";
            this.групиToolStripMenuItem.Click += new System.EventHandler(this.групиToolStripMenuItem_Click);
            // 
            // викладачіToolStripMenuItem
            // 
            this.викладачіToolStripMenuItem.Name = "викладачіToolStripMenuItem";
            this.викладачіToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.викладачіToolStripMenuItem.Text = "Начальники";
            this.викладачіToolStripMenuItem.Click += new System.EventHandler(this.викладачіToolStripMenuItem_Click);
            // 
            // дисципліниToolStripMenuItem
            // 
            this.дисципліниToolStripMenuItem.Name = "дисципліниToolStripMenuItem";
            this.дисципліниToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.дисципліниToolStripMenuItem.Text = "Факультети";
            this.дисципліниToolStripMenuItem.Click += new System.EventHandler(this.дисципліниToolStripMenuItem_Click);
            // 
            // інформаціяToolStripMenuItem
            // 
            this.інформаціяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентиТаЇхОцінкиToolStripMenuItem,
            this.студентиТаГрупиToolStripMenuItem});
            this.інформаціяToolStripMenuItem.Name = "інформаціяToolStripMenuItem";
            this.інформаціяToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.інформаціяToolStripMenuItem.Text = "Інформація (представлення)";
            // 
            // студентиТаЇхОцінкиToolStripMenuItem
            // 
            this.студентиТаЇхОцінкиToolStripMenuItem.Name = "студентиТаЇхОцінкиToolStripMenuItem";
            this.студентиТаЇхОцінкиToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.студентиТаЇхОцінкиToolStripMenuItem.Text = "Працівники та їх рейтинг";
            this.студентиТаЇхОцінкиToolStripMenuItem.Click += new System.EventHandler(this.студентиТаЇхОцінкиToolStripMenuItem_Click);
            // 
            // студентиТаГрупиToolStripMenuItem
            // 
            this.студентиТаГрупиToolStripMenuItem.Name = "студентиТаГрупиToolStripMenuItem";
            this.студентиТаГрупиToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.студентиТаГрупиToolStripMenuItem.Text = "Працівники та їх комісії";
            this.студентиТаГрупиToolStripMenuItem.Click += new System.EventHandler(this.студентиТаГрупиToolStripMenuItem_Click);
            // 
            // управлінняToolStripMenuItem
            // 
            this.управлінняToolStripMenuItem.Name = "управлінняToolStripMenuItem";
            this.управлінняToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.управлінняToolStripMenuItem.Text = "Управління";
            this.управлінняToolStripMenuItem.Click += new System.EventHandler(this.управлінняToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(791, 369);
            this.dataGridView1.TabIndex = 40;
            // 
            // studentsgrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 508);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "studentsgrades";
            this.Text = "Працівники та їх рейтинг";
            this.Load += new System.EventHandler(this.studentsgrades_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem головнеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem групиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem викладачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дисципліниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиТаЇхОцінкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиТаГрупиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлінняToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}