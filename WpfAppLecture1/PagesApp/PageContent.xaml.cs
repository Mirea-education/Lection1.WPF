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

namespace WpfAppLecture1.PagesApp
{
    /// <summary>
    /// Логика взаимодействия для PageContent.xaml
    /// </summary>
    public partial class PageContent : Page
    {
        public PageContent()
        {
            InitializeComponent();

            GridListUser.ItemsSource = ClassConnect.MIREAEntities.User.ToList();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ClassNav.frmContent.GoBack();
        }
    }
}
