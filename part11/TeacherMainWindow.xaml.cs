using part11.Pages;
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
using System.Windows.Shapes;

namespace part11
{
    /// <summary>
    /// Interaction logic for TeacherMainWindow.xaml
    /// </summary>
    public partial class TeacherMainWindow : Window
    {
        public TeacherMainWindow()
        {
            InitializeComponent();

            MainFrame.Navigate(new TeacherHomePage());
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }

        }

        // window maximus and normalize
        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximized = true;
                }
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

        

        private void NavigateToCoursesPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CoursesPage());
        }

        private void NavigateToTeacherPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TeachersPage());
        }
        private void NavigateToTeacherHomePage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TeacherHomePage());
        }

        private void NavigateToMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            obj.Show();
            this.Hide();
        }
    }
}
