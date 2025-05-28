namespace WindowsFormsApp5
{
    partial class main
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.довідникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.групиїToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.дисципліниToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.викладачіToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.інформаціяпредставленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиТаЇхОцінкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиТаГрупиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлінняToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідЗАкаунтуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідЗЗастосункуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tUserStatus = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.PaleGreen;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.довідникиToolStripMenuItem,
            this.інформаціяпредставленняToolStripMenuItem,
            this.управлінняToolStripMenuItem1,
            this.вихідToolStripMenuItem1,
            this.tUserStatus});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(931, 31);
            this.menuStrip2.TabIndex = 11;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // довідникиToolStripMenuItem
            // 
            this.довідникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентиToolStripMenuItem1,
            this.групиїToolStripMenuItem1,
            this.дисципліниToolStripMenuItem1,
            this.викладачіToolStripMenuItem1});
            this.довідникиToolStripMenuItem.Name = "довідникиToolStripMenuItem";
            this.довідникиToolStripMenuItem.Size = new System.Drawing.Size(115, 27);
            this.довідникиToolStripMenuItem.Text = "Довідники";
            // 
            // студентиToolStripMenuItem1
            // 
            this.студентиToolStripMenuItem1.Name = "студентиToolStripMenuItem1";
            this.студентиToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.студентиToolStripMenuItem1.Text = "Працівники";
            this.студентиToolStripMenuItem1.Click += new System.EventHandler(this.студентиToolStripMenuItem1_Click);
            // 
            // групиїToolStripMenuItem1
            // 
            this.групиїToolStripMenuItem1.Name = "групиїToolStripMenuItem1";
            this.групиїToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.групиїToolStripMenuItem1.Text = "Комісії";
            this.групиїToolStripMenuItem1.Click += new System.EventHandler(this.групиїToolStripMenuItem1_Click);
            // 
            // дисципліниToolStripMenuItem1
            // 
            this.дисципліниToolStripMenuItem1.Name = "дисципліниToolStripMenuItem1";
            this.дисципліниToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.дисципліниToolStripMenuItem1.Text = "Факультети";
            this.дисципліниToolStripMenuItem1.Click += new System.EventHandler(this.дисципліниToolStripMenuItem1_Click);
            // 
            // викладачіToolStripMenuItem1
            // 
            this.викладачіToolStripMenuItem1.Name = "викладачіToolStripMenuItem1";
            this.викладачіToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.викладачіToolStripMenuItem1.Text = "Начальники";
            this.викладачіToolStripMenuItem1.Click += new System.EventHandler(this.викладачіToolStripMenuItem1_Click);
            // 
            // інформаціяпредставленняToolStripMenuItem
            // 
            this.інформаціяпредставленняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентиТаЇхОцінкиToolStripMenuItem,
            this.студентиТаГрупиToolStripMenuItem});
            this.інформаціяпредставленняToolStripMenuItem.Name = "інформаціяпредставленняToolStripMenuItem";
            this.інформаціяпредставленняToolStripMenuItem.Size = new System.Drawing.Size(263, 27);
            this.інформаціяпредставленняToolStripMenuItem.Text = "Інформація (представлення)";
            // 
            // студентиТаЇхОцінкиToolStripMenuItem
            // 
            this.студентиТаЇхОцінкиToolStripMenuItem.Name = "студентиТаЇхОцінкиToolStripMenuItem";
            this.студентиТаЇхОцінкиToolStripMenuItem.Size = new System.Drawing.Size(308, 28);
            this.студентиТаЇхОцінкиToolStripMenuItem.Text = "Працівники та їх рейтинг";
            this.студентиТаЇхОцінкиToolStripMenuItem.Click += new System.EventHandler(this.студентиТаЇхОцінкиToolStripMenuItem_Click);
            // 
            // студентиТаГрупиToolStripMenuItem
            // 
            this.студентиТаГрупиToolStripMenuItem.Name = "студентиТаГрупиToolStripMenuItem";
            this.студентиТаГрупиToolStripMenuItem.Size = new System.Drawing.Size(308, 28);
            this.студентиТаГрупиToolStripMenuItem.Text = "Працівники та їх комісії";
            this.студентиТаГрупиToolStripMenuItem.Click += new System.EventHandler(this.студентиТаГрупиToolStripMenuItem_Click);
            // 
            // управлінняToolStripMenuItem1
            // 
            this.управлінняToolStripMenuItem1.Name = "управлінняToolStripMenuItem1";
            this.управлінняToolStripMenuItem1.Size = new System.Drawing.Size(119, 27);
            this.управлінняToolStripMenuItem1.Text = "Управління";
            this.управлінняToolStripMenuItem1.Click += new System.EventHandler(this.управлінняToolStripMenuItem1_Click);
            // 
            // вихідToolStripMenuItem1
            // 
            this.вихідToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вихідЗАкаунтуToolStripMenuItem1,
            this.вихідЗЗастосункуToolStripMenuItem});
            this.вихідToolStripMenuItem1.Name = "вихідToolStripMenuItem1";
            this.вихідToolStripMenuItem1.Size = new System.Drawing.Size(71, 27);
            this.вихідToolStripMenuItem1.Text = "Вихід";
            // 
            // вихідЗАкаунтуToolStripMenuItem1
            // 
            this.вихідЗАкаунтуToolStripMenuItem1.Name = "вихідЗАкаунтуToolStripMenuItem1";
            this.вихідЗАкаунтуToolStripMenuItem1.Size = new System.Drawing.Size(248, 28);
            this.вихідЗАкаунтуToolStripMenuItem1.Text = "Вихід з акаунту";
            this.вихідЗАкаунтуToolStripMenuItem1.Click += new System.EventHandler(this.вихідЗАкаунтуToolStripMenuItem1_Click);
            // 
            // вихідЗЗастосункуToolStripMenuItem
            // 
            this.вихідЗЗастосункуToolStripMenuItem.Name = "вихідЗЗастосункуToolStripMenuItem";
            this.вихідЗЗастосункуToolStripMenuItem.Size = new System.Drawing.Size(248, 28);
            this.вихідЗЗастосункуToolStripMenuItem.Text = "Вихід з застосунку";
            this.вихідЗЗастосункуToolStripMenuItem.Click += new System.EventHandler(this.вихідЗЗастосункуToolStripMenuItem_Click);
            // 
            // tUserStatus
            // 
            this.tUserStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tUserStatus.BackColor = System.Drawing.Color.MistyRose;
            this.tUserStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tUserStatus.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tUserStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tUserStatus.Name = "tUserStatus";
            this.tUserStatus.ReadOnly = true;
            this.tUserStatus.Size = new System.Drawing.Size(150, 27);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 541);
            this.Controls.Add(this.menuStrip2);
            this.Name = "main";
            this.Text = "Головна форма";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem довідникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem групиїToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem дисципліниToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem викладачіToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem інформаціяпредставленняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиТаЇхОцінкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиТаГрупиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлінняToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вихідЗАкаунтуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вихідЗЗастосункуToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tUserStatus;
    }
}