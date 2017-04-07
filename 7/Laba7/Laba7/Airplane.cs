using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    public class Airplane
    {
        /// <summary>
        /// Класс, описывающий сммолёт
        /// </summary>
        public Airplane() { }

        public int crewNumb;//Количество членов экипажа
        private int id;
        public int Id//ID самолёта
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private string type;
        public string Type//Тип самолёта
        {
            get { return type; }
            set { type = value; }
        }

        private string model;
        public string Model//Модель самолёта
        {
            get { return model; }
            set { model = value; }
        }

        public List<CrewMember> crewMember = new List<CrewMember>();
        public void Add(object obj)
        {
            crewMember.Add(obj as CrewMember);
        }

        private int places;
        public int Places//Количество мест в самолёте
        {
            get { return places; }
            set { places = value; }
        }

        private int issueYear;
        public int IssueYear//Год производства
        {
            get { return issueYear; }
            set { issueYear = value; }
        }

        private int carrying;
        public int Carrying//Грузоподъёмность
        {
            get { return carrying; }
            set { carrying = value; }
        }

        private string lastService;
        public string LastService//Дата последнего ТО
        {
            get { return lastService; }
            set { lastService = value; }
        }

        public CrewMember GetCap()
        {
            CrewMember cm = new CrewMember();
            cm = crewMember[0];
            for (int i = 0; i < crewNumb; i++)
            {
                if (crewMember[i].Post == "First pilot")
                {
                    cm = crewMember[i];
                    break;
                }
            }
            return cm;
        }


        public CrewMember GetPil()
        {
            CrewMember cm = new CrewMember();
            cm = crewMember[0];
            for (int i = 0; i < crewNumb; i++)
            {
                if (crewMember[i].Post == "Second pilot")
                {
                    cm = crewMember[i];
                    break;
                }
            }
            return cm;
        }
        public override string ToString()
        {
            string s;
            s = ("ID:"+Id+ 
                Environment.NewLine + "     Type:" + Type +
                Environment.NewLine + "     Model:" + Model +
                Environment.NewLine + "     Places:" + Places +
                Environment.NewLine + "     Carrying:" + Carrying +
                Environment.NewLine + "     Captain's name: " + GetCap().Firstname+
                Environment.NewLine + "     Pilot's name: " + GetPil().Firstname +
                Environment.NewLine + "     Last service: " + LastService +
                Environment.NewLine); 
            return s;
        }
        
    }
}
