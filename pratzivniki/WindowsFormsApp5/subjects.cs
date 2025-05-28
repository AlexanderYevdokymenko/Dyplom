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

namespace WindowsFormsApp5
{
    public partial class subjects : Form
    {
        private readonly DatabaseConnection db = new DatabaseConnection();
        private readonly checkUser _user;
        int selectedRow;
        public subjects(checkUser user)
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
        private void IsAdmin()
        {
            управлінняToolStripMenuItem.Enabled = _user.IsAdmin;
            button3.Enabled = _user.IsAdmin;
            textBox_id.Enabled = _user.IsAdmin;
            textBox_subject.Enabled = _user.IsAdmin;
            
            button1.Enabled = _user.IsAdmin;
            button2.Enabled = _user.IsAdmin;
            button4.Enabled = _user.IsAdmin;

        }

        private void subjects_Load(object sender, EventArgs e)
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
            var connection = db.OpenConnection();  // Открываем соединение
            {
                try
                {
                    string queryString = "SELECT * FROM Department";
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1), "Existed");
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
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("DepartmentId", "id");
            dataGridView1.Columns.Add("Name", "Відділ");


            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns[2].Visible = false;
        }


        private void ClearFeilds()
        {
            textBox_id.Text = "";
            textBox_subject.Text = "";


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
            var connection = db.OpenConnection();
            {
                var cmd = new SqlCommand("INSERT INTO Department (DepartmentId, Name) VALUES (@subject_id, @name)", connection);
                

                cmd.Parameters.AddWithValue("@subject_id", textBox_id.Text);
                cmd.Parameters.AddWithValue("@name", textBox_subject.Text);



                if (textBox_id.Text.Length == 0)
                {
                    MessageBox.Show("Поле не може бути пустим!");
                    textBox_id.Focus();
                    return;
                }


                else if (textBox_subject.Text.Length == 0)
                {
                    MessageBox.Show("Поле не може бути пустим!");
                    textBox_subject.Focus();
                }


                else
                    try
                    {
                        connection.Open();

                        if (cmd.ExecuteNonQuery() > 0)
                        {

                            MessageBox.Show("Успішно!");
                            ClearFeilds();
                            RefreshDataGrid();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
            }
        }

        private void групиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            group GroupForm = new group(_user);
            GroupForm.Show();

            this.Close();
        }

        private void студентиТаГрупиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsgroups studentsgroupsForm = new studentsgroups(_user);
            studentsgroupsForm.Show();

            this.Close();
        }

        private void студентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students student = new students(_user);

            student.Show();
            this.Close();
        }

        private void дисципліниToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void викладачіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teachers TeachersForm = new teachers(_user);

            TeachersForm.Show();
            this.Close();
        }

        private void управлінняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin AdminForm = new admin (_user);
            AdminForm.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_subject.Text = row.Cells[1].Value.ToString();



            }
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            var connection = db.OpenConnection();
            {
                string searchString = "SELECT * FROM Department WHERE Name LIKE @searchPattern";
                using (SqlCommand cmd = new SqlCommand(searchString, connection))
                {
                    cmd.Parameters.AddWithValue("@searchPattern", "%" + textBox3.Text + "%");
                    using (SqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            ReadSingleRow(dgw, read);
                        }
                    }
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);

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
            var subject = textBox_subject.Text;
     
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].SetValues(id, subject);
                dataGridView1.Rows[selectedRowIndex].Cells[2].Value = RowState.Modified;
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
                dataGridView1.Rows[index].Cells[2].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[2].Value = RowState.Deleted;

        }
        private void Update()
        {
            var connection = db.OpenConnection();
            {
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    var rowState = (RowState)dataGridView1.Rows[index].Cells[2].Value;
                    if (rowState == RowState.Existed)
                        continue;

                    if (rowState == RowState.Deleted)
                    {
                        var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                        string deleteQuery = "DELETE FROM Department WHERE DepartmentId = @id";

                        using (var command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();
                        }
                    }

                    if (rowState == RowState.Modified)
                    {
                        var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                        var name = dataGridView1.Rows[index].Cells[1].Value.ToString();
                        string updateQuery = "UPDATE Department SET Name = @name WHERE DepartmentId = @id";

                        using (var command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
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
                else if (textBox_subject.Text.Length == 0)
                {
                    MessageBox.Show("Поле не може бути пустим!");
                    textBox_subject.Focus();
                    return;
                }
                
                else
                    Update();
                ClearFeilds();

            }
        }
    }
}
