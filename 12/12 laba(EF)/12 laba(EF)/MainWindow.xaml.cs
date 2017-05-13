using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel; // CancelEventArgs // TextChangedEventArgs
using Microsoft.Win32;

namespace _12_laba_EF_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EFRep<Superteam> mRep = new EFRep<Superteam>(new MyDbContext());
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            TeamsGrid.MouseDoubleClick += TeamsGrid_MouseDoubleClick;
        }

        private void TeamsGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            HeroesView hv = new HeroesView((TeamsGrid.SelectedItem as Superteam).TeamName);
            hv.Show();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            TeamsGrid.ItemsSource = mRep.GetToBinding();
            TeamsGrid.Columns.First().IsReadOnly = true;
        }

        private void AddTeam_Click(object sender, RoutedEventArgs e)
        {
            Superteam st = new Superteam { TeamName = TeamName.Text, TColor = TeamColor.Text };
            mRep.Create(st);

        }

        private void DeleteT_Click(object sender, RoutedEventArgs e)
        {
            mRep.Remove(TeamsGrid.SelectedValue as Superteam);
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            foreach (object obj in TeamsGrid.Items)
                mRep.Update(obj as Superteam);
            MessageBox.Show("All fields are updated");
        }

        private void _tr_Click(object sender, RoutedEventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        Superteam p1 = db.Superteams.FirstOrDefault(); // ..... 
                        MessageBox.Show(p1.ToString());
                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }
            }
        }

        private void _sql_Click(object sender, RoutedEventArgs e)
        {
            using (MyDbContext db = new MyDbContext())
            {
                string n = (TeamsGrid.SelectedValue as Superteam).TeamName;
                var st =
                    from p in db.Superteams
                    where p.TeamName == n
                    select p;
                foreach (object obj in st)
                {
                    MessageBox.Show((obj as Superteam).TeamName);
                }
            }
        }
    }
}
