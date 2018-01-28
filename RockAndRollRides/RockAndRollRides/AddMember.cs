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
    public partial class frmAddMember : Form
    {
        public frmAddMember()
        {
            InitializeComponent();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close this form, open main menu
            this.Hide();
            var form3 = new frmMainMenu();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void frmAddMember_Load(object sender, EventArgs e)
        {
            //Create new data table object
            DataTable dtMembers = new DataTable();

            //Create new connection using connction string
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RockAndRollRides.accdb"))
            {
                //Create new adapter to select the last entry in data table
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT TOP 1 MemberID FROM [tblMembers] ORDER BY MemberID DESC;", conn);
                conn.Open(); //Open connection
                da.Fill(dtMembers); //Fill Data Table
                conn.Close();   //Close connection
            }
            //Add one to last entry to get the new member's memberID
            txtMemberID.Text = (Int32.Parse(dtMembers.Rows[0][0].ToString()) + 1).ToString();
        }

        private void tblMembersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //No idea
            this.Validate();
            this.tblMembersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rockAndRollDataSet);
        }

        private void cityLabel_Click(object sender, EventArgs e)
        {

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            //Create a new connection using connection string
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RockAndRollRides.accdb"))
            {
                //Create a new command obeject to query
                OleDbCommand cmd = new OleDbCommand("INSERT INTO [tblMembers] "+
                                    "( MemberID, LastName, FirstName, Phone, Address, City, State, Zip, Specialty) "+
                            "VALUES  (@memberID,@lastname,@firstname,@phone,@address,@city,@state,@zip,@specialty)", conn);
                //Parameterize for safty
                cmd.Parameters.AddWithValue("@memberID", txtMemberID.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@state", txtState.Text);
                cmd.Parameters.AddWithValue("@zip", txtZip.Text);
                cmd.Parameters.AddWithValue("@specialty", txtSpecialty.Text);
                
                conn.Open(); //Open connection
                cmd.ExecuteNonQuery();
                conn.Close(); //Close connection
            }

            //Give user feedback            
            MessageBox.Show("Done!");

            //Close this form, open main menu
            this.Hide();
            var form3 = new frmMainMenu();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
