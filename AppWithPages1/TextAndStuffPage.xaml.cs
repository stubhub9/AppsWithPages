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

namespace AppWithPages1
{
    /// <summary>
    /// Interaction logic for TextAndStuffPage.xaml
    /// </summary>
    public partial class TextAndStuffPage : Page
    {
        public TextAndStuffPage()
        {
            InitializeComponent();
        }








        public void TextBlocks1 ()
        {
            TextBlock textBlock1 = new TextBlock ();
            TextBlock textBlock2 = new TextBlock ();

            textBlock1.TextWrapping = textBlock2.TextWrapping = TextWrapping.Wrap;
            textBlock2.Background = Brushes.AntiqueWhite;
            textBlock2.TextAlignment = TextAlignment.Center;

            textBlock1.Inlines.Add ( new Bold ( new Run ( "TextBlock  A TextBlock can contain a string in its Text property or Inline flow content elements, such as Bold, Hyperlink, and InlineUIContainer, in its Inlines property." ) ) );
            textBlock1.Inlines.Add ( new Run ( " is designed to be " ) );
            textBlock1.Inlines.Add ( new Italic ( new Run ( "lightweight" ) ) );
            textBlock1.Inlines.Add ( new Run ( ", and is geared specifically at integrating " ) );
            textBlock1.Inlines.Add ( new Italic ( new Run ( "small" ) ) );
            textBlock1.Inlines.Add ( new Run ( " portions of flow content into a UI." ) );

            textBlock2.Text =
                "By default, a TextBlock provides no UI beyond simply displaying its contents." +
                "After TextBlock, FlowDocumentScrollViewer is the next lightest-weight control for displaying flow content, and simply provides a scrolling content area with minimal UI. FlowDocumentPageViewer is optimized around \"page-at-a-time\" viewing mode for flow content. Finally, FlowDocumentReader supports the richest set functionality for viewing flow content, but is correspondingly heavier-weight.";
        }


    }
}
