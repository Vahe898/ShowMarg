using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShowMarg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Background = Brushes.LightBlue;
        }
        
        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Get the mouse position relative to the margin
            Point position = e.GetPosition((IInputElement)chess);

            // Display the coordinates
            //MessageBox.Show($"Mouse clicked at X: {position.X}, Y: {position.Y} in the margin.");
            PointInMarge ClickOnCHessBord = new PointInMarge(position.X-100, position.Y-250);
            //if(ClickOnCHessBord.X % 25 == ClickOnCHessBord.X)
            //{
            //    ClickOnCHessBord.X = 25;
            //}
            //else if (ClickOnCHessBord.X % 25 > 0)
            //{
            //    ClickOnCHessBord.X = ClickOnCHessBord.X - ClickOnCHessBord.X % 25;
            //}
            //if (ClickOnCHessBord.Y % 25 == ClickOnCHessBord.Y)
            //{
            //    ClickOnCHessBord.Y = 25;
            //}
            //else if (ClickOnCHessBord.Y % 25 > 0)
            //{
            //    ClickOnCHessBord.Y = ClickOnCHessBord.Y - ClickOnCHessBord.Y % 25;
            //}

            if(ClickOnCHessBord.X%50 > 0)
            {
                ClickOnCHessBord.X = (2*(ClickOnCHessBord.X - ClickOnCHessBord.X % 50) + 50)/2;
            }
            if (ClickOnCHessBord.Y % 50 > 0)
            {
                ClickOnCHessBord.Y = (2 * (ClickOnCHessBord.Y - ClickOnCHessBord.Y % 50) + 50) / 2;
            }

            xName.Text = (ClickOnCHessBord.X).ToString();
            yName.Text = (ClickOnCHessBord.Y).ToString();

        }

    }
}