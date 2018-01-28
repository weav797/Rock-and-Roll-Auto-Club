using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockAndRollRides
{
    public partial class frmEditMember : Form
    {
        public frmEditMember()
        {
            InitializeComponent();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            this.tblMembersBindingSource.AddNew();

        }

      private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close this form, open main menu
            this.Hide();
            var form3 = new frmMainMenu();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //Create new data table object
            DataTable dt = new DataTable();

            //Create new connection using connection string
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RockAndRollRides.accdb"))
            {
                //Create new command for SELECT statement (this is to bring back the member's info)
                //The member ID is matched to a parameterized version of the text box text
                OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 " +
                    " MemberID, LastName, FirstName, Phone, Address, City, State, Zip, Specialty " +
                    " FROM [tblMembers] WHERE MemberID = @memberID ORDER BY MemberID DESC;",conn);
                cmd.Parameters.AddWithValue("@memberID",txtMemberID.Text);

                //Create a new adapter object to fill the text boxes
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                conn.Open(); //Open a connection
                //Fill text boxes with result of quert
                try
                {
                    da.Fill(dt);
                    txtLastName.Text = dt.Rows[0]["LastName"].ToString();
                    txtFirstName.Text = dt.Rows[0]["FirstName"].ToString();
                    txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();
                    txtCity.Text = dt.Rows[0]["City"].ToString();
                    txtState.Text = dt.Rows[0]["State"].ToString();
                    txtZip.Text = dt.Rows[0]["Zip"].ToString();
                    txtSpecialty.Text = dt.Rows[0]["Specialty"].ToString();
                }
                finally
                {
                    conn.Close(); //Close the connection no matter what happens
                }

            }

        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            //Create new connection using connection string
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RockAndRollRides.accdb"))
            {
                //Create new command object to update the database
                OleDbCommand cmd = new OleDbCommand("UPDATE [tblMembers] " +
                     "SET "+
                     "LastName=@lasthame, " +
                     "FirstName=@firstname, " +
                     "Phone=@phone, " +
                     "Address=@address, " +
                     "City=@city, " +
                     "State=@state, " +
                     "Zip=@zip, " +
                     "Specialty=@specialty " +
                     "WHERE MemberID = @memberID", conn);
                //Parameterize for safty            
                cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@state", txtState.Text);
                cmd.Parameters.AddWithValue("@zip", txtZip.Text);
                cmd.Parameters.AddWithValue("@specialty", txtSpecialty.Text);
                cmd.Parameters.AddWithValue("@memberID", txtMemberID.Text);
               

                conn.Open(); //Open Connection
                /*int results = cmd.ExecuteNonQuery();  // Check update status
                MessageBox.Show("CMD: " + cmd.CommandText.ToString() + Environment.NewLine +
                                 "Results: " + results);*/
                conn.Close(); //Close Connection
            }

            //Give feedback to user
            MessageBox.Show("Edit Saved");

            //Close this form, open main menu
            this.Hide();
            var form3 = new frmMainMenu();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
