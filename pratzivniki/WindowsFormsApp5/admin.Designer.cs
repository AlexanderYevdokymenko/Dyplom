namespace WindowsFormsApp5
{
    partial class admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.головнеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.групиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дисципліниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.викладачіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяпредставленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиТаЇхОцінкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиТаГрупиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлінняToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідЗАкаунтуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідЗЗастосункуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(630, 304);
            this.dataGridView1.TabIndex = 20;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(534, 441);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(125, 44);
            this.button_Delete.TabIndex = 19;
            this.button_Delete.Text = "Видалити";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(241, 441);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(125, 44);
            this.button_Save.TabIndex = 18;
            this.button_Save.Text = "Зберегти";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.головнеМенюToolStripMenuItem,
            this.довідникиToolStripMenuItem,
            this.інформаціяпредставленняToolStripMenuItem,
            this.управлінняToolStripMenuItem1,
            this.вихідToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1012, 28);
            this.menuStrip2.TabIndex = 17;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // головнеМенюToolStripMenuItem
            // 
            this.головнеМенюToolStripMenuItem.Name = "головнеМенюToolStripMenuItem";
            this.головнеМенюToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.головнеМенюToolStripMenuItem.Text = "Головне меню";
            this.головнеМенюToolStripMenuItem.Click += new System.EventHandler(this.головнеМенюToolStripMenuItem_Click);
            // 
            // довідникиToolStripMenuItem
            // 
            this.довідникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентиToolStripMenuItem,
            this.групиToolStripMenuItem,
            this.дисципліниToolStripMenuItem,
            this.викладачіToolStripMenuItem});
            this.довідникиToolStripMenuItem.Name = "довідникиToolStripMenuItem";
            this.довідникиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.довідникиToolStripMenuItem.Text = "Довідники";
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
            // дисципліниToolStripMenuItem
            // 
            this.дисципліниToolStripMenuItem.Name = "дисципліниToolStripMenuItem";
            this.дисципліниToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.дисципліниToolStripMenuItem.Text = "Факультети";
            this.дисципліниToolStripMenuItem.Click += new System.EventHandler(this.дисципліниToolStripMenuItem_Click);
            // 
            // викладачіToolStripMenuItem
            // 
            this.викладачіToolStripMenuItem.Name = "викладачіToolStripMenuItem";
            this.викладачіToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.викладачіToolStripMenuItem.Text = "Начальники";
            // 
            // інформаціяпредставленняToolStripMenuItem
            // 
            this.інформаціяпредставленняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентиТаЇхОцінкиToolStripMenuItem,
            this.студентиТаГрупиToolStripMenuItem});
            this.інформаціяпредставленняToolStripMenuItem.Name = "інформаціяпредставленняToolStripMenuItem";
            this.інформаціяпредставленняToolStripMenuItem.Size = new System.Drawing.Size(223, 24);
            this.інформаціяпредставленняToolStripMenuItem.Text = "Інформація (представлення)";
            // 
            // студентиТаЇхОцінкиToolStripMenuItem
            // 
            this.студентиТаЇхОцінкиToolStripMenuItem.Name = "студентиТаЇхОцінкиToolStripMenuItem";
            this.студентиТаЇхОцінкиToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.студентиТаЇхОцінкиToolStripMenuItem.Text = "Праціники та їх рейтинг";
            // 
            // студентиТаГрупиToolStripMenuItem
            // 
            this.студентиТаГрупиToolStripMenuItem.Name = "студентиТаГрупиToolStripMenuItem";
            this.студентиТаГрупиToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.студентиТаГрупиToolStripMenuItem.Text = "Працівники та їх комісії";
            this.студентиТаГрупиToolStripMenuItem.Click += new System.EventHandler(this.студентиТаГрупиToolStripMenuItem_Click);
            // 
            // управлінняToolStripMenuItem1
            // 
            this.управлінняToolStripMenuItem1.Name = "управлінняToolStripMenuItem1";
            this.управлінняToolStripMenuItem1.Size = new System.Drawing.Size(104, 24);
            this.управлінняToolStripMenuItem1.Text = "Управління";
            // 
            // вихідToolStripMenuItem1
            // 
            this.вихідToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідЗАкаунтуToolStripMenuItem1,
            this.вихідЗЗастосункуToolStripMenuItem});
            this.вихідToolStripMenuItem1.Name = "вихідToolStripMenuItem1";
            this.вихідToolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.вихідToolStripMenuItem1.Text = "Вихід";
            // 
            // вихідЗАкаунтуToolStripMenuItem1
            // 
            this.вихідЗАкаунтуToolStripMenuItem1.Name = "вихідЗАкаунтуToolStripMenuItem1";
            this.вихідЗАкаунтуToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.вихідЗАкаунтуToolStripMenuItem1.Text = "Вихід з акаунту";
            // 
            // вихідЗЗастосункуToolStripMenuItem
            // 
            this.вихідЗЗастосункуToolStripMenuItem.Name = "вихідЗЗастосункуToolStripMenuItem";
            this.вихідЗЗастосункуToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.вихідЗЗастосункуToolStripMenuItem.Text = "Вихід з застосунку";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.menuStrip2);
            this.Name = "admin";
            this.Text = "Управління";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem головнеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяпредставленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлінняToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вихідЗАкаунтуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вихідЗЗастосункуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem групиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дисципліниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem викладачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиТаЇхОцінкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиТаГрупиToolStripMenuItem;
    }
}