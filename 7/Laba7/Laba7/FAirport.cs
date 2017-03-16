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
using System.Xml;

namespace Laba7
{
    public partial class FAirport : Form
    {
       
        internal List<Airplane> airplanes = new List<Airplane>();
        public FAirport()
        {
            InitializeComponent();
            listPlanes.SelectedIndexChanged += ListPlanes_SelectedIndexChanged;
        }

        private void ListPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            MessageBox.Show((listPlanes.SelectedItem as Airplane).ToString());
        }

        private void Airport_Load(object sender, EventArgs e)
        {
            Airport.LoadAirport(this);
            foreach (Airplane plane in airplanes)
            {
                listPlanes.Items.Add(plane);
            }
            Airport.number = airplanes.Count;
        }

        private void BAddAIrplane_Click(object sender, EventArgs e)
        {
            FAddAirplane addPlane = new FAddAirplane();
            addPlane.Show();
        }

        private void listPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BRefresh_Click(object sender, EventArgs e)
        {

            airplanes.Clear();
            Airport.LoadAirport(this);
            foreach (var plane in airplanes)
            {
                listPlanes.Items.Add(plane);
            }
            Airport.number = airplanes.Count;
        }
    }
}
