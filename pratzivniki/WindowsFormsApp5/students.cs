using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
namespace WindowsFormsApp5
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class students : Form
    {
        private readonly DatabaseConnection db; // Предполагаем, что класс DatabaseConnection правильно управляет соединением
      
        private readonly checkUser _user;
        int selectedRow;

        public students(checkUser user)
        {
            InitializeComponent();
            db = new DatabaseConnection();
            _user = user;
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void головнеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main mainform = new main(_user);
            mainform.Show();

            this.Close();
        }
        private void IsAdmin()
        {
            управлінняToolStripMenuItem.Enabled = _user.IsAdmin;
            button3.Enabled = _user.IsAdmin;
            button3.Enabled = _user.IsAdmin;
            button1.Enabled = _user.IsAdmin;
            button2.Enabled = _user.IsAdmin;
            button4.Enabled = _user.IsAdmin;
            textBox_id.Enabled = _user.IsAdmin;
            textBox_number.Enabled = _user.IsAdmin; 
            textBox_pib.Enabled = _user.IsAdmin;
            

        }
        private void students_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid();
            IsAdmin();
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),           // WorkerID
                record.GetString(1),          // Name
                record.GetDateTime(2),        // DateOfBirth
                record.GetInt32(3),           // GroupId
                record.IsDBNull(4) ? string.Empty : record.GetString(4),  // Subject
                record.IsDBNull(5) ? string.Empty : record.GetString(5),  // SpecialistCategory
                record.IsDBNull(6) ? string.Empty : record.GetString(6),  // TeacherCategory
                RowState.ModifiedNew          // RowState
            );
        }


        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            var connection = db.OpenConnection();
            {
                string queryString = "SELECT * FROM Workers";
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
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("WorkerID", "id");
            dataGridView1.Columns.Add("Name", "ПІБ");
            dataGridView1.Columns.Add("DateOfBirth", "Дата народження");
            dataGridView1.Columns.Add("GroupId", "Номер підрозділу");
            dataGridView1.Columns.Add("Subject", "Предмет");                 // Додано колонку Subject
            dataGridView1.Columns.Add("SpecialistCategory", "Категорія спеціаліста"); // Додано колонку SpecialistCategory
            dataGridView1.Columns.Add("TeacherCategory", "Категорія вчителя");       // Додано колонку TeacherCategory

            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[7].Visible = false; // Приховування колонки IsNew
        }


        private void ClearFeilds()
        {
            textBox_id.Text = "";
            textBox_number.Text = "";
            textBox_pib.Text = "";

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                // Присваиваем значения из ячеек таблицы в текстовые поля
                textBox_id.Text = row.Cells["WorkerId"].Value != DBNull.Value ? row.Cells["WorkerId"].Value.ToString() : string.Empty;
                textBox_pib.Text = row.Cells["Name"].Value != DBNull.Value ? row.Cells["Name"].Value.ToString() : string.Empty;

                // Преобразуем значение в DateTime, если оно не null
                if (row.Cells["DateOfBirth"].Value != DBNull.Value)
                {
                    DateTime date;
                    if (DateTime.TryParse(row.Cells["DateOfBirth"].Value.ToString(), out date))
                    {
                        dateTimePicker1.Value = date;
                    }
                }

                textBox_number.Text = row.Cells["GroupId"].Value != DBNull.Value ? row.Cells["GroupId"].Value.ToString() : string.Empty;

                // Выводим значения для Subject, SpecialistCategory и TeacherCategory
                textBox_subject.Text = row.Cells["Subject"].Value != DBNull.Value ? row.Cells["Subject"].Value.ToString() : string.Empty;
                textBox_specialistCategory.Text = row.Cells["SpecialistCategory"].Value != DBNull.Value ? row.Cells["SpecialistCategory"].Value.ToString() : string.Empty;
                textBox_teacherCategory.Text = row.Cells["TeacherCategory"].Value != DBNull.Value ? row.Cells["TeacherCategory"].Value.ToString() : string.Empty;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ClearFeilds();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                var connection = db.OpenConnection();
                {
                    var cmd = new SqlCommand("INSERT INTO Workers (Name, DateOfBirth, GroupId, Subject, SpecialistCategory, TeacherCategory) " +
                                              "VALUES (@name, @dob, @groupId, @subject, @specialistCategory, @teacherCategory)", connection);
                    cmd.Parameters.AddWithValue("@name", textBox_pib.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@groupId", textBox_number.Text);
                    cmd.Parameters.AddWithValue("@subject", textBox_subject.Text); // Новий текстовий елемент для предмету
                    cmd.Parameters.AddWithValue("@specialistCategory", textBox_specialistCategory.Text); // Для категорії спеціаліста
                    cmd.Parameters.AddWithValue("@teacherCategory", textBox_teacherCategory.Text); // Для категорії вчителя

                    cmd.ExecuteNonQuery();
                }
                RefreshDataGrid();
                ClearFeilds();
                MessageBox.Show("Працівника успішно додано.");
            }
        }

        private bool ValidateInputs()
        {
            // Проверка входных данных перед выполнением операций с базой данных
            if (string.IsNullOrWhiteSpace(textBox_pib.Text) ||
                string.IsNullOrWhiteSpace(textBox_number.Text))
            {
                MessageBox.Show("Будь, ласка, заповність всі поля.");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно бажаєте відредагувати запит?", "Редагування!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Change();
            }
        }
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = textBox_id.Text;
            var pib = textBox_pib.Text;
            var dateofbirth = dateTimePicker1.Value;
            var group_id = textBox_number.Text;
            var subject = textBox_subject.Text; // Додано поле для предмета
            var specialistCategory = textBox_specialistCategory.Text; // Додано поле для категорії спеціаліста
            var teacherCategory = textBox_teacherCategory.Text; // Додано поле для категорії вчителя

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, pib, dateofbirth, group_id, subject, specialistCategory, teacherCategory);
                dataGridView1.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified; // Оновлено індекс для останньої колонки (IsNew)
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно бажаєте видалити запит?", "Видалення!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                deleteRow();
            }
        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;

        }
        private void Update()
        {
            var connection = db.OpenConnection(); // Открытие соединения
            {
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;
                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                        using (var command = new SqlCommand("DELETE FROM Workers WHERE WorkerId = @id", connection))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();
                        }
                    }

                    if (rowState == RowState.Modified)
                    {
                        var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var dateOfBirth = Convert.ToDateTime(dataGridView1.Rows[index].Cells[2].Value);
                        var number = dataGridView1.Rows[index].Cells[3].Value.ToString();
                        var subject = dataGridView1.Rows[index].Cells[4].Value.ToString();
                        var specialistCategory = dataGridView1.Rows[index].Cells[5].Value.ToString();
                        var teacherCategory = dataGridView1.Rows[index].Cells[6].Value.ToString();

                        var changeQuery = @"
                    UPDATE Workers 
                    SET 
                        Name = @name, 
                        DateOfBirth = @dateOfBirth, 
                        GroupId = @number, 
                        Subject = @subject,
                        SpecialistCategory = @specialistCategory, 
                        TeacherCategory = @teacherCategory
                    WHERE WorkerId = @id";

                        using (var command = new SqlCommand(changeQuery, connection))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                            command.Parameters.AddWithValue("@number", number);
                            command.Parameters.AddWithValue("@subject", subject);
                            command.Parameters.AddWithValue("@specialistCategory", specialistCategory);
                            command.Parameters.AddWithValue("@teacherCategory", teacherCategory);
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Обработка добавленных записей (если предполагается)
                    if (rowState == RowState.New)
                    {
                        var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        var dateOfBirth = Convert.ToDateTime(dataGridView1.Rows[index].Cells[2].Value);
                        var number = dataGridView1.Rows[index].Cells[3].Value.ToString();
                        var subject = dataGridView1.Rows[index].Cells[5].Value.ToString();
                        var specialistCategory = dataGridView1.Rows[index].Cells[6].Value.ToString();
                        var teacherCategory = dataGridView1.Rows[index].Cells[7].Value.ToString();

                        var insertQuery = @"
                    INSERT INTO Workers (Name, DateOfBirth, GroupId, Subject, SpecialistCategory, TeacherCategory)
                    VALUES (@name, @dateOfBirth, @number, @subject, @specialistCategory, @teacherCategory)";

                        using (var command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                            command.Parameters.AddWithValue("@number", number);
                            command.Parameters.AddWithValue("@subject", subject);
                            command.Parameters.AddWithValue("@specialistCategory", specialistCategory);
                            command.Parameters.AddWithValue("@teacherCategory", teacherCategory);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            } // Автоматическое закрытие соединения после выхода из блока using
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
                else if (textBox_pib.Text.Length == 0)
                {
                    MessageBox.Show("Поле не може бути пустим!");
                    textBox_pib.Focus();
                    return;
                }
                else if (textBox_number.Text.Length == 0)
                {
                    MessageBox.Show("Поле не може бути пустим!");
                    textBox_number.Focus();
                    return;
                }
                else
                    Update();
                ClearFeilds();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);

        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            var connection = db.OpenConnection(); // Предполагаем, что db это экземпляр класса DatabaseConnection
            {
                string searchString = "SELECT * FROM Workers WHERE Name LIKE @searchPattern";
                using (var cmd = new SqlCommand(searchString, connection))
                {
                    cmd.Parameters.AddWithValue("@searchPattern", $"%{textBox1.Text}%");

                    using (var read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            ReadSingleRow(dgw, read);
                        }
                    }
                }
            } 
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

        private void групиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group GroupForm = new group(_user);

            GroupForm.Show();
            this.Close();
        }

        private void студентиТаЇхОцінкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsgrades StudentsGradesForm = new studentsgrades(_user);

            StudentsGradesForm.Show();
            this.Close();
        }

        private void дисципліниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subjects SubjectsForm = new subjects(_user);

            SubjectsForm.Show();
            this.Close();
        }

        private void викладачіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teachers TeachersForm = new teachers(_user);

            TeachersForm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

