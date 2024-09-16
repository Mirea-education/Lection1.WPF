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
using WpfAppLecture1.ClassApp;
using WpfAppLecture1.PagesApp;
using WpfAppLecture1.WindowsApp;

namespace WpfAppLecture1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            ClassNav.frmContent = FrmMainContent;
            FrmMainContent.Navigate(new PageMain());
        }

        private void BtnAboutOf_Click(object sender, RoutedEventArgs e)
        {
            new WindowsAbout().Show();
        }
    }
}
