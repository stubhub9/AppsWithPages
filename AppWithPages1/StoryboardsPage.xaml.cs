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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppWithPages1
{
    /// <summary>
    /// Interaction logic for StoryboardsPage.xaml
    /// </summary>
    public partial class StoryboardsPage : Page
    {
        public StoryboardsPage()
        {
            InitializeComponent();
            StoryboardsExample ();
        }

        /// <summary>
        /// Replaces the XAML only page content, with a Code Only StackPanel.
        /// </summary>
        public void StoryboardsExample ()
        {
            this.WindowTitle = "Storyboards Example";
            StackPanel myStackPanel = new StackPanel ();
            myStackPanel.Margin = new Thickness ( 20 );

            Rectangle myRectangle = new Rectangle ();
            myRectangle.Name = "MyRectangle";

            // Create a name scope for the page.
            NameScope.SetNameScope ( this, new NameScope () );

            this.RegisterName ( myRectangle.Name, myRectangle );
            myRectangle.Width = 100;
            myRectangle.Height = 100;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush ( Colors.Blue );
            this.RegisterName ( "MySolidColorBrush", mySolidColorBrush );
            myRectangle.Fill = mySolidColorBrush;

            DoubleAnimation myDoubleAnimation = new DoubleAnimation ();
            myDoubleAnimation.From = 100;
            myDoubleAnimation.To = 200;
            myDoubleAnimation.Duration = new Duration ( TimeSpan.FromSeconds ( 1 ) );
            Storyboard.SetTargetName ( myDoubleAnimation, myRectangle.Name );
            Storyboard.SetTargetProperty ( myDoubleAnimation,
                new PropertyPath ( Rectangle.WidthProperty ) );

            ColorAnimation myColorAnimation = new ColorAnimation ();
            myColorAnimation.From = Colors.Blue;
            myColorAnimation.To = Colors.Red;
            myColorAnimation.Duration = new Duration ( TimeSpan.FromSeconds ( 1 ) );
            Storyboard.SetTargetName ( myColorAnimation, "MySolidColorBrush" );
            Storyboard.SetTargetProperty ( myColorAnimation,
                new PropertyPath ( SolidColorBrush.ColorProperty ) );

            //  Create myStoryboard collection
            Storyboard myStoryboard = new Storyboard ();
            myStoryboard.Children.Add ( myDoubleAnimation );
            myStoryboard.Children.Add ( myColorAnimation );


            //  Apply Begin to an event handler
            myRectangle.MouseEnter += delegate ( object sender, MouseEventArgs e )
            {
                myStoryboard.Begin ( this );
            };



            myStackPanel.Children.Add ( myRectangle );
            this.Content = myStackPanel;
        }
    }
}
