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
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userInfo = ClassConnect.MIREAEntities.User.FirstOrDefault(
                    x =>
                        x.Login == TxbLogin.Text && x.Password == PsbPass.Password
                    );
                if (userInfo != null)
                {
                    switch (userInfo.RoleId)
                    {
                        case 1: ClassNav.frmContent.Navigate(new PageContent());
                            break;
                        case 2: MessageBox.Show($"Вы авторизуетесь под ролью {userInfo.Role.Name}");
                            break;
                        default: break;
                    }
                }


                //if (TxbLogin.Text == "123" && PsbPass.Password == "123")
                //{
                //    ClassNav.frmContent.Navigate(new PageContent());
                //}
                //else
                //{
                //    MessageBox.Show("Пароль неверный!");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
