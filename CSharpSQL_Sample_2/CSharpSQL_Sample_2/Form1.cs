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

namespace CSharpSQL_Sample_2
{
    public partial class Form1 : Form
    {
        // LOCAL DB Connection String https://www.connectionstrings.com/sql-server/
        SqlConnection cs = new SqlConnection("Server=WINDOWS10\\SQLEXPRESS;Initial Catalog=Deneme;Integrated Security=true;");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();

            //Buttons Visibility
            editBtn.Visible = false;
            deleteBtn.Visible = false;
        }
        private void signupBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userNameTbox.Text) || string.IsNullOrWhiteSpace(passwordTbox.Text))
            {
                MessageBox.Show("Cannot be empty!");
            }
            else
            {
                cs.Open();
                cmd = new SqlCommand("SELECT * FROM Person WHERE UserName = '" + userNameTbox.Text + "'", cs);
                var rdr = cmd.ExecuteScalar();
                cs.Close();
                if (rdr != null)
                {
                    MessageBox.Show("Username is already in use. Please choose another one!");
                }
                else
                {
                    try
                    {
                        cs.Open();
                        cmd = new SqlCommand("INSERT INTO Person (UserName, Password, RegisterDate) VALUES (@UserName, @Password, @RegisterDate)", cs);
                        cmd.Parameters.AddWithValue("@UserName", userNameTbox.Text);
                        cmd.Parameters.AddWithValue("@Password", passwordTbox.Text);
                        cmd.Parameters.AddWithValue("@RegisterDate", DateTime.Now.ToString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cs.Close();
                    }
                }
            }
        }

        private void singinBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userNameTbox.Text) || string.IsNullOrWhiteSpace(passwordTbox.Text))
            {
                MessageBox.Show("Cannot be empty!");
            }
            else
            {
                cs.Open();
                cmd = new SqlCommand("SELECT * FROM Person WHERE UserName = '" + userNameTbox.Text + "' AND Password = '" + passwordTbox.Text + "'", cs);
                var rdr = cmd.ExecuteScalar();

                if (rdr == null)
                {
                    MessageBox.Show("User not found!");
                }
                else
                {
                    editBtn.Visible = true;
                    deleteBtn.Visible = true;
                }
                cs.Close();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userNameTbox.Text) || string.IsNullOrWhiteSpace(passwordTbox.Text))
            {
                MessageBox.Show("Cannot be empty!");
            }
            else
            {
                try
                {
                    cs.Open();
                    cmd = new SqlCommand("UPDATE Person SET (UserName = @UserName) AND (Password = @Password) WHERE (UserName = @UserName)", cs);
                    cmd.Parameters.AddWithValue("@UserName", userNameTbox.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordTbox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully!");
                    editBtn.Visible = false;
                    deleteBtn.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cs.Close();
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userNameTbox.Text) || string.IsNullOrWhiteSpace(passwordTbox.Text))
            {
                MessageBox.Show("Cannot be empty!");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(userNameTbox.Text) || string.IsNullOrWhiteSpace(passwordTbox.Text))
                {
                    MessageBox.Show("Cannot be empty!");
                }
                else
                {
                    try
                    {
                        cs.Open();
                        cmd = new SqlCommand("DELETE FROM Person WHERE (UserName = @UserName)", cs);
                        cmd.Parameters.AddWithValue("@UserName", userNameTbox.Text);
                        cmd.Parameters.AddWithValue("@Password", passwordTbox.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully!");
                        editBtn.Visible = false;
                        deleteBtn.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cs.Close();
                    }
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            editBtn.Visible = false;
            deleteBtn.Visible = false;
            userNameTbox.Clear();
            passwordTbox.Clear();
        }
    }
}
