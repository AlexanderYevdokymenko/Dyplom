using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class studentsgrades : Form
    {
        private readonly checkUser _user;
        private readonly DatabaseConnection db = new DatabaseConnection();

        public studentsgrades(checkUser user)
        {
            InitializeComponent();
            _user = user;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void studentsgrades_Load(object sender, EventArgs e)
        {
            IsAdmin();
            CreateColumns();
            RefreshDataGrid();
        }

        private void IsAdmin()
        {
            управлінняToolStripMenuItem.Enabled = _user.IsAdmin;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("RejtingID", "ID рейтингу");
            dataGridView1.Columns.Add("Rating", "Рейтинг");
            dataGridView1.Columns.Add("WorkerId", "ID працівники");
            dataGridView1.Columns.Add("WorkerName", "ПІБ працівника");
            dataGridView1.Columns.Add("DepartmentName", "Назва відділу");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[5].Visible = false;
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            using (var connection = db.OpenConnection())
            {
                string queryString = "SELECT * FROM Grades_Students";
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int gradeId = reader.GetInt32(0);
                            decimal grade = reader.GetDecimal(1);
                            int studentId = reader.GetInt32(2);
                            string studentName = reader.GetString(3);
                            string subjectName = reader.GetString(4);
                            dataGridView1.Rows.Add(gradeId, grade, studentId, studentName, subjectName, "Existed");
                        }
                    }
                }
            }
        }

        private void головнеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main mainform = new main(_user);
            mainform.Show();
            this.Close();
        }

        private void студентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students studentForm = new students(_user);
            studentForm.Show();
            this.Close();
        }

        private void групиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group groupForm = new group(_user);
            groupForm.Show();
            this.Close();
        }

        private void дисципліниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subjects SubjectsForm = new subjects(_user);
            SubjectsForm.Show();
            this.Close();
        }

        private void студентиТаГрупиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsgroups StudentsGroupsForm = new studentsgroups(_user);
            StudentsGroupsForm.Show();
            this.Close();
        }

        private void викладачіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teachers TeachersForm = new teachers(_user);
            TeachersForm.Show();
            this.Close();
        }

        private void студентиТаЇхОцінкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsgrades StudentsGradesForm = new studentsgrades(_user);
            StudentsGradesForm.Show();
            this.Close();
        }

        private void управлінняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin AdminForm = new admin(_user);
            AdminForm.Show();
            this.Close();
        }
    }
}
