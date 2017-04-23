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
    public partial class FComboSearch : Form
    {
        IEnumerable<Airplane> res1;
        IEnumerable<Airplane> res2;
        IEnumerable<Airplane> res3;
        IEnumerable<Airplane> res4;
        List<Airplane> res = new List<Airplane>();
        List<Airplane> airplanes;
        int MinNP, MaxNP, MinCarr, MaxCarr;
        public FComboSearch(List<Airplane> pl)
        {
            InitializeComponent();
            airplanes = new List<Airplane>(pl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res1 = null;
            res2 = null;
            res3 = null;
            res4 = null;
            resBox.Clear();
            Search_NPlanes();
            Search_Carr();
            Search_pModel();
            Search_pType();
            foreach(var plane in res1)
            {
                if (res2.Contains(plane) && res3.Contains(plane) && res4.Contains(plane))
                    resBox.Text += plane.ToString();
            }


        }

        private void Search_NPlanes()
        {
            if (pNPMin.Text == "")
                MinNP = 0;
            else MinNP = Convert.ToInt32(pNPMin.Text);
            if (pNPMax.Text == "")
                MaxNP = 999999;
            else MaxNP = Convert.ToInt32(pNPMax.Text);
            res1 =
            from plane in airplanes
            where plane.Places >= MinNP && plane.Places <= MaxNP
            select plane;
        }
        private void Search_Carr()
        {
            if (pCarrMin.Text == "")
                MinCarr = 0;
            else MinCarr = Convert.ToInt32(pCarrMin.Text);
            if (pCarrMax.Text == "")
                MaxCarr = 999999;
            else MaxCarr = Convert.ToInt32(pCarrMax.Text);

            res2 =
            from plane in airplanes
            where plane.Carrying >= MinCarr && plane.Carrying <= MaxCarr
            select plane;
        }
        private void Search_pModel()
        {
            if (pModel.Text != "")
                res3 =
                from plane in airplanes
                where plane.Model == pModel.Text
                select plane;
            else res3 = new List<Airplane>(airplanes);
        }
        private void Search_pType()
        {
            if (pType.Text != "")
                res4 =
                from plane in airplanes
                where plane.Type == pType.Text
                select plane;
            else res4 = new List<Airplane>(airplanes);
        }
    }
}
