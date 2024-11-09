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

namespace AppWithPages1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent ();
        }

        private void Button_Click ( object sender, RoutedEventArgs e )
        {
            Button button1 = sender as Button;

            TextBlock textBlock1 = button1.Content as TextBlock;

            string text1 = textBlock1.Text;

            text1 = text1 + ".xaml";

            frameMain.NavigationService.Navigate (
                new Uri ( "SimplestPage", UriKind.Relative ) );
            //frameMain.NavigationService.Navigate (
            //    new Uri ( text1, UriKind.Relative ) );


            //sender as TextBlock
            //string pageName =
        }


        /*
         * Extension method must be defined in a non-generic static class
         * Generates an error as a Window method, separate class, 
         * 
        private static T GetChildOfType1<T> ( this DependencyObject depObj )
        {
            return null;
        }
        */


    }
}