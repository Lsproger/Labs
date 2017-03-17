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
        ErrorProvider ep = new ErrorProvider();
        Airplane plane = new Airplane();
        private object[] numbers = new object[500];
        public FAddAirplane()
        {
            InitializeComponent();
        }

        private void AddAirplane_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < numbers.Length; i++) { numbers[i] = i + 51; }
            CBNumberOfPlaces.Items.AddRange(numbers);
            TBAirplaneID.Text = Convert.ToString(Airport.number + 1);
        }

        private void FAddAirplane_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
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
            try
            {
                CheckValid();

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
                    FAddCrewMember membersForm = new FAddCrewMember(plane, this);
                    membersForm.Show();
                }
            }
            catch (FormatException)
            {
                
            }
        }

        private void CBNumberOfPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckValid()
        {
            if (TBAirplaneModel.Text.Equals(""))
                ep.SetError(TBAirplaneModel, "Поле не может быть пустим!!! ");
            if (TBCarrying.Text.Equals(""))
                ep.SetError(TBCarrying, "Поле не может быть пустим \nи должно содержать только цифры!");
            if (TBNumberOfMembers.Text.Equals(""))
                ep.SetError(TBNumberOfMembers, "Поле не может быть пустим \nи должно содержать только цифры!");
            if (RBMilitary.Checked == false && RBPassenger.Checked == false
                && RBTransporter.Checked == false)
                ep.SetError(RBMilitary, "One of this types must be checked!");
            if (CBNumberOfPlaces.SelectedItem == null)
                ep.SetError(CBNumberOfPlaces, "Number of places must be selected!");

            foreach (char s in TBCarrying.Text)
            {
                if (Char.IsDigit(s) != true)
                {
                    ep.SetError(TBCarrying, "Only digits!!!");
                    TBCarrying.ForeColor = Color.Red;
                }
                else
                {
                    TBCarrying.ForeColor = Color.Black;
                    ep.SetError(TBCarrying, "");
                }
            }

            foreach (char s in TBNumberOfMembers.Text)
            {
                if (Char.IsDigit(s) != true)
                {
                    ep.SetError(TBNumberOfMembers, "Only digits!!!");
                    TBNumberOfMembers.ForeColor = Color.Red;
                }
                else
                {
                    TBNumberOfMembers.ForeColor = Color.Black;
                    ep.SetError(TBNumberOfMembers, "");
                }
            }
        }
        
    }
}
