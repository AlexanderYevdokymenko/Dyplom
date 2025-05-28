namespace WindowsFormsApp5
{
    partial class students
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_subject = new System.Windows.Forms.TextBox();
            this.textBox_teacherCategory = new System.Windows.Forms.TextBox();
            this.textBox_specialistCategory = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_pib = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Moccasin;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(71, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Пошук за ПІБ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 22);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(299, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Очистити все";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(339, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 42);
            this.button5.TabIndex = 19;
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
            this.dataGridView1.Location = new System.Drawing.Point(569, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(630, 284);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(1266, 28);
            this.menuStrip1.TabIndex = 17;
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
            this.викладачіToolStripMenuItem.Text = "Факультети";
            this.викладачіToolStripMenuItem.Click += new System.EventHandler(this.викладачіToolStripMenuItem_Click);
            // 
            // дисципліниToolStripMenuItem
            // 
            this.дисципліниToolStripMenuItem.Name = "дисципліниToolStripMenuItem";
            this.дисципліниToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.дисципліниToolStripMenuItem.Text = "Начальники";
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
            this.студентиТаЇхОцінкиToolStripMenuItem.Click += new System.EventHandler(this.студентиТаЇхОцінкиToolStripMenuItem_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(305, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 230);
            this.groupBox2.TabIndex = 16;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_subject);
            this.groupBox1.Controls.Add(this.textBox_teacherCategory);
            this.groupBox1.Controls.Add(this.textBox_specialistCategory);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_number);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.textBox_pib);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 311);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вибрані дані";
            // 
            // textBox_subject
            // 
            this.textBox_subject.Location = new System.Drawing.Point(86, 185);
            this.textBox_subject.Name = "textBox_subject";
            this.textBox_subject.Size = new System.Drawing.Size(131, 22);
            this.textBox_subject.TabIndex = 36;
            // 
            // textBox_teacherCategory
            // 
            this.textBox_teacherCategory.Location = new System.Drawing.Point(18, 268);
            this.textBox_teacherCategory.Name = "textBox_teacherCategory";
            this.textBox_teacherCategory.Size = new System.Drawing.Size(145, 22);
            this.textBox_teacherCategory.TabIndex = 35;
            // 
            // textBox_specialistCategory
            // 
            this.textBox_specialistCategory.Location = new System.Drawing.Point(18, 229);
            this.textBox_specialistCategory.Name = "textBox_specialistCategory";
            this.textBox_specialistCategory.Size = new System.Drawing.Size(145, 22);
            this.textBox_specialistCategory.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Категорія викладача";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Категорія спеціаліста";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Предмет";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "ДН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Комісія №";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "ПІБ";
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(100, 153);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(100, 22);
            this.textBox_number.TabIndex = 27;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(85, 29);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(100, 22);
            this.textBox_id.TabIndex = 23;
            // 
            // textBox_pib
            // 
            this.textBox_pib.Location = new System.Drawing.Point(85, 76);
            this.textBox_pib.Name = "textBox_pib";
            this.textBox_pib.Size = new System.Drawing.Size(100, 22);
            this.textBox_pib.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID";
            // 
            // students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 558);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "students";
            this.Text = "Працівники";
            this.Load += new System.EventHandler(this.students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem головнеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem інформаціяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлінняToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_pib;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem студентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem групиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem викладачіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дисципліниToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиТаЇхОцінкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиТаГрупиToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.TextBox textBox_subject;
        private System.Windows.Forms.TextBox textBox_teacherCategory;
        private System.Windows.Forms.TextBox textBox_specialistCategory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}