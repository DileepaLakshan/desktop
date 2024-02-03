using part11.Pages;
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

namespace part11
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            CreateAccountWindow obj = new CreateAccountWindow();
            obj.Show();
            this.Hide();
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserText.Text == "" || PasswordText.Password == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (UserText.Text == "dileepa" && PasswordText.Password == "12345")
            {

            }
            else if (UserText.Text == "umodha" && PasswordText.Password == "54321")
            {
                TeacherMainWindow obj = new TeacherMainWindow();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User name and Password are not corrrect");
            }
        }


        private void minimizeButoon_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseButton_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        

    }


    
}