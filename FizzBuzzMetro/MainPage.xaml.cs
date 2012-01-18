using Windows.UI.Xaml;
using FizzBuzzLogic;

namespace FizzBuzzMetro
{
    partial class MainPage
    {
        private FizzBuzzer fizzBuzzer = new FizzBuzzer();

        public MainPage()
        {
            InitializeComponent();
            this.TextOutput.Text = fizzBuzzer.Say();
        }

        ////仮
        //private int count = 1;
        private void ButtonSayNext_Click(object sender, RoutedEventArgs e)
        {
            ////仮
            //this.TextOutput.Text
            //    = string.Format("{0} - {1}", ++count, count);

            this.TextOutput.Text = fizzBuzzer.Say();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            // 通常、Metro ではこんなことはしない。
            Application.Current.Exit();
        }
    }
}
