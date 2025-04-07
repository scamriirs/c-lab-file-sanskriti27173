using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=YourDatabaseName;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            // Example: Load data for a specific Registration Number
            int regNo = int.Parse(txtRegNo.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Students WHERE RegistrationNumber = @RegNo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@RegNo", regNo);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtName.Text = reader["Name"].ToString();
                        txtAge.Text = reader["Age"].ToString();
                        txtClass.Text = reader["Class"].ToString();
                        txtAddress.Text = reader["Address"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No record found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
