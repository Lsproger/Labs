using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required]
        [StringLength(20, MinimumLength =1,ErrorMessage ="Name must be between 1 and 20 symbols length!")]
        [RegularExpression(@"^[A-Z][a-zA-Z0-9-_\.]{1,20}$")]
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must be between 2 and 20 symbols length!")]
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
        [Required]

        public string Post
        {
            get { return post; }
            set { post = value; }
        }
        private int age;
        [Required]
        [Range(18,99,ErrorMessage ="Age must be in 18-99 range!")]
        [RegularExpression(@"^[1-9][0-9]{1}")]
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private int experience;
        [Required]
        [Range(0, 81, ErrorMessage = "Age must be in 0-81 range!")]
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

       
    }
}
