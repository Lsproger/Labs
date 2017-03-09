using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4
{
    public partial class Form1 : Form
    {
        List<CollectionType<Box>> listOfColl = new List<CollectionType<Box>>();
        List<CollectionType<Box>> Sorted_list;
        Random R = new Random();
        private void print(List<CollectionType<Box>> lst)
        {
            textBox1.Clear();
            List<string> tmpList = new List<string>();
            for (int i = 0; i < lst.Count; i++)
            {
                tmpList.Add("Collection #" + lst[i].id);
                for (int j = 0; j < lst[i].Count; j++)
                {
                    tmpList.Add((j + 1) + ". " + lst[i][j].ToString());
                }
            }
            textBox1.Lines = tmpList.ToArray();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)      //Генерация
        {
            listOfColl.Clear();
            CollectionType<Box>.numOfCol = 1;
            int elemInList = R.Next(5, 10);
            for (int i=0; i < elemInList; i++)
            {
                int elemInColl = R.Next(5, 8);
                CollectionType<Box> collect = new CollectionType<Box>();
                for (int j = 0 ; j < elemInColl; j++)
                {
                    collect.Add(new Box(R.Next(-5, 20), R.Next(1, 25), R.Next(1, 15)));
                }
                listOfColl.Add(collect);
            }
            print(listOfColl);
        }

        private void button2_Click(object sender, EventArgs e)          //Только положительные элементы
        {
            textBox1.Clear();
              List<CollectionType<Box>> tmp = new List<CollectionType<Box>>();
              for (int i = 0; i < listOfColl.Count; i++)
              {
                  int test = 0;
                  for (int j=0; j < listOfColl[i].Count; j++)
                  {
                      if (listOfColl[i][j].Volume <= 0) test++;
                  }
                  if (test == 0)
                  {
                      tmp.Add(listOfColl[i]);
                  }
              }
            print(tmp);
        }

        private void button3_Click(object sender, EventArgs e)      //Максимальный объект в массиве
        {
             int sumVol;
             int tmpVol=0;
             int ind=0;
             for (int i = 0; i < listOfColl.Count; i++)
             {
                 sumVol = 0;
                 for (int j = 0; j < listOfColl[i].Count; j++)
                 {
                     sumVol += listOfColl[i][j].Volume;
                 }
                 if (tmpVol < sumVol)
                 {
                     ind = i;
                     tmpVol = sumVol;
                 }
             }               
            MessageBox.Show("Коллекция с наибольшим общим объёмом:\n" + listOfColl[ind].ToString());
        }

        private void button4_Click(object sender, EventArgs e)  //Будем смотреть по количеству элементов в коллекции
        {
            
            for (int i = 0; i < Sorted_list.Count - 1; i++)
            {
                for (int j = i+1; j < Sorted_list.Count; j++)
                    if (Sorted_list[i].Count == Sorted_list[j].Count)
                    {
                        Sorted_list.RemoveAt(i+1);
                        j--;
                    }
            }
            print(Sorted_list);
        }


        private void button5_Click(object sender, EventArgs e) //Сортирует, но не выводит
        {
            Sorted_list = new List<CollectionType<Box>>(listOfColl.OrderBy(i => i.Count));
        }

        private void button6_Click(object sender, EventArgs e) //Выводит отсортированный список
        {
            print(Sorted_list);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SortedSet<string> ST = new SortedSet<string>();
            List<string> sti = new List<string>();
            int kol = R.Next(5, 10);
            int x;
            string stri = "";
            string[] stre = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
            for (int i = 0; i < kol; i++)
            {
                x = R.Next(0, 9);
                ST.Add(stre[x]);
                stri+= stre[x] + "\n"; 
            }
            MessageBox.Show(stri);
            textBox1.Lines = ST.ToArray();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            string[] stri = { "Lolkek" };

            textBox1.Lines = stri;
        }
    }
}
