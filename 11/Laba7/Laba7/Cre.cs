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
    public partial class Cre : Form
    {
        public Cre()
        {
            InitializeComponent();
        }

        private void Cre_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airportDataSet1.Crewmembers". При необходимости она может быть перемещена или удалена.
            this.crewmembersTableAdapter.Fill(this.airportDataSet1.Crewmembers);

        }
    }
}
