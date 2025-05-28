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
    public partial class admin : Form
    {
        private SqlConnection connection;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alyona\Desktop\student\WindowsFormsApp5\Database1.mdf;Integrated Security=True";
        private readonly checkUser _user;
        public admin(checkUser user)
        {
            _user = user;
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            connection = new SqlConnection(connectionString);

        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_user", "ID");
            dataGridView1.Columns.Add("login_user", "Логін");
            dataGridView1.Columns.Add("password_user", "Пароль");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = "IsAdmin";
            dataGridView1.Columns.Add(checkColumn);
        }
        private void ReadSingleRow(IDataRecord record)
        {
            dataGridView1.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetBoolean(3));
        }
        private void головнеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main mainform = new main(_user);
            mainform.Show();

            this.Close();
        }
        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            string queryString = $"select * from register";
            SqlCommand command = new SqlCommand(queryString, connection);
          
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(reader);
            }
            reader.Close();
            connection.Close();
        }
        private void admin_Load(object sender, EventArgs e)
        {
           // IsAdmin();
            CreateColumns();
            RefreshDataGrid();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            connection.Open();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                var isadmin = dataGridView1.Rows[index].Cells[3].Value.ToString();
                var changeQuery = $"UPDATE register set is_admin = '{isadmin}' where id_user='{id}'";
                var command = new SqlCommand(changeQuery, connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
            RefreshDataGrid();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
            var deleteQuery = $"Delete from register where id_user = '{id}'";
            var command = new SqlCommand(deleteQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
            RefreshDataGrid();

        }

        private void студентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students studentForm = new students(_user);
            studentForm.Show();

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

        private void дисципліниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            subjects SubjectsForm = new subjects(_user);
            SubjectsForm.Show();

            this.Close();

        }
    }
}
