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
using System.Drawing.Imaging;
using System.IO;

namespace Laba7
{
    public partial class FAddAirplane : Form
    {
        ErrorProvider ep = new ErrorProvider();
        Airplane plane = new Airplane();
        private object[] numbers = new object[500];
        int apId;
        int id1 = 0;
        string imPath;
        Bitmap bmi;
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
           
        }

        private void TBYearOfIssue_Scroll(object sender, EventArgs e)
        {
            _issue.Text = Convert.ToString(TBYearOfIssue.Value);
        }

        private void GoToCreateCrewForm_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                Airplane ap = new Airplane();
                ap.Issue = _calend.SelectionStart;
                ap.Model = _model.Text;
                if (RBMilitary.Checked) ap.Type = RBMilitary.Text;
                else if (RBPassenger.Checked) ap.Type = RBPassenger.Text;
                else if (RBTransporter.Checked) ap.Type = RBTransporter.Text;
                ap.Places = Convert.ToInt32(_places.Text);
                ap.Pic = ConvertImageToByteArray(imPath);
                db.Airplanes.Add(ap);
                db.SaveChanges();
                foreach (var plane in db.Airplanes)
                {
                    if (plane.PlaneId >= id1)
                    {
                        apId = plane.PlaneId;
                        id1 = plane.PlaneId;
                    }
                }
                
            }
            FAddCrewMember cm = new FAddCrewMember(apId);
            cm.Show();
            this.Close();
        }

        private void AttachPhoto_Click(object sender, EventArgs e)
        {
            dlg.AddExtension = true;
            dlg.ShowDialog();
            dlg.InitialDirectory = "";
            dlg.Filter = "Image files (*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Image im;
                im = new Bitmap(dlg.FileName);
                bmi = new Bitmap(im, 170, 110);
                imPath = dlg.FileName;
                _pathIm.Text = dlg.FileName;
                _preview.Image = bmi;
            }
        }

        private static byte[] ConvertImageToByteArray(string fileName)
        {
            Bitmap bitMap = new Bitmap(fileName);
            ImageFormat bmpFormat = bitMap.RawFormat;
            var imageToConvert = Image.FromFile(fileName);
            using (MemoryStream ms = new MemoryStream())
            {
                imageToConvert.Save(ms, bmpFormat);
                return ms.ToArray();
            }
        }
    }
}
