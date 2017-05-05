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
        List<string> posts = new List<string> { "Капитан", "Второй пилот", "Стюард(-есса)", "BIG RUSSIAN BOSS", "Просто парень", "Кто я?" };
        int plId;
        public FAddCrewMember(int PlaneId)
        {
            plId = PlaneId;
            InitializeComponent();
            foreach (var el in posts)
            {
                _post.Items.Add(el);
            }
            _post.SelectedIndex = 0;
        }

        private void _add_Click(object sender, EventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                Crewmember cm = new Crewmember
                {
                    Name = _name.Text,
                    Age = Convert.ToInt32(_age.Text),
                    Experience = Convert.ToInt32(_experience.Text),
                    Post = Convert.ToString(_post.Items[_post.SelectedIndex]),
                    Planeid = plId
                };
                db.Crewmembers.Add(cm);
                db.SaveChanges();
            }
            _name.Clear();
            _age.Clear();
            _experience.Clear();
            _post.SelectedIndex = 0;
        }

        private void _close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
