using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockAndRollRides
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close main menu open add vehicle form
            this.Hide();
            var form2 = new frmAddVehicle();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close main menu open edit vehicle form
            this.Hide();
            var form2 = new frmEditVehicle();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btnLookUpVehicleMM_Click(object sender, EventArgs e)
        {
            //Close main menu open look up form (both vehicle and member)
            this.Hide();
            var form2 = new frmLookUpMembersAndVehicles();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btnAddMemberMM_Click(object sender, EventArgs e)
        {
            //Close main menu open add member form
            this.Hide();
            var form1 = new frmAddMember();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void btnEditMemberMM_Click(object sender, EventArgs e)
        {
            //Close main menu open edit member form
            this.Hide();
            var form1 = new frmEditMember();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void btnLookUpMemberMM_Click(object sender, EventArgs e)
        {
            //Close main menu open look up form (both vehicle and member)
            this.Hide();
            var form1 = new frmLookUpMembersAndVehicles();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void btnExitMM_Click(object sender, EventArgs e)
        {
            //Close form
            this.Close();
        }
       
    }
}
