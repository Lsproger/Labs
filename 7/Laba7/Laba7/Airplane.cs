using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laba7
{
    public class Airplane
    {
        /// <summary>
        /// Класс, описывающий самолёт
        /// </summary>
        public Airplane() { }

        private int crewNumber;
        [Required]
        [Range(2, 10)]
        public int crewNumb
        {
            get { return crewNumber; }
            set { crewNumber = value; }
        }//Количество членов экипажа

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
        [Required]
        public string Type//Тип самолёта
        {
            get { return type; }
            set { type = value; }
        }

        private string model;
        [Required]
        [StringLength(maximumLength:20, MinimumLength =2)]
        [RegularExpression(@"^[A-Z][a-zA-Z0-9-]{0,30}$")]
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
        [Required]
        public int Places//Количество мест в самолёте
        {
            get { return places; }
            set { places = value; }
        }

        private int issueYear;
        [Required]
        [Range(1900,2017)]
        public int IssueYear//Год производства
        {
            get { return issueYear; }
            set { issueYear = value; }
        }

        private int carrying;
        [Required]
        [Range(500,999999)]
        public int Carrying//Грузоподъёмность
        {
            get { return carrying; }
            set { carrying = value; }
        }

        private string lastService;
        [Required]
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
