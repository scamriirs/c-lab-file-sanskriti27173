using System;
using System.Data;
using System.Data.SqlClient;

namespace YourNamespace
{
    public partial class StudentGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            // Connection string to your database
            string connectionString = "Data Source=.;Initial Catalog=UniversityManager;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Roll, Name, Marks FROM Student";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();

                adapter.Fill(dataSet);

                // Bind the dataset to the GridView
                GridView1.DataSource = dataSet.Tables[0];
                GridView1.DataBind();
            }
        }
    }
}
