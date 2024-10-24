using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawCircle_Click(object sender, RoutedEventArgs e)
        {
            CircleCanvas.Children.Clear();

            if (double.TryParse(RadiusInput.Text, out double radius) && radius > 0)
            {
                Ellipse circle = new Ellipse
                {
                    Width = radius * 2,
                    Height = radius * 2,
                    Fill = Brushes.Blue
                };

                Canvas.SetLeft(circle, (CircleCanvas.Width - circle.Width) / 2);
                Canvas.SetTop(circle, (CircleCanvas.Height - circle.Height) / 2);

                CircleCanvas.Children.Add(circle);
            }
            else
            {
                MessageBox.Show("Please enter a valid positive radius.", "Invalid Input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RadiusInput_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RadiusInput.Text == "Enter radius")
            {
                RadiusInput.Text = string.Empty;
                RadiusInput.Foreground = Brushes.Black;
            }
        }

        private void RadiusInput_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RadiusInput.Text))
            {
                RadiusInput.Text = "Enter radius";
                RadiusInput.Foreground = Brushes.Gray;
            }
        }
    }
}