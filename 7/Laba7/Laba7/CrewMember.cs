using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7
{
    public class CrewMember
    {

        public CrewMember() { }
        public CrewMember(
            string f, string s, string p,
            string po, int a, int e
                          )
        {
            Firstname = f;
            Surname = s;
            Patronymic = p;
            Post = po;
            Age = a;
            Experience = e;
        }
        private string firstname, surname, patronymic;
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        private string post;
        public string Post
        {
            get { return post; }
            set { post = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int experience;
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

       
    }
}
