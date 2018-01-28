using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RockAndRollRides
{
    public partial class frmAddVehicle : Form
    {
        public frmAddVehicle()
        {
            InitializeComponent();
        }


        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close this form and open main menu
            this.Hide();
            var form3 = new frmMainMenu();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }


        private void frmAddVehicle_Load(object sender, EventArgs e)
        {
           /* //Create new data table object
            DataTable dtAutos = new DataTable();

            //Create new connection using connction string
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RockAndRollRides.accdb"))
            {
                //Create new adapter to select the last entry in data table
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT TOP 1 AutoID FROM [tblAutos] ORDER BY AutoID DESC;", conn);
                conn.Open(); //Open connection
                da.Fill(dtAutos); //Fill Data Table
                conn.Close();   //Close connection
            }*/
           

        }

        private void autoIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void autoIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void modelLabel_Click(object sender, EventArgs e)
        {

        }

        private void modelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            //Create a new connection using connection string
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RockAndRollRides.accdb"))
            {
                //Create a new command obeject to query
                OleDbCommand cmd = new OleDbCommand("INSERT INTO [tblAutos] "+
                                            "( AutoID, Year, Brand, Model, Engine, Body, Color, Condition, Modifications, MemberID, Pictures) "+
                                            "VALUES  (@autoID,@year,@brand,@model,@engine,@body,@color,@condition,@modifications,@memberID,@pictures)", conn);
                //Parameterize for safty
                cmd.Parameters.AddWithValue("@autoID", txtAutoID.Text);
                cmd.Parameters.AddWithValue("@year", txtYear.Text);
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@model", txtModel.Text);
                cmd.Parameters.AddWithValue("@engine", txtEngine.Text);
                cmd.Parameters.AddWithValue("@body", txtBody.Text);
                cmd.Parameters.AddWithValue("@color", txtColor.Text);
                cmd.Parameters.AddWithValue("@condition", txtCondition.Text);
                cmd.Parameters.AddWithValue("@modifications", txtModifications.Text);
                cmd.Parameters.AddWithValue("@memberID", txtMemberID.Text);
                cmd.Parameters.AddWithValue("@pictures", txtPictures.Text);
                

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

        private void modificationsLabel_Click(object sender, EventArgs e)
        {

        }

        private void modificationsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void picturesLabel_Click(object sender, EventArgs e)
        {

        }

        private void picturesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGetVIN_Click(object sender, EventArgs e)
        {
            //Creat a new VIN
            string vinRough = Guid.NewGuid().ToString("n").Substring(0, 17);
            string vinFinal = vinRough.ToUpper();
            txtAutoID.Text = vinFinal;
        }
    }
}
