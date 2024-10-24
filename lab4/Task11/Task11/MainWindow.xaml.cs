using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task11
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DrawCircles();
        }

        private void DrawCircles()
        {
            CircleCanvas.Children.Clear();

            double centerX = CircleCanvas.ActualWidth / 2;
            double centerY = CircleCanvas.ActualHeight / 2;

            double[] radii = { 150, 100, 50 };
            Brush[] colors = { Brushes.Red, Brushes.Green, Brushes.Blue };

            for (int i = 0; i < radii.Length; i++)
            {
                Ellipse circle = new Ellipse
                {
                    Width = radii[i] * 2,
                    Height = radii[i] * 2,
                    Fill = colors[i]
                };

                Canvas.SetLeft(circle, centerX - radii[i]);
                Canvas.SetTop(circle, centerY - radii[i]);

                CircleCanvas.Children.Add(circle);
            }
        }
    }
}