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
using System.Data.Common;
namespace WindowsFormsApp5
{
    public partial class group : Form
    {
        public DatabaseConnection db = new DatabaseConnection();

        private readonly checkUser _user;
        int selectedRow;
        public group(checkUser user)
        {
            InitializeComponent();
            _user = user;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void головнеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main mainform = new main(_user);
            mainform.Show();

            this.Close();
        }

        private void group_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid();
            IsAdmin();
        }
        private void IsAdmin()
        {
            управлінняToolStripMenuItem.Enabled = _user.IsAdmin;
            button3.Enabled = _user.IsAdmin;
            button1.Enabled= _user.IsAdmin;
            button2.Enabled= _user.IsAdmin;
            button4.Enabled= _user.IsAdmin;
            textBox_id.Enabled= _user.IsAdmin;
            textBox_group.Enabled= _user.IsAdmin;

        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }
        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            var connection = db.OpenConnection();  // Открываем соединение
            try
            {
                string query = "SELECT * FROM Groups";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);  // Получение ID группы
                            string name = reader.IsDBNull(1) ? "" : reader.GetString(1);  // Получение названия группы
                            dataGridView1.Rows.Add(id, name, "Existed");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при загрузке данных: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();  // Всегда закрываем соединение
            }
        }



        private void CreateColumns()
        {
            dataGridView1.Columns.Add("GroupId", "id");
            dataGridView1.Columns.Add("Name", "Підрозділ");
          

            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[2].Visible = false;
        }


        private void ClearFeilds()
        {
            textBox_id.Text = "";
            textBox_group.Text = "";
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_group.Text = row.Cells[1].Value.ToString();
               


            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ClearFeilds();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_id.Text) || string.IsNullOrEmpty(textBox_group.Text))
            {
                MessageBox.Show("Поле не может быть пустым!");
                return;
            }

            var connection = db.OpenConnection();  // Получаем открытое соединение
            try
            {
                var cmd = new SqlCommand("INSERT INTO Groups (GroupId, Name) VALUES (@group_id, @name)", connection);
                cmd.Parameters.AddWithValue("@group_id", textBox_id.Text);
                cmd.Parameters.AddWithValue("@name", textBox_group.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Успешно!");
                    RefreshDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні даних: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();  // Закрываем соединение
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно бажаєте відредагувати запис?", "Редагування!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Change();
            }
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = textBox_id.Text;
            var groupName = textBox_group.Text;

            if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(groupName))
            {
                try
                {
                    var connection = db.OpenConnection();  // Відкриваємо з'єднання
                    {
                        var command = new SqlCommand("UPDATE Groups SET Name = @name WHERE GroupId = @id", connection);
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@name", groupName);
                        command.ExecuteNonQuery();
                    }
                    RefreshDataGrid();
                    MessageBox.Show("Запис успішно оновлено.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Виникла помилка при оновленні даних: {ex.Message}");
                }
                finally
                {
                    db.CloseConnection();  // Закриваємо з'єднання
                }
            }
            else
            {
                MessageBox.Show("Ідентифікатор та назва групи не можуть бути порожніми.");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно бажаєте видалити запис?", "Видалення!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                deleteRow();
            }
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[index].Cells[0].Value != null)
            {
                string id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                var connection = db.OpenConnection();
                {
                    var command = new SqlCommand("DELETE FROM Groups WHERE GroupId = @id", connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                RefreshDataGrid();
                MessageBox.Show("Запис успішно видалено.");
            }
        }

        private void Update()
        {
            var connection = db.getConnection();
            {
                // Перегляд кожного рядка в таблиці
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue; // Пропускаємо рядок для введення нової записи

                    var rowState = row.Cells["IsNew"].Value;
                    if (rowState == null) continue; // Якщо стан не визначено, пропускаємо

                    var id = row.Cells["GroupId"].Value.ToString();
                    var name = row.Cells["Name"].Value.ToString();

                    if (rowState.ToString() == "Modified") // Якщо рядок було змінено
                    {
                        var cmd = new SqlCommand("UPDATE Groups SET Name = @name WHERE GroupId = @id", connection);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.ExecuteNonQuery();
                    }
                    else if (rowState.ToString() == "Deleted") // Якщо рядок помічено на видалення
                    {
                        var cmd = new SqlCommand("DELETE FROM Groups WHERE GroupId = @id", connection);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    else if (rowState.ToString() == "Added") // Якщо додано новий рядок
                    {
                        var cmd = new SqlCommand("INSERT INTO Groups (GroupId, Name) VALUES (@id, @name)", connection);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.ExecuteNonQuery();
                    }

                    // Скидання стану після обробки
                    row.Cells["IsNew"].Value = "Existed";
                }
            }
             RefreshDataGrid(); // Оновлюємо таблицю для відображення актуальних даних з БД
            MessageBox.Show("Зміни збережено"); // Повідомлення користувачу про успішне збереження змін
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
                else if (textBox_group.Text.Length == 0)
                {
                    MessageBox.Show("Поле не може бути пустим!");
                    textBox_group.Focus();
                    return;
                }
               
                else
                    Update();
                ClearFeilds();

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear(); // Очищення даних
            try
            {
                var connection = db.OpenConnection();// Відкриття з'єднання
                {
                    // Формування запиту з урахуванням введених даних
                    string searchString = $"SELECT * FROM Groups WHERE Name LIKE '%{textBox3.Text}%'";
                    using (SqlCommand command = new SqlCommand(searchString, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);  // Отримання ID групи
                                string name = reader.IsDBNull(1) ? "" : reader.GetString(1);  // Отримання назви групи
                                dataGridView1.Rows.Add(id, name, "Existed");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка під час пошуку даних: {ex.Message}");
            }
            finally
            {
                db.CloseConnection(); // Закриття з'єднання
            }
        }



        private void студентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students student = new students(_user);

            student.Show();
            this.Close();
        }

        private void управлінняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin Adminform = new admin(_user);
            Adminform.Show();

            this.Close();
        }

        private void студентиТаГрупиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsgroups studentsgroupsForm = new studentsgroups(_user);
            studentsgroupsForm.Show();

            this.Close();
        }

        private void студентиТаЇхОцінкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsgrades StudentsGradesForm = new studentsgrades(_user);

            StudentsGradesForm.Show();
            this.Close();
        }

        private void викладачіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teachers TeachersForm = new teachers(_user);

            TeachersForm.Show();
            this.Close();
        }

        private void дисципліниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subjects SubjectsForm = new subjects(_user);

            SubjectsForm.Show();
            this.Close();
        }

        private void групиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group GroupForm = new group(_user);

            GroupForm.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
