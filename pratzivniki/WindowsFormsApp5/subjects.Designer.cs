namespace WindowsFormsApp5
{
    partial class subjects
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_subject = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_subject);
            this.groupBox1.Location = new System.Drawing.Point(4, 339);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 230);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вибрані дані";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(96, 29);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Факультет";
            // 
            // textBox_subject
            // 
            this.textBox_subject.Location = new System.Drawing.Point(96, 73);
            this.textBox_subject.Name = "textBox_subject";
            this.textBox_subject.Size = new System.Drawing.Size(100, 22);
            this.textBox_subject.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Moccasin;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(48, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 25);
            this.label7.TabIndex = 46;
            this.label7.Text = "Пошук за факультетом";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(57, 193);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(214, 45);
            this.textBox3.TabIndex = 45;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(276, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 31);
            this.label8.TabIndex = 44;
            this.label8.Text = "Очистити все";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(328, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 42);
            this.button5.TabIndex = 43;
            this.button5.Text = "Оновити";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(529, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(541, 267);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(1141, 28);
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
            this.студентиТаЇхОцінкиToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.студентиТаЇхОцінкиToolStripMenuItem.Text = "Працівники та їх рейтинг";
            // 
            // студентиТаГрупиToolStripMenuItem
            // 
            this.студентиТаГрупиToolStripMenuItem.Name = "студентиТаГрупиToolStripMenuItem";
            this.студентиТаГрупиToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.студентиТаГрупиToolStripMenuItem.Text = "Працівники та їх підрозділи";
            this.студентиТаГрупиToolStripMenuItem.Click += new System.EventHandler(this.студентиТаГрупиToolStripMenuItem_Click);
            // 
            // управлінняToolStripMenuItem
            // 
            this.управлінняToolStripMenuItem.Name = "управлінняToolStripMenuItem";
            this.управлінняToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.управлінняToolStripMenuItem.Text = "Управління";
            this.управлінняToolStripMenuItem.Click += new System.EventHandler(this.управлінняToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(282, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 230);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Керування даними";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(34, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Зберегти";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Видалити";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Відредагувати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Додати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Name = "subjects";
            this.Text = "Факультети";
            this.Load += new System.EventHandler(this.subjects_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_subject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}