using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Laba7
{
    public partial class FAddCrewMember : Form
    {
        Airplane nplane;
        FAddAirplane f;
        private object[] posts = { "First pilot", "Second pilot", "Hostess" };
        public FAddCrewMember(Airplane plane, FAddAirplane form)
        {
            nplane = plane;
            f = form;
            InitializeComponent();
            #region
            AddingCrewTable.RowCount = plane.crewNumb;
            for (int i = 1; i <= AddingCrewTable.RowCount; i++)
            {
                for (int j = 0; j < AddingCrewTable.ColumnCount; j++)
                {
                    if (j == 4)
                    {
                        ComboBox cbox = new ComboBox();
                        cbox.Items.AddRange(posts);
                        AddingCrewTable.Controls.Add(cbox);
                    }
                    else AddingCrewTable.Controls.Add(new TextBox());
                }
            }
            #endregion
        }

        private void FAddCrewMember_Load(object sender, EventArgs e)
        {

        }

        private void FAddCrewMember_Load_1(object sender, EventArgs e)
        {

        }

        private void BSaveCrew_Click(object sender, EventArgs e)
        {
            int n = 30;
            try { 
                for (int i = 0; i < nplane.crewNumb; i++)
                {
                    Control c3 = null;
                    Control c1 = AddingCrewTable.GetChildAtPoint(new Point(5, n));
                    Control c2 = GetNextControl(c1, true);
                    if (GetNextControl(c2, true) != null)
                    {
                        c3 = GetNextControl(c2, true);
                    }
                    else
                    {
                        c3 = new Control();
                        c3.Text = "";
                    }
                    Control c4 = GetNextControl(c3, true);
                    Control c5 = GetNextControl(c4, true);
                    Control c6 = GetNextControl(c5, true);
                    CrewMember cm = new CrewMember(
                                                c1.Text, c2.Text, c3.Text, c5.Text,
                                                Convert.ToInt32(c4.Text), Convert.ToInt32(c6.Text));
                    try
                    {
                        var results = new List<ValidationResult>();
                        var context = new ValidationContext(cm);
                        if (!Validator.TryValidateObject(cm, context, results, true))
                        {
                            foreach (var err in results)
                            {
                                throw new ValidationException(err.ErrorMessage);
                            }
                        }
                        nplane.crewMember.Add(cm);
                        n += 24;
                    }
                    catch (ValidationException ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw new ValidationException(ex.Message);
                    }
                }

                XmlSerializer formatter = new XmlSerializer(typeof(Airplane));
                // получаем поток, куда будем записывать сериализованный объект
                string fname = @"D:\Учёба\ООП\2 семестр\Labs\7\Laba7\Laba7\Airplanes\Airplane" + (nplane.Id) + ".xml";
                using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, nplane);
                }
                this.Close();
                f.Close();
            }
            catch(ValidationException ex)
            {
                MessageBox.Show("Isprav' oshibki");
            }
        }
    }
}
