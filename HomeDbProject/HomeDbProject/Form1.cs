using System.Data;
using System.Data.SqlClient;

namespace HomeDbProject
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=.;Database=HomeDbProject;Trusted_Connection=true;TrustServerCertificate=true;MultipleActiveResultSets=True";
        public Form1()
        {
            InitializeComponent();
        }
        private int GetSelectedUserId()
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["Id"].Value != null)
            {
                return Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            }
            else
            {
                MessageBox.Show("من فضلك اختر عضوًا من الجدول.");
                return -1;
            }
        }
        private void Create_Click(object sender, EventArgs e)
        {
            CreateForm form = new CreateForm();
            form.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadUsers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name, Email, Role FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void LoadData_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            int selectedUserId = GetSelectedUserId();
            CreateForm form = new CreateForm(selectedUserId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("User updated successfully.");
                LoadUsers();
            }
        }
        private void DeleteUser(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Users WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            MessageBox.Show("تم الحذف بنجاح");
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            int userId = GetSelectedUserId();
            if (userId == -1) return;

            var confirm = MessageBox.Show("هل أنت متأكد أنك تريد حذف هذا العضو؟", "تأكيد الحذف", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                DeleteUser(userId);
                LoadUsers(); // إعادة تحميل البيانات بعد الحذف
            }
        }
    }
}
