using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    public class Airplane
    {
        public Airplane() { }
        public int crewNumb;
        private int id;
        public int Id
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
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string model;
        public string Model
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
        public int Places
        {
            get { return places; }
            set { places = value; }
        }

        private int issueYear;
        public int IssueYear
        {
            get { return issueYear; }
            set { issueYear = value; }
        }

        private int carrying;
        public int Carrying
        {
            get { return carrying; }
            set { carrying = value; }
        }

        private string lastService;
        public string LastService
        {
            get { return lastService; }
            set { lastService = value; }
        }

        public override string ToString()
        {
            string s;
            s = ("ID:"+Id+"; Type:" + Type + "; Model:" + Model + "; Places:" + Places + "; Carrying:" + Carrying); 
            return s;
        }
        // public Procreator procreator;
    }
}
