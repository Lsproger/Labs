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
        bool vis = true;
        #endregion

        public FAirport()
        {
            Timer t = new Timer();
            t.Interval = 1000;
            t.Tick += TBDateTime_Click;
            t.Start();

            InitializeComponent();
            #region Menu
            ///События выбора одного из пунктов меню
            listPlanes.SelectedIndexChanged += ListPlanes_SelectedIndexChanged;

            Search_Company.Click += Search_Company_Click;
            Search_Type.Click += Search_Type_Click1;
            Search_NumbOfPlaces.Click += Search_NumbOfPlaces_Click;
            Search_Carrying.Click += Search_Carrying_Click;
           // Search_ComboSearch.Click += Search_ComboSearch_Click;

            Sort_FirstPilot.Click += Sort_FirstPilot_Click;
            Sort_SecPilot.Click += Sort_SecPilot_Click;
            Sort_LastTO.Click += Sort_LastTO_Click;

            Menu_Save.Click += Menu_Save_Click;
            About.Click += About_Click;

            авиакомпанииToolStripMenuItem.Click += Search_Company_Click;
            типуСамолётаToolStripMenuItem.Click += Search_Type_Click1;
            количествуМестToolStripMenuItem.Click+= Search_NumbOfPlaces_Click;
            грузоподъёмностиToolStripMenuItem.Click += Search_Carrying_Click;
           // несколькоКритериевToolStripMenuItem.Click += Search_ComboSearch_Click;

            командираToolStripMenuItem.Click += Sort_FirstPilot_Click;
            пилотаToolStripMenuItem.Click += Sort_SecPilot_Click;
            датаПоследнегоТОToolStripMenuItem.Click += Sort_LastTO_Click;

            toolStripButton1.Click += Menu_Save_Click;
            toolStripButton2.Click += About_Click;

            toolStripContainer1.RightToolStripPanel.ControlAdded += RightLeftAdded;
            toolStripContainer1.LeftToolStripPanel.ControlAdded += RightLeftAdded;
            toolStripContainer1.TopToolStripPanel.ControlAdded += TopBotAdded;
            toolStripContainer1.BottomToolStripPanel.ControlAdded += TopBotAdded;
            #endregion
        }
        private void ListPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (listPlanes.SelectedItem as Airplane).Id;
                MessageBox.Show(Airport.GetAirplane(id - 1).ToString() + "\nЕееее, самолёт");
            }
            catch (NullReferenceException) { }
        }
        private void Airport_Load(object sender, EventArgs e)
        {
            Airport.LoadAirport(this);
            foreach (Airplane plane in airplanes)   //Загрузка списка самолётов
            {
                listPlanes.Items.Add(plane);
                Airport.number = plane.Id;
            }
        }
        private void BAddAIrplane_Click(object sender, EventArgs e)//Добавление самолёта
        {
            FAddAirplane addPlane = new FAddAirplane();     //Создание формы для добавления самолёта
            addPlane.Show();
        }
        private void BRefresh_Click(object sender, EventArgs e)     //Обновление списка самлётов
        {
            airplanes.Clear();
            listPlanes.Items.Clear();
            Airport.LoadAirport(this);
            foreach (var plane in airplanes)
            {
                listPlanes.Items.Add(plane);
            }
            Airport.number = airplanes.Count;
        }
        private void BTShowList_Click(object sender, EventArgs e)
        {
            DoSmth();
            toolStripContainer1.ContentPanel.Controls.Remove(sortResults);
            toolStripContainer1.ContentPanel.Controls.Add(listPlanes);
            listPlanes.Items.Clear();
            listPlanes.Location = new Point(12, 60);
            listPlanes.Size = new Size(380, 320);
            foreach(Airplane plane in airplanes)
            {
                listPlanes.Items.Add(plane);
            }
            listPlanes.Visible = true;
        }

        /// <summary>
        /// Изменение ориентации toolStrip1 на вертикальную
        /// </summary>
        private void TopBotAdded(object sender, ControlEventArgs e)
        {
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
        }

        /// <summary>
        /// Изменение ориентации toolStrip1 на горизонтальную
        /// </summary>
        private void RightLeftAdded(object sender, ControlEventArgs e)
        {
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это первая и единственная версия данного продукта.\n   Разработчики:\n   Михновец Юрий");
        }
        private void Menu_Save_Click(object sender, EventArgs e)
        {
            if (results.Count != 0)
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Airplane>));
                // получаем поток, куда будем записывать сериализованный объект
                string fname = @"..\..\Results\Result.xml";
                using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, results);
                }
            }     
            else MessageBox.Show("Хмммм, по какой-то причине файл не ссохранён, соре");
        }

        #region Сортировки и поиски по раззным преколам
        private void Sort_LastTO_Click(object sender, EventArgs e)
        {
            pBar.Minimum = 1;
            pBar.Maximum = airplanes.Count();
            pBar.Value = 1;
            pBar.Step = 1;

            DoSmth();
            results = airplanes;
            results.Sort(new Comparison<Airplane>(LTOComparator));
            sortResults.Clear();
            foreach (Airplane plane in results)
            {
                sortResults.Text += plane.ToString();
                pBar.PerformStep();
            }
            pBar.Value = pBar.Maximum;
        }
        private void Sort_SecPilot_Click(object sender, EventArgs e)
        {
            pBar.Minimum = 1;
            pBar.Maximum = airplanes.Count();
            pBar.Value = 1;
            pBar.Step = 1;

            DoSmth();
            results = airplanes;
            results.Sort(new Comparison<Airplane>(PilotComparator));
            sortResults.Clear();
            foreach (Airplane plane in results)
            {
                sortResults.Text += plane.ToString();
                pBar.PerformStep();
            }
            pBar.Value = pBar.Maximum;
        }
        private void Sort_FirstPilot_Click(object sender, EventArgs e)
        {
            pBar.Minimum = 1;
            pBar.Maximum = airplanes.Count();
            pBar.Value = 1;
            pBar.Step = 1;

            DoSmth();
            results = airplanes;
            results.Sort(new Comparison<Airplane>(CaptainComparator));
            sortResults.Clear();
            foreach (Airplane plane in results)
            {
                sortResults.Text += plane.ToString();
                pBar.PerformStep();
            }
            pBar.Value = pBar.Maximum;
        }
        //private void Search_ComboSearch_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
        private void Search_NumbOfPlaces_Click(object sender, EventArgs e)
        {
            Elements();
            l1.Text = "Поиск по количеству мест";
            l2.Text = "Количество мест от:";
            l3.Visible = true;
            l3.Enabled = true;
            l3.Text = "До:";
            tb2.Visible = true;
            tb2.Enabled = true;
            bt.Click += Result_NPlaces_Click;
        }
        private void Search_Type_Click1(object sender, EventArgs e)
        {
            Elements();
            l1.Text = "Поиск по типу самолёта";
            l2.Text = "Тип самолёта";
            bt.Click += Result_Type_Click;
        }
        private void Search_Company_Click(object sender, EventArgs e)
        {
            Elements();
            l1.Text = "Поиск по авиакомпании";
            l2.Text = "Название компании";
            bt.Click += Result_Company_Click;
        }
        private void Search_Carrying_Click(object sender, EventArgs e)
        {
            Elements();
            l1.Text = "Поиск по грузоподъёмности";
            l2.Text = "Гузоподъёмность от:";
            l3.Visible = true;
            l3.Enabled = true;
            l3.Text = "До:";
            tb2.Visible = true;
            tb2.Enabled = true;
            bt.Click += Result_Carrying_Click;
        }
        #endregion

        /// <summary>
        /// Вывод результатов поиска по грузоподъёмности
        /// </summary>
        private void Result_Carrying_Click(object sender, EventArgs e)
        {
            pBar.Minimum = 1;
            pBar.Maximum = airplanes.Count();
            pBar.Value = 1;
            pBar.Step = 1;
            resultPlanes.Items.Clear();
            results.Clear();
            if (tb1.Text != "" && tb2.Text != "")
            {
                foreach (var plane in airplanes)
                {
                    if (plane.Carrying >= Convert.ToInt32(tb1.Text) && plane.Carrying <= Convert.ToInt32(tb2.Text))
                    { 
                        resultPlanes.Items.Add(plane);
                        results.Add(plane);
                        pBar.PerformStep();
                    }
                }
                pBar.Value = pBar.Maximum;
                ShowLP();
              //  pBar.Value = 1;
            }
            else if (tb1.Text != "" && tb2.Text == "")
            {
                
                foreach (var plane in airplanes)
                {
                    if (plane.Carrying >= Convert.ToInt32(tb1.Text))
                    { 
                        resultPlanes.Items.Add(plane);
                        results.Add(plane);
                        pBar.PerformStep();
                    }
                }
                pBar.Value = pBar.Maximum;
                ShowLP();
                
               // pBar.Value = 1;
            }
            else if (tb1.Text == "" && tb2.Text != "")
            {
                foreach (var plane in airplanes)
                {
                    if (plane.Carrying <= Convert.ToInt32(tb2.Text))
                    { 
                        resultPlanes.Items.Add(plane); 
                        results.Add(plane);
                        pBar.PerformStep();
                    }
                }
                pBar.Value = pBar.Maximum;
                ShowLP();
                //pBar.Value = 1;
            }
            else if (tb1.Text == "" && tb2.Text == "") MessageBox.Show("Введите критерии поиска");
            ShowLP();
        }

        /// <summary>
        /// Вывод результатов поиска по количеству мест
        /// </summary>
        private void Result_NPlaces_Click(object sender, EventArgs e)
        {
            pBar.Minimum = 1;
            pBar.Maximum = airplanes.Count();
            pBar.Value = 1;
            pBar.Step = 1;
            resultPlanes.Items.Clear();
            results.Clear();
            if (tb1.Text != "" && tb2.Text != "")
            {
                foreach (var plane in airplanes)
                {
                    if (plane.Places >= Convert.ToInt32(tb1.Text) && plane.Places <= Convert.ToInt32(tb2.Text))
                    { resultPlanes.Items.Add(plane); results.Add(plane); pBar.PerformStep(); }
                }
                pBar.Value = pBar.Maximum;
                ShowLP();
            }
            else if (tb1.Text != "" && tb2.Text == "")
            {
                foreach (var plane in airplanes)
                {
                    if (plane.Places >= Convert.ToInt32(tb1.Text))
                    {
                        resultPlanes.Items.Add(plane); results.Add(plane); pBar.PerformStep();
                    }
                }
                pBar.Value = pBar.Maximum;
                ShowLP();
            }
            else if (tb1.Text == "" && tb2.Text != "")
            {
                foreach (var plane in airplanes)
                {
                    if (plane.Places <= Convert.ToInt32(tb2.Text))
                    {
                        resultPlanes.Items.Add(plane); results.Add(plane); pBar.PerformStep();
                    }
                }
                pBar.Value = pBar.Maximum;
                ShowLP();
            }
            else if (tb1.Text == "" && tb2.Text == "") MessageBox.Show("Введите критерии поиска");
        }

        /// <summary>
        /// Вывод результатов поиска по типу самолёта
        /// </summary>
        private void Result_Type_Click(object sender, EventArgs e)
        {
            pBar.Minimum = 1;
            pBar.Maximum = airplanes.Count();
            pBar.Value = 1;
            pBar.Step = 1;
            resultPlanes.Items.Clear();
            results.Clear();
            pBar.Minimum = 1;
            pBar.Maximum = airplanes.Count;
            pBar.Step = 1;
            foreach (Airplane plane in airplanes)
            {
                //Regex.IsMatch(plane.Type,
                if (tb1.Text == plane.Type) {resultPlanes.Items.Add(plane); results.Add(plane);pBar.PerformStep();
                }
            }
            pBar.Value = pBar.Maximum;
            ShowLP();
        }

        /// <summary>
        /// Вывод результатов поиска по компании
        /// </summary>
        private void Result_Company_Click(object sender, EventArgs e)
        {
            pBar.Minimum = 1;
            pBar.Maximum = airplanes.Count();
            pBar.Value = 1;
            pBar.Step = 1;
            resultPlanes.Items.Clear();
            results.Clear();
            pBar.Minimum = 1;
            pBar.Maximum = airplanes.Count;
            pBar.Step = 1;
            foreach (Airplane plane in airplanes)
            {
                //Regex.IsMatch(plane.Type,
                if (tb1.Text == plane.Model)
                {
                    resultPlanes.Items.Add(plane); results.Add(plane); pBar.PerformStep();
                }
            }
            pBar.Value = pBar.Maximum;
            ShowLP();
        }

        ///<summary>
        ///Список результатов поиска/сортировки
        ///</summary>>
        private void ShowLP()
        {
            resultPlanes.Location = new Point(12, 135);
            resultPlanes.Width = 350;
            resultPlanes.Height = 270;
            resultPlanes.Visible = true;
            toolStripContainer1.ContentPanel.Controls.Add(resultPlanes);
        }

        /// <summary>
        /// Этот метод создаёт пространство для создания запроса поиска 
        /// </summary>
        private void Elements()
        {
            listPlanes.Enabled = false;
            listPlanes.Visible = false;
            toolStripContainer1.ContentPanel.Controls.Remove(sortResults);


            toolStripContainer1.ContentPanel.Controls.Remove(l1);
            toolStripContainer1.ContentPanel.Controls.Remove(l2);
            toolStripContainer1.ContentPanel.Controls.Remove(tb1);
            toolStripContainer1.ContentPanel.Controls.Remove(bt);

            l1.Location = new System.Drawing.Point(12, 60);
            l1.Size = new System.Drawing.Size(150, 23);
            l1.BorderStyle = BorderStyle.None;
            l1.BackColor = Color.Aquamarine;
            toolStripContainer1.ContentPanel.Controls.Add(l1);

            l2.Location = new System.Drawing.Point(12, 85);
            l2.Size = new System.Drawing.Size(120, 23);
            l2.BorderStyle = BorderStyle.None;
            l2.BackColor = Color.Aquamarine;
            toolStripContainer1.ContentPanel.Controls.Add(l2);

            tb1.Location = new System.Drawing.Point(135, 83);
            tb1.Size = new System.Drawing.Size(100, 23);
            tb1.BorderStyle = BorderStyle.Fixed3D;
            tb1.Name = "FirstCR";
            toolStripContainer1.ContentPanel.Controls.Add(tb1);

            l3.Location = new Point(240, 85);
            l3.Size = new System.Drawing.Size(30, 23);
            l3.BorderStyle = BorderStyle.None;
            l3.BackColor = Color.Aquamarine;
            l3.Enabled = false;
            l3.Visible = false;
            toolStripContainer1.ContentPanel.Controls.Add(l3);

            tb2.Location = new System.Drawing.Point(280, 83);
            tb2.Size = new System.Drawing.Size(100, 23);
            tb2.BorderStyle = BorderStyle.Fixed3D;
            tb2.Name = "LastCR";
            tb2.Enabled = false;
            tb2.Visible = false;
            toolStripContainer1.ContentPanel.Controls.Add(tb2);

            bt.Text = "Найти";
            bt.Location = new Point(12, 110);
            toolStripContainer1.ContentPanel.Controls.Add(bt);
        }

        #region Компараторы для сортировки списка самолётов по разным полям
        private int CaptainComparator(Airplane A, Airplane B)
        {
            if (A.GetCap().Firstname[0] != B.GetCap().Firstname[0])
            {
                if (Convert.ToSByte(A.GetCap().Firstname[0]) < Convert.ToSByte(B.GetCap().Firstname[0]))
                    return -1;
                else
                    return 1;

            }
            else if (A.GetCap().Firstname[0] == B.GetCap().Firstname[0] && A.GetCap().Firstname[1] != B.GetCap().Firstname[1])
            {
                if (Convert.ToSByte(A.GetCap().Firstname[1]) < Convert.ToSByte(B.GetCap().Firstname[1]))
                    return -1;
                else
                    return 1;
            }
            else return 0;
        }
        private int PilotComparator(Airplane A, Airplane B)
        {

            if (A.GetPil().Firstname[0] != B.GetPil().Firstname[0])
            {
                if (Convert.ToSByte(A.GetPil().Firstname[0]) < Convert.ToSByte(B.GetPil().Firstname[0]))
                    return -1;
                else
                    return 1;

            }
            else if (A.GetPil().Firstname[0] == B.GetPil().Firstname[0] && A.GetPil().Firstname[1] != B.GetPil().Firstname[1])
            {
                if (Convert.ToSByte(A.GetPil().Firstname[1]) < Convert.ToSByte(B.GetPil().Firstname[1]))
                    return -1;
                else
                    return 1;
            }
            else return 0;
        }
        private int LTOComparator(Airplane A, Airplane B)
        {

            if (Convert.ToDateTime(A.LastService) < Convert.ToDateTime(B.LastService))
                return 1;

            else if (Convert.ToDateTime(A.LastService) > Convert.ToDateTime(B.LastService))
                return -1;
            else return 0;
        }
        #endregion
        /// <summary>
        /// Очистка поля элементов и добавление TextBox для вывода результата
        /// </summary>
        private void DoSmth()
        {
            #region Очистка поля элементов и добавление TextBox для вывода результата
            toolStripContainer1.ContentPanel.Controls.Remove(l1);
            toolStripContainer1.ContentPanel.Controls.Remove(l2);
            toolStripContainer1.ContentPanel.Controls.Remove(tb1);
            toolStripContainer1.ContentPanel.Controls.Remove(bt);
            toolStripContainer1.ContentPanel.Controls.Remove(l3);
            toolStripContainer1.ContentPanel.Controls.Remove(tb2);
            toolStripContainer1.ContentPanel.Controls.Remove(sortResults);
            toolStripContainer1.ContentPanel.Controls.Remove(resultPlanes);
            toolStripContainer1.ContentPanel.Controls.Remove(listPlanes);

            toolStripContainer1.ContentPanel.Controls.Add(sortResults);
            sortResults.Location = new Point(12, 70);
            sortResults.Multiline = true;
            sortResults.Width = 380;
            sortResults.Height = 340;
            sortResults.ScrollBars = ScrollBars.Vertical;
            #endregion
        }

        private void Search_ComboSearch_Click_1(object sender, EventArgs e)
        {
            FComboSearch newForm = new FComboSearch(airplanes);
            newForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (vis)
            {
                toolStrip1.Visible = false;
                vis = false;
            }
            else
            {
                toolStrip1.Visible = true;
                vis = true;
            }
        }

        private void hideToolbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vis)
            {
                toolStrip1.Visible = false;
                vis = false;
            }
            else
            {
                toolStrip1.Visible = true;
                vis = true;
            }
        }

        private void TBDateTime_Click(object sender, EventArgs e)
        {
            TBDateTime.Text = Convert.ToString(DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load(@"..\..\Airplanes\Airplane1.xml");
            MessageBox.Show((xdoc.Element("Airplane").ToString()));
        }
    }
}
