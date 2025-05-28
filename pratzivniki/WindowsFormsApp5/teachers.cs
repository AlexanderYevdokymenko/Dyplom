using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class teachers : Form
    {
        private readonly DatabaseConnection db; // Предполагаем, что класс DatabaseConnection правильно управляет соединением
         private readonly checkUser _user;
        int selectedRow;
        public teachers(checkUser user)
        {
            InitializeComponent();
            db = new DatabaseConnection();
            _user = user;
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void IsAdmin()
        {
            textBox_id.Enabled=_user.IsAdmin;
            textBox_teachers.Enabled=_user.IsAdmin;
            управлінняToolStripMenuItem.Enabled = _user.IsAdmin;
            button3.Enabled = _user.IsAdmin;
            button1.Enabled = _user.IsAdmin;
            button2.Enabled = _user.IsAdmin;
            button4.Enabled = _user.IsAdmin;

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_teachers.Text = row.Cells[1].Value.ToString();



            }
        }

        private void головнеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main mainform = new main(_user);
            mainform.Show();

            this.Close();
        }

        private void teachers_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid();
            IsAdmin();
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }
        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            var connection = db.OpenConnection();

            string queryString = $"select * from Nachalniki";

            using (var command = new SqlCommand(queryString, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReadSingleRow(dataGridView1, reader);
                    }
                }
            }
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("NachId", "id");
            dataGridView1.Columns.Add("Name", "Начальник");


            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[2].Visible = false;
        }


        private void ClearFeilds()
        {
            textBox_id.Text = "";
            textBox_teachers.Text = "";


        }

        private void студентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students StudentForm = new students(_user);

            StudentForm.Show();
            this.Close();
        }

        private void групиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group GroupForm = new group(_user);

            GroupForm.Show();
            this.Close();
        }

        private void дисципліниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subjects SubjectsForm = new subjects(_user);

            SubjectsForm.Show();
            this.Close();
        }

        private void студентиТаЇхОцінкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsgrades StudentsGradesForm = new studentsgrades(_user);

            StudentsGradesForm.Show();
            this.Close();
        }

        private void студентиТаГрупиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsgroups StudentsGroupsForm = new studentsgroups(_user);

            StudentsGroupsForm.Show();
            this.Close();
        }

        private void управлінняToolStripMenuItem_Click(object sender, EventArgs e)
        {

            admin AdminForm = new admin(_user);
            AdminForm.Show();
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);

        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            var connection = db.OpenConnection();
            string searchString = $"select * from Nachalniki where   ( Name) like '%" + textBox3.Text + "%'";

            using (SqlCommand cmd = new SqlCommand(searchString, connection))
            {
                cmd.Parameters.AddWithValue("@searchPattern", $"%{textBox3.Text}%"); // Добавляем параметр безопасным способом

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        ReadSingleRow(dgw, read); // Чтение и добавление строки в DataGridView
                    }
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrEmpty(textBox_teachers.Text))
            {
                MessageBox.Show("Поле 'Name' не може бути пустим!");
                textBox_teachers.Focus();
                return;
            }

            // Формирование команды вставки с использованием блока using для управления ресурсами
            var connection = db.OpenConnection();// Предполагается, что db - экземпляр вашего класса DatabaseConnection
            {
                var cmd = new SqlCommand("INSERT INTO Nachalniki (Name) VALUES (@name)", connection);
                cmd.Parameters.AddWithValue("@name", textBox_teachers.Text);

                try
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Успішно!");
                        ClearFeilds();
                        RefreshDataGrid(); // Предполагается, что этот метод правильно обновляет данные на форме
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Помилка при додаванні викладача: " + ex.Message);
                }
            }
        }

       

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = textBox_id.Text;
            var teacher = textBox_teachers.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, teacher);
                dataGridView1.Rows[selectedRowIndex].Cells[2].Value = RowState.Modified;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно бажаєте відредагувати запит?", "Редагування!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Change();
            }
        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[2].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[2].Value = RowState.Deleted;

        }
        private void Update()
        {
            var connection = db.OpenConnection(); // Предполагается, что `db` это экземпляр класса DatabaseConnection
            {
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var rowState = (RowState)dataGridView1.Rows[index].Cells[2].Value;
                    if (rowState == RowState.Existed)
                        continue;

                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var name = dataGridView1.Rows[index].Cells[1].Value.ToString();

                    // Определение SQL запроса в зависимости от состояния строки
                    string sqlQuery;
                    if (rowState == RowState.Deleted)
                    {
                        sqlQuery = "DELETE FROM Nachalniki WHERE NachId = @id";
                    }
                    else if (rowState == RowState.Modified)
                    {
                        sqlQuery = "UPDATE Nachalniki SET Name = @name WHERE NachId = @id";
                    }
                    else
                    {
                        continue; // Если состояние не Deleted или Modified, переходим к следующей итерации
                    }

                    // Выполнение команды
                    using (var command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        if (rowState == RowState.Modified)
                        {
                            command.Parameters.AddWithValue("@name", name);
                        }
                        command.ExecuteNonQuery();
                    }
                }
            } // Блок using автоматически закроет соединение
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно бажаєте видалити запит?", "Видалення!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                deleteRow();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ClearFeilds();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно бажаєте зберегти нові дані?", "Збереження!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (textBox_id.Text.Length == 0)
                {
                    MessageBox.Show("Поле не може бути пустим!");
                    textBox_id.Focus();
                    return;
                }
                else if (textBox_teachers.Text.Length == 0)
                {
                    MessageBox.Show("Поле не може бути пустим!");
                    textBox_teachers.Focus();
                    return;
                }
                
                
                else
                    Update();
                ClearFeilds();

            }
        }
    }
}
