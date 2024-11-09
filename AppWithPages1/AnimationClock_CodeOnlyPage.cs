using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace AppWithPages1
{
    class AnimationClock_CodeOnlyPage : Page
    {


        ScaleTransform myScaleTransform;

        public void AnimationClockExample ()
        //public AnimationClockExample ()
        {

            this.WindowTitle = "Opacity Animation Example";
            this.Background = Brushes.White;
            StackPanel myStackPanel = new StackPanel ();
            myStackPanel.Margin = new Thickness ( 20 );

            // Create a button that with a ScaleTransform.
            // The ScaleTransform will animate when the
            // button is clicked.
            Button myButton = new Button ();
            myButton.Margin = new Thickness ( 50 );
            myButton.HorizontalAlignment = HorizontalAlignment.Left;
            myButton.Content = "Click Me";
            myScaleTransform = new ScaleTransform ( 1, 1 );
            myButton.RenderTransform = myScaleTransform;

            // Associate an event handler with the
            // button's Click event.
            myButton.Click += new RoutedEventHandler ( myButton_Clicked );

            myStackPanel.Children.Add ( myButton );
            this.Content = myStackPanel;
        }

        // Create and apply and animation when the button is clicked.
        private void myButton_Clicked ( object sender, RoutedEventArgs e )
        {

            // Create a DoubleAnimation to animate the
            // ScaleTransform.
            DoubleAnimation myAnimation =
                new DoubleAnimation (
                    1, // "From" value
                    5, // "To" value
                    new Duration ( TimeSpan.FromSeconds ( 5 ) )
                );
            myAnimation.AutoReverse = true;

            // Create a clock the for the animation.
            AnimationClock myClock = myAnimation.CreateClock ();

            // Associate the clock the ScaleX and
            // ScaleY properties of the button's
            // ScaleTransform.
            myScaleTransform.ApplyAnimationClock (
                ScaleTransform.ScaleXProperty, myClock );
            myScaleTransform.ApplyAnimationClock (
                ScaleTransform.ScaleYProperty, myClock );
        }


    }
}
