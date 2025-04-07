using System;
using System.Configuration;
using MySql.Data.MySqlClient;

public partial class StudentForm : System.Web.UI.Page
{
    protected void btnSave_Click(object sender, EventArgs e)
    {
        // Connection string from Web.config
        string connString = ConfigurationManager.ConnectionStrings["MySQLConnString"].ConnectionString;

        // SQL Insert Query
        string query = "INSERT INTO students (Name, Age, Course) VALUES (@Name, @Age, @Course)";

        using (MySqlConnection conn = new MySqlConnection(connString))
        {
            try
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@Course", txtCourse.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        lblMessage.Text = "Student details saved successfully!";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text =
