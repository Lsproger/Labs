using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba7
{
    public partial class FAddAirplane : Form
    {
        Airplane plane = new Airplane();
        private object[] numbers = new object[500];
        public FAddAirplane()
        {
            InitializeComponent();
        }

        private void AddAirplane_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < numbers.Length; i++) { numbers[i] = i+51; }
            CBNumberOfPlaces.Items.AddRange(numbers);
            TBAirplaneID.Text = Convert.ToString(Airport.number+1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TBYearOfIssue_Scroll(object sender, EventArgs e)
        {
            LYIssue.Text = Convert.ToString(TBYearOfIssue.Value);
        }

        private void GoToCreateCrewForm_Click(object sender, EventArgs e)
        {
            plane.Carrying = Convert.ToInt32(TBCarrying.Text);
            plane.IssueYear = Convert.ToInt32(LYIssue.Text);
            plane.LastService = LSmonthCalendar.SelectionStart.ToLongDateString();
            plane.Model = TBAirplaneModel.Text;
            plane.Places = Convert.ToInt32(CBNumberOfPlaces.SelectedItem);
            if (RBMilitary.Checked) plane.Type = RBMilitary.Text;
            else if (RBPassenger.Checked) plane.Type = RBPassenger.Text;
            else if (RBTransporter.Checked) plane.Type = RBTransporter.Text;
            else MessageBox.Show("Ошибка в радиобаттонах");
            plane.Id = Airport.number + 1;
            plane.crewNumb = Convert.ToInt32(TBNumberOfMembers.Text);
            FAddCrewMember membersForm = new FAddCrewMember(plane);
            membersForm.Show();
            //Close();
        }

        private void CBNumberOfPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
