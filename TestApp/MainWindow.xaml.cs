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

namespace TestApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            Button clicked = (Button)sender;
            //ComboBox foundTextBox = UIHelper.FindChild<TextBox>(Application.Current.MainWindow, "myTextBoxName");

            var myCombo = (ComboBox)this.FindName("myComboBox");
            var myLabel = (Label)this.FindName("myLabel");
            if (myCombo.SelectedValue.ToString() == "English")
            {
                myLabel.Content = "Hello World";
            }
            else
            {
                myLabel.Content = "Hola Mundo";
                //myLabel.Content = myCombo.SelectedValue.ToString();
            }
        }
    }
}
