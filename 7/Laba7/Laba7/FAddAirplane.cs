using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

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
            //TBCarrying.KeyPress += TBCarrying_KeyPressed;
            //TBNumberOfMembers.KeyPress += TBNumberOfMembers_KeyPress;
            //RBMilitary.Validating += RB_Validating;
            //CBNumberOfPlaces.Validating += CBNumberOfPlaces_Validating;
            //TBAirplaneModel.Validating += TBAirplaneModel_Validating;
        }

        private void AddAirplane_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < numbers.Length; i++) { numbers[i] = i + 51; }
            CBNumberOfPlaces.Items.AddRange(numbers);
            TBAirplaneID.Text = Convert.ToString(Airport.number + 1);
        }

        private void TBYearOfIssue_Scroll(object sender, EventArgs e)
        {
            LYIssue.Text = Convert.ToString(TBYearOfIssue.Value);
        }

        private void GoToCreateCrewForm_Click(object sender, EventArgs e)
        {
            try
            {
                var results = new List<ValidationResult>();
                var context = new ValidationContext(plane);                                                                                                                                                                                         
               
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
                if (!Validator.TryValidateObject(plane, context, results, true))
                {
                    foreach (var res in results)

                        throw new ValidationException(res.ErrorMessage);
                }
                FAddCrewMember membersForm = new FAddCrewMember(plane, this);
                membersForm.Show();

            }
            catch (ValidationException ex)
            {
                
                MessageBox.Show(ex.Message);
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Empty fields!");
            }
        }

//        #region validating methods
//        private void TBCarrying_KeyPressed(object sender, KeyPressEventArgs e)
//        {
//            if (!Char.IsDigit(e.KeyChar))
//            {
//                TBCarrying.ForeColor = Color.Red;
//                ep.SetError(TBCarrying, "Данное поле должно содержать только цыферки!");
//            }
//            else
//            {
//                TBCarrying.ForeColor = Color.Black;
//                ep.SetError(TBCarrying, "");
//            }
//        }

//        private void TBNumberOfMembers_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            if (!Char.IsDigit(e.KeyChar))
//            {
//                TBNumberOfMembers.ForeColor = Color.Red;
//                ep.SetError(TBNumberOfMembers, "Данное поле должно содержать только цыферки!");
//            }
//            else
//            {
//                TBNumberOfMembers.ForeColor = Color.Black;
//                ep.SetError(TBNumberOfMembers, "");
//            }
//            //try
//            //{
//            //    Int32.Parse(TBNumberOfMembers.Text);
//            //}
//            //catch (Exception)
//            //{
//            //    ep.SetError(TBNumberOfMembers, "Данное поле должно содержать только цыферки!");
//            //}
//        }

//        private void TBAirplaneModel_Validating(object sender, CancelEventArgs e)
//        {
//            if (TBAirplaneModel.Text.Equals(""))
//                ep.SetError(TBAirplaneModel, "Поле не может быть пустим!!! ");
//        }

//        private void CBNumberOfPlaces_Validating(object sender, CancelEventArgs e)
//        {
//            if (CBNumberOfPlaces.SelectedItem == null)
//                ep.SetError(CBNumberOfPlaces, "Number of places must be selected!");
//        }

//        private void RB_Validating(object sender, CancelEventArgs e)
//        {
//            if (RBMilitary.Checked == false && RBPassenger.Checked == false
//                && RBTransporter.Checked == false)
//                ep.SetError(RBMilitary, "One of this types must be checked!");
//        }
//#endregion

    }
}
