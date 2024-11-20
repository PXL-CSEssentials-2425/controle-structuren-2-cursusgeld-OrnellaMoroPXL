using System.Windows;

namespace cursusgeldOEF
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

        int inputJaar;

        // enable calculateButton als je een getal hebt ingegeven 18/11
        private void TestButton_Click(object sender, RoutedEventArgs e)
        {

            bool isNumeriek = int.TryParse(jaarTextBox.Text, out inputJaar);

            if (isNumeriek)
            {
                numeriekTextBlock.Text = "Is numeriek!";
                calculateButton.IsEnabled = true;
            }
            else
            {
                numeriekTextBlock.Text = "geef een correct jaartal";
                calculateButton.IsEnabled = false;
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {

            bool isNumeriek = int.TryParse(jaarTextBox.Text, out inputJaar); // dit moet er ook bij for some reason.
            double inputLesuren = double.Parse(qLesUrenTextBox.Text);
            double resultaat = inputLesuren * 1.5;

            if (isNumeriek)
            {

                if ((inputJaar % 4 == 0 && inputJaar != 100) || (inputJaar % 400 == 0))
                {
                    resultTextBlock.Text = "is een schrikkeljaar";
                    inschrijfGeldTextBox.Text = $"{resultaat + 1.5}";
                }
                else
                {
                    resultTextBlock.Text = "is geen schrikkeljaar";
                    inschrijfGeldTextBox.Text = resultaat.ToString();
                }


            }
        }

        // sluit applicatie 18/11
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
