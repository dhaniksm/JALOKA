using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JALOKA
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;
            Database db = new Database();

            List<User> listDataAdmin = db.GetDataAdmin();

            foreach (var admin in listDataAdmin)
            {
                try
                {
                    if (username == admin.username && password == admin.password)
                    {
                        MessageBox.Show("Login Berhasil", $"Welcome to the Eternity, {admin.username}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Form2 form2 = new Form2(username);
                        //this.Hide();
                        //form2.Show();
                        //return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            //if (textUsername.Text == "admin" && textPassword.Text == "123")
            //{
            //    MessageBox.Show("Kon Iso Login", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    Form2 form2 = new Form2(textUsername.Text);

            //    this.Hide();
            //    form2.Show();
            //}

            //else
            //{
            //    MessageBox.Show("Kon Gagal Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}

class User
{
    public string username { get; set; }
    public string password { get; set; }
}

public class Database
{
    NpgsqlConnection conn;
    public Database()
    {
        string connStr = "Host=localhost;Username=postgres;Password=@Emcc13;Database=JALOKA";
        conn = new NpgsqlConnection(connStr);
        conn.Open();
    }

    internal List<User> GetDataAdmin()
    {
        List<User> listUser = new List<User>();
        string query = "select * from users";
        using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
        {
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    User user = new User
                    {
                        username = (string)reader["username"],
                        password = (string)reader["password"]
                    };
                    listUser.Add(user);
                }
                return listUser;
            }
        }
    }
}

class User
{
    public string username { get; set; }
    public string password { get; set; }
}