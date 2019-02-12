using System.Globalization;
using System.Windows;
using WPFLocalizeExtension.Engine;

namespace MultiLangTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            counter++;

            if (counter % 3 == 1)
            {
                //LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
                LocalizeDictionary.Instance.Culture = new CultureInfo("ja-JP");
            }
            else if (counter % 3 == 2)
            {
                //LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
                LocalizeDictionary.Instance.Culture = new CultureInfo("ko-KR");
            }
            else
            {
                //LocalizeDictionary.Instance.SetCurrentThreadCulture = true;
                LocalizeDictionary.Instance.Culture = new CultureInfo("en");

            }
        }
    }
}
