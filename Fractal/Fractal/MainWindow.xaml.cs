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

namespace Fractal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Field.Children.Clear();
            Draw(Int32.Parse(NumberCount.Text));
        }

        private void Draw(int count)
        {
            int x1, y1, x2, y2;

            x1 = 200;
            y1 = 200;
            x2 = 390;
            y2 = 200;

            DragonFunction(x1, y1, x2, y2, count);
        }

        private void DragonFunction(int x1, int y1, int x2, int y2, int n)
        {
            int dx, dy;

            if (n > 0)
            {
                dx = (x1 + x2) / 2 + (y2 - y1) / 2;
                dy = (y1 + y2) / 2 - (x2 - x1) / 2;

                DragonFunction(x2, y2, dx, dy, n - 1);
                DragonFunction(x1, y1, dx, dy, n - 1);
            }

            if (n == 0)
            {
                Line line = new Line();
                line.Stroke = Brushes.Red;
                line.StrokeThickness = 2;
                line.X1 = x1;
                line.Y1 = y1;
                line.X2 = x2;
                line.Y2 = y2;
                Field.Children.Add(line);
            }
            
        }
    }
}
