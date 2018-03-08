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
using System.IO;

namespace WPF_asjad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string fail = @"'c:\..\Nimed.txt";
            List<Inimesed> inimesed = new List<Inimesed>();
            foreach (var item in inimesed)
            {
                inimesed =
            }
           

            foreach (var line in fail)
            {
                string[] boi = fail.Split(' ');
                Inimesed newInimesed = new Inimesed();
                newInimesed.Eesnimi = boi[0];
                //newInimesed.Perekonnanimi = boi[1];

            }
            inimesed.Add(new Inimesed() { Eesnimi = ""});

            Listboxy.ItemsSource = inimesed;



            
        }



        public class Inimesed
        {
            public string Eesnimi { get; set; }
            public string Perekonnanimi { get; set; }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Listboxy.SelectedItem != null)
            {
                Title = (Listboxy.SelectedItem as Inimesed).Eesnimi;
                //Title = (Listboxy.SelectedItem as Inimesed).Perekonnanimi;
            }

        }
    }
}
