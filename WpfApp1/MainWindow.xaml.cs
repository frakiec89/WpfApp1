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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Capcha capcha = new Capcha();

        public MainWindow()
        {
            InitializeComponent();


            lb.Content = capcha.Name;
         
            this.Loaded += MainWindow_Loaded;

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
                canvas1.Children.Add(NewLine(random)); ;
        }

        private  Line NewLine(Random random)
        {

            if (random.Next(0, 1) == 0)
            {

                return new Line
                {
                    HorizontalAlignment = HorizontalAlignment.Center,

                    X1 = 0,
                    Y1 = canvas1.ActualWidth- random.Next(0, (int)canvas1.ActualWidth),
                    X2 = (int)canvas1.ActualWidth,
                    Y2 = random.Next(0, (int)canvas1.ActualWidth),
                   

                    StrokeThickness = random.Next(0, 3),


                    Stroke =  new SolidColorBrush(new Color { A= (byte) random.Next(0, 255) , 
                        B = (byte)random.Next(0, 255) ,   G= (byte)random.Next(0, 255), R = (byte)random.Next(0, 255) }  )

                };
            }
            else
            {
                return new Line
                {
                    HorizontalAlignment = HorizontalAlignment.Center,

                    X1 =  (int)canvas1.ActualWidth,
                    Y1 = (int)canvas1.ActualWidth - random.Next(10, (int)canvas1.ActualWidth),
                    X2 = 0,
                    Y2 = random.Next(10, (int)canvas1.ActualWidth),

                    StrokeThickness = random.Next(0, 3),
                    Stroke = Brushes.Black,
                };
            }
        }

        private void btGo_Click(object sender, RoutedEventArgs e)
        {
            if (tbGo.Text == capcha.Name)
            {
                MessageBox.Show("Ok");
            }
            else
            {
                MessageBox.Show("No");
            }
        }
    }
}
