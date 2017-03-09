using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSLaba3
{
    public partial class Form1 : Form
    {
        #region
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

#endregion

        private void button1_Click(object sender, EventArgs e)  //Кнопка "Attack"
        {
            Game.getInstance().Attack += Form1_HAttack;     //Подписал функцию Form_RAttack на событие Attack 
            Game.getInstance().HAttack();                   //(Оно генерируется при вызове метода RAttack в классе Game)
            if (Game.IsDestr() == true)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                if (Game.getInstance().queue%2 == 0)
                
                    MessageBox.Show("GAME IS OVER!!!\nRED TEAM WINS!!!");
                
                else MessageBox.Show("GAME IS OVER!!!\nGREEN TEAM WINS!!!");
            }
            
        }

        private void Form1_HAttack(object sender, EventArgs e) //Этот метод  вызывается при появлении события Attack
        {
            Game.getInstance().RePrint(this);
        }

        private void button6_Click(object sender, EventArgs e)      //Кнопка "Start"
        {
            Game.getInstance();
            Game.getInstance().RePrint(this);
        }

        private void button5_Click(object sender, EventArgs e)  //Кнопка "Clear"
        {
            for (int i =0; i < Game.getInstance().chat.Length; i++)
            {
                Game.getInstance().chat[i] = null;
            } 
            Game.getInstance().numbOfTerms = -1;
            textBox3.Lines = Game.getInstance().chat;
        }

        private void button2_Click(object sender, EventArgs e)  //Кнопка "Heal"
        {
            Game.getInstance().Healing += Form1_Healing;
            Game.getInstance().HHeal();
        }

        private void Form1_Healing(object sender, EventArgs e)
        {
            Game.getInstance().RePrint(this);
        }
    }
}
