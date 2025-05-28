using System;
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
    public partial class login : Form
    {
        private DatabaseConnection dbConnection;

        public login()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user, is_admin from register " +
                $"where login_user= @{nameof(loginUser)} " +
                $"and password_user=@{nameof(passUser)}";

            using (SqlCommand command = new SqlCommand(querystring, dbConnection.getConnection()))
            {
                command.Parameters.AddWithValue($"@{nameof(loginUser)}", loginUser);
                command.Parameters.AddWithValue($"@{nameof(passUser)}", passUser);
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }

            

            if (table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));
                MessageBox.Show("Ви успішно увійшли!", "Успішно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                main mainform = new main(user);
                mainform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Помилка при введенні логіна чи пароля!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '*';
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }
    }
}
