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
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Laba7
{
    public partial class FAirport : Form
    {
        #region Необходимые элементы(Да-да)
        internal List<Airplane> airplanes = new List<Airplane>();
        internal List<Airplane> results = new List<Airplane>();
        Button bt = new Button();
        Label l1 = new Label();
        Label l2 = new Label();
        Label l3 = new Label();
        TextBox tb1 = new TextBox();
        TextBox tb2 = new TextBox();
        ListBox resultPlanes = new ListBox();
        TextBox sortResults = new TextBox();
        #endregion

        public FAirport()
        {
            InitializeComponent();
        }

        private void _listPl_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Airport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet.Airplanes". При необходимости она может быть перемещена или удалена.
            this.airplanesTableAdapter.Fill(this.airportDataSet.Airplanes);
            // _listPl.Font = new Font(new FontFamily("Times New Roman"), 20);
            //using (MyDbContext db = new MyDbContext())
            //{
            //    foreach (var plane in db.Airplanes)
            //    {
            //        _listPl.Items.Add(plane.ToString());
            //    }
            //}
        }
        private void BAddAIrplane_Click(object sender, EventArgs e)//Добавление самолёта
        {
            FAddAirplane addPlane = new FAddAirplane();     //Создание формы для добавления самолёта
            addPlane.Show();
        }




        //private int CaptainComparator(Airplane A, Airplane B)
        //{
        //    if (A.GetCap().Firstname[0] != B.GetCap().Firstname[0])
        //    {
        //        if (Convert.ToSByte(A.GetCap().Firstname[0]) < Convert.ToSByte(B.GetCap().Firstname[0]))
        //            return -1;
        //        else
        //            return 1;

        //    }
        //    else if (A.GetCap().Firstname[0] == B.GetCap().Firstname[0] && A.GetCap().Firstname[1] != B.GetCap().Firstname[1])
        //    {
        //        if (Convert.ToSByte(A.GetCap().Firstname[1]) < Convert.ToSByte(B.GetCap().Firstname[1]))
        //            return -1;
        //        else
        //            return 1;
        //    }
        //    else return 0;
        //}
        //private int PilotComparator(Airplane A, Airplane B)
        //{

        //    if (A.GetPil().Firstname[0] != B.GetPil().Firstname[0])
        //    {
        //        if (Convert.ToSByte(A.GetPil().Firstname[0]) < Convert.ToSByte(B.GetPil().Firstname[0]))
        //            return -1;
        //        else
        //            return 1;

        //    }
        //    else if (A.GetPil().Firstname[0] == B.GetPil().Firstname[0] && A.GetPil().Firstname[1] != B.GetPil().Firstname[1])
        //    {
        //        if (Convert.ToSByte(A.GetPil().Firstname[1]) < Convert.ToSByte(B.GetPil().Firstname[1]))
        //            return -1;
        //        else
        //            return 1;
        //    }
        //    else return 0;
        //}
        //private int LTOComparator(Airplane A, Airplane B)
        //{

        //    if (Convert.ToDateTime(A.LastService) < Convert.ToDateTime(B.LastService))
        //        return 1;

        //    else if (Convert.ToDateTime(A.LastService) > Convert.ToDateTime(B.LastService))
        //        return -1;
        //    else return 0;
        //}
        //#endregion
        /// <summary>
        /// Очистка поля элементов и добавление TextBox для вывода результата
        /// </summary>



        private void button1_Click(object sender, EventArgs e)
        {
            int Idpl = 1;
            foreach (var cell in dataGridView1.SelectedCells)
            {
                Idpl = (int)(cell as DataGridViewTextBoxCell).Value;
            }
            FAddCrewMember nm = new FAddCrewMember(Idpl);
            nm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (var cell in dataGridView1.SelectedCells)
            {
                if (cell is DataGridViewButtonCell) dataGridView1.Rows.RemoveAt((cell as DataGridViewButtonCell).RowIndex);
            }
        }

        private void _saveChanges_Click(object sender, EventArgs e)
        {
            airplanesTableAdapter.Update(airportDataSet);
            MessageBox.Show("Изменения сохранены!");
        }

        private void _sortAP_Click(object sender, EventArgs e)
        {
            Cre sd = new Cre();
            sd.Show();
           // DataGridViewColumn cmn = dataGridView1.Columns.GetFirstColumn(DataGridViewElementStates.Selected);
            //dataGridView1.Sort(cmn, ListSortDirection.Ascending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Index > 0)
                {
                    dataGridView1.Rows[row.Index - 1].Selected = true;
                    row.Selected = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Index < dataGridView1.Rows.Count-1)
                {
                    dataGridView1.Rows[row.Index+1].Selected = true;
                    row.Selected = false;
                }
            }
        }

        //private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    (sender as DataGridView).Sele
        //    MessageBox.Show((sender as DataGrid)..ToString());
        //}


    }
}