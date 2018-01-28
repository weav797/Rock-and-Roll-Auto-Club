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
    public partial class frmEditVehicle : Form
    {
        public frmEditVehicle()
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

        
        private void frmEditVehicle_Load(object sender, EventArgs e)
        {
            this.tblAutosBindingSource.AddNew();

        }

        private void brandLabel_Click(object sender, EventArgs e)
        {

        }

        private void brandTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void conditionLabel_Click(object sender, EventArgs e)
        {

        }

        private void conditionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Create new data table object
            DataTable dt = new DataTable();

            //Create new connection using connection string
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RockAndRollRides.accdb"))
            {
                //Create new command for SELECT statement (this is to bring back the auto info)
                //The autor ID is matched to a parameterized version of the text box text
                OleDbCommand cmd = new OleDbCommand("SELECT TOP 1 " +
                    " AutoID, Year, Brand, Model, Engine, Body, Color, Condition, Modifications, MemberId, Pictures " +
                    " FROM [tblAutos] WHERE AutoID = @AutoID ORDER BY AutoID DESC;", conn);
                cmd.Parameters.AddWithValue("@autoID", txtAutoID.Text);

                //Create a new adapter object to fill the text boxes
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                conn.Open(); //Open a connection
                //Fill text boxes with result of quert
                try
                {
                    da.Fill(dt);
                    txtAutoID.Text = dt.Rows[0]["AutoID"].ToString();
                    txtYear.Text = dt.Rows[0]["Year"].ToString();
                    txtBrand.Text = dt.Rows[0]["Brand"].ToString();
                    txtModel.Text = dt.Rows[0]["Model"].ToString();
                    txtEngine.Text = dt.Rows[0]["Engine"].ToString();
                    txtBody.Text = dt.Rows[0]["Body"].ToString();
                    txtColor.Text = dt.Rows[0]["Color"].ToString();
                    txtCondition.Text = dt.Rows[0]["Condition"].ToString();
                    txtModifications.Text = dt.Rows[0]["Modifications"].ToString();
                    txtMemberID.Text = dt.Rows[0]["MemberID"].ToString();
                    txtPictures.Text = dt.Rows[0]["Pictures"].ToString();
                }
                finally
                {
                    conn.Close(); //Close the connection no matter what happens
                }

            }

        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            //Create new connection using connection string
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=RockAndRollRides.accdb"))
            {
                //Create new command object to update the database
                OleDbCommand cmd = new OleDbCommand("UPDATE [tblAutos] " +
                     "SET " +
                     "Year=@year, " +
                     "Brand=@brand, " +
                     "Model=@model, " +
                     "Engine=@engine, " +
                     "Body=@body, " +
                     "Color=@color, " +
                     "Condition=@condition, " +
                     "Modifications=@modifications " +
                     "MemberId=@memberID, " +
                     "Pictures=@pictures, " +
                     "WHERE AutoID = @autoID", conn);
                //Parameterize for safty            
                cmd.Parameters.AddWithValue("@year", txtYear.Text);
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@model", txtModel.Text);
                cmd.Parameters.AddWithValue("@engine", txtEngine.Text);
                cmd.Parameters.AddWithValue("@body", txtBody.Text);
                cmd.Parameters.AddWithValue("@color", txtColor.Text);
                cmd.Parameters.AddWithValue("@condition", txtCondition.Text);
                cmd.Parameters.AddWithValue("@modifications", txtModifications.Text);
                cmd.Parameters.AddWithValue("@memberId", txtMemberID.Text);
                cmd.Parameters.AddWithValue("@pictures", txtPictures.Text);
                cmd.Parameters.AddWithValue("@autoID", txtAutoID.Text);


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

