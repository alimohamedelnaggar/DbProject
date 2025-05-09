using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeDbProject
{
    public partial class CreateForm : Form
    {
        string connectionString = "Server=.;Database=HomeDbProject;Trusted_Connection=true;TrustServerCertificate=true;MultipleActiveResultSets=True";
        private readonly int? _id;
        public CreateForm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }
        public CreateForm(int? id)
        {
            InitializeComponent();
            _id = id;
            if (_id != null)
            {
                this.CreateEdit.Text = "Update User";
                LoadUserData();
            }
            else
            {
                this.CreateEdit.Text = "Create User";
            }
        }
        private void LoadUserData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Name, Email, Role FROM Users WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", _id);
                    con.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextUser.Text = reader["Name"].ToString();
                        textEmail.Text = reader["Email"].ToString();
                        comboRole.SelectedItem = reader["Role"].ToString();
                    }

                    con.Close();
                }
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query;
                SqlCommand cmd;

                if (_id == null)
                {
                    // إضافة عضو جديد
                    query = "INSERT INTO Users (Name, Email, Role) VALUES (@Name, @Email, @Role)";
                    cmd = new SqlCommand(query, con);
                }
                else
                {
                    // تعديل عضو موجود
                    query = "UPDATE Users SET Name = @Name, Email = @Email, Role = @Role WHERE Id = @Id";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", _id);
                }
                cmd.Parameters.AddWithValue("@Name", TextUser.Text);
                cmd.Parameters.AddWithValue("@Email", textEmail.Text);
                cmd.Parameters.AddWithValue("@Role", comboRole.SelectedItem.ToString());


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(_id == null ? "تمت الإضافة بنجاح" : "تم التعديل بنجاح");

                this.DialogResult = DialogResult.OK;
            }
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            comboRole.Items.Add("Admin");
            comboRole.Items.Add("User");
            comboRole.Items.Add("supervisor");
            comboRole.SelectedIndex = 0;
            comboRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
