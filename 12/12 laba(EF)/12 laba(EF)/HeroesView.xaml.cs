using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _12_laba_EF_
{
    /// <summary>
    /// Логика взаимодействия для HeroesView.xaml
    /// </summary>
    public partial class HeroesView : Window
    {
        EFRep<Superhero> hRep = new EFRep<Superhero>(new MyDbContext());
        string _tName;
        public HeroesView(string teamName)
        {
            InitializeComponent();
            this.Loaded += HeroesView_Loaded;
            _tName = teamName;
        }

        private void HeroesView_Loaded(object sender, RoutedEventArgs e)
        {
            _heroesGrid.ItemsSource = hRep.GetToBindingWhere(p => p.TeamName == _tName);
            foreach (DataGridColumn col in _heroesGrid.Columns)
            {
                if (col.Header.ToString() == "Superteam") col.Visibility = Visibility.Hidden;
                if (col.Header.ToString() == "Superteams") col.Visibility = Visibility.Hidden;
            }
        }

        private void _add_Click(object sender, RoutedEventArgs e)
        {
            int _id=0;
            if (hRep.Get().Count() < 1) _id = 1;
            else if (hRep.FindById(hRep.Get().Count()) == null) _id = hRep.Get().Count();
            else
            {
                foreach (Superhero sup in hRep.Get())
                {
                    if (_id < sup.Id) _id = sup.Id + 1;
                }
            }
            Superhero sh = new Superhero
            {
                Name = _name.Text,
                Age = Convert.ToInt32(_age.Text),
                SuperMight = _superMight.Text,
                TeamName = _tName,
                Id = _id
            };
            hRep.Create(sh);
            
        }

        private void _delete_Click(object sender, RoutedEventArgs e)
        {
            hRep.Remove(_heroesGrid.SelectedValue as Superhero);
        }

        private void _update_Click(object sender, RoutedEventArgs e)
        {
            foreach (object obj in _heroesGrid.Items)
                hRep.Update(obj as Superhero);
            MessageBox.Show("All fields are updated");
        }

        private void _asSearch_Click(object sender, RoutedEventArgs e)
        {
            DisplayResult();
            DisplayResult();
        }

        private async void DisplayResult()
        {
            using (MyDbContext db = new MyDbContext())
            {
                Superhero s = await db.Superheroes.FindAsync(Convert.ToInt32(_idH.Text));
                Thread.Sleep(5000);
                MessageBox.Show(s.Name);
            }
        }
    }
}


//static async void DisplayResultAsync()
//{
//    int num = 5;

//    int result = await FactorialAsync(num);
//    Thread.Sleep(3000);
//    MessageBox.Show("Факториал числа " + num + " равен " + result);
//}

//static Task<int> FactorialAsync(int x)
//{
//    int result = 1;

//    return Task.Run(() =>
//    {
//        for (int i = 1; i <= x; i++)
//        {
//            result *= i;
//        }
//        return result;
//    });
//}