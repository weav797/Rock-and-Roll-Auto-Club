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
using System.Configuration;

namespace RockAndRollRides
{
    public partial class frmLookUpMembersAndVehicles : Form
    {
        public frmLookUpMembersAndVehicles()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Toggle visibility to show autogrid view and hide members grid view
            tblMembersDataGridView.Visible = false;
            tblAutosDataGridView.Visible = true;

            //Use data table object for the grid view data source
            //Select row with corresponding auto ID
            //If the result is empty show no results found
            //Else show search results in the auto grid view
            DataTable dt = (DataTable)this.tblAutosDataGridView.DataSource;
            DataRow[] dr = dt.Select("AutoID = '" + txtAutoId.Text + "'");
            if (dr.Length < 1) MessageBox.Show("No results found!");
            else
            {
                this.tblAutosDataGridView.DataSource = dr.CopyToDataTable();
            }
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            //Hide this form, open main menu form
            this.Hide();
            var form3 = new frmMainMenu();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

       private void tblAutosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //I have no idea what this crap is
            this.Validate();
            this.tblAutosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rockAndRollDataSet);

        }

        private void frmLookUpMembersAndVehicles_Load(object sender, EventArgs e)
        {
            txtMemberId.Focus();
            //Create two data table objects
            DataTable dtMembers = new DataTable();
            DataTable dtAutos = new DataTable();

            //Open a connection using connection string
            //Create an adapter to use SELECT statement and connection string
            //Open connection to tables, fill data table objects
            //Close connection
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RockAndRollRides.accdb"))
            {
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [tblMembers];", conn);
                conn.Open();
                da.Fill(dtMembers);
                da = new OleDbDataAdapter("SELECT * FROM [tblAutos];", conn);
                da.Fill(dtAutos);
                conn.Close();
            }
            //Fill data grid views from data table objects
            this.tblMembersDataGridView.DataSource = dtMembers;
            this.tblAutosDataGridView.DataSource = dtAutos;


        }

        private void btnSearchByMember_Click(object sender, EventArgs e)
        {
            //Toggle visibility, members grid view visible
            tblAutosDataGridView.Visible = false;
            tblMembersDataGridView.Visible = true;

            //Use data table object for the grid view data source
            //Select row with corresponding member ID
            //If the result is empty show no results found
            //Else show search results in the members grid view
            DataTable dt = (DataTable)this.tblMembersDataGridView.DataSource;
            DataRow[] dr = dt.Select("MemberID = '" + txtMemberId.Text + "'");
            if (dr.Length < 1) MessageBox.Show("No results found!");
            else
            {
                this.tblMembersDataGridView.DataSource = dr.CopyToDataTable();
            }
        }
    }
}
