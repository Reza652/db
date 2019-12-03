using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;



namespace DBproject
{
    public partial class signUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            // this string should change based on the machine that is running the code
            //open server explorer
            //right click on connection string and click on propertice 
            // copy the connection string and paste to string below
            string fname = fn.Text;
            string lname = ln.Text;
            string bd = dob.Text;
            string z = zip.Text;
            string Email = mail.Text;
            string pas = pass.Text;

            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RezaA\Source\Repos\DB-project\DB-project\App_Data\Database1.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(cs);

            string query = "INSERT INTO customer(FirstName, LastName, DOB, Zipcode, Email,Pass) " +
               "Values('" + fname + "', '" + lname + "', '" + bd + "', '" + z + "', '" + Email + "', '" + pas + "')";

            using (SqlConnection connection = new SqlConnection(cs))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        } 

      /*  protected void Button1_Click1(object sender, EventArgs e)
        {
            // this string should change based on the machine that is running the code
            //open server explorer
            //right click on connection string and click on propertice 
            // copy the connection string and paste to string below

            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RezaA\Source\Repos\DB-project\DB-project\App_Data\Database1.mdf;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(cs);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into user values(@FirstName,@LastName,@DOB,@ZipCode,@Email,@Pass)", cnn);
            cmd.Parameters.AddWithValue("FirstName", fn.Text);
            cmd.Parameters.AddWithValue("LasttName", ln.Text);
            cmd.Parameters.AddWithValue("DOB", dob.Text);
            cmd.Parameters.AddWithValue("ZIP", zip.Text);
            cmd.Parameters.AddWithValue("Email", mail.Text);
            cmd.Parameters.AddWithValue("Pass", pass.Text);
            cmd.ExecuteNonQuery();

            fn.Text = "";
            ln.Text = "";
            dob.Text = "";
            zip.Text = "";
            mail.Text = "";
            pass.Text = "";

            //cnn.Close();

            Response.Redirect("signIn.aspx"); 
        } */
    }
}