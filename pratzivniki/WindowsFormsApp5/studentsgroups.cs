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

namespace WindowsFormsApp5
{
    public partial class studentsgroups : Form
    {
        private readonly checkUser _user;
        private readonly DatabaseConnection db = new DatabaseConnection();
        int selectedRow;

        public studentsgroups(checkUser user)
        {
            InitializeComponent();
            _user = user;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void studentsgroups_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid();
            IsAdmin();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("WorkerId", "ID працівника");
            dataGridView1.Columns.Add("StudentName", "ПІБ");
            dataGridView1.Columns.Add("DateOfBirth", "День народження");
            dataGridView1.Columns.Add("GroupId", "№ групи");
            dataGridView1.Columns.Add("GroupName", "Назва підрозділу");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[5].Visible = false;
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            using (var connection = db.OpenConnection())
            {
                string queryString = "SELECT * FROM Students_Groups";
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReadSingleRow(dataGridView1, reader);
                        }
                    }
                }
            }
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0),     // StudentId
                record.GetString(1),    // StudentName
                record.GetDateTime(2),  // DateOfBirth
                record.GetInt32(3),     // GroupId
                record.GetString(4),    // GroupName
                RowState.ModifiedNew
            );
        }

        private void IsAdmin()
        {
            управлінняToolStripMenuItem.Enabled = _user.IsAdmin;
        }

        // Event handlers
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

        private void управлінняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin adminForm = new admin(_user);
            adminForm.Show();
            this.Close();
        }

        private void студентиТаЇхОцінкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsgrades gradesForm = new studentsgrades(_user);
            gradesForm.Show();
            this.Close();
        }

        private void викладачіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teachers teachersForm = new teachers(_user);
            teachersForm.Show();
            this.Close();
        }
    }
}
