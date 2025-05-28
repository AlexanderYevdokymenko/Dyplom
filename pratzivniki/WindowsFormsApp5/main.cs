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
    public partial class main : Form
    {
        private readonly checkUser _user;
        public main(checkUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            _user = user;
        }

        private void студентиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            students student = new students(_user);
          
            student.Show();
            this.Close();

         
        }
        private void IsAdmin()
        {
            управлінняToolStripMenuItem1.Enabled = _user.IsAdmin;
        
        }

        private void main_Load(object sender, EventArgs e)
        {
            tUserStatus.Text = $"{_user.Login}:{_user.Status}";
            IsAdmin();
        }

        private void управлінняToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            admin Adminform = new admin(_user);
            Adminform.Show();

            this.Close();
        }

        private void групиїToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void студентиТаЇхОцінкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentsgrades StudentsGradesForm = new studentsgrades(_user);

            StudentsGradesForm.Show();
            this.Close();
        }

        private void викладачіToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            teachers TeachersForm = new teachers(_user);

            TeachersForm.Show();
            this.Close();
        }

        private void вихідЗАкаунтуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            login Authriz = new login();
            Authriz.Show();
            this.Hide();
        }

        private void вихідЗЗастосункуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void дисципліниToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            subjects SubjectForm = new subjects(_user);

            SubjectForm.Show();
            this.Close();
        }
    }
}
