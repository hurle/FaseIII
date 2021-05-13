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
using Fase_III_SERAJ.Resources.Modules;
using Fase_III_SERAJ.Resources.Modules.Alumnos;

namespace Fase_III_SERAJ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Wellcome Page_wellcome;
        public Create Page_create;
        public Edit Page_edit;
        public History Page_history;

        public MainWindow()
        {
            InitializeComponent();
            Page_wellcome = new Wellcome();
            Page_create = new Create();
            Page_edit = new Edit();
            Page_history = new History();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            try 
            {
                if ((sender as TextBox).Text == "Usuario")
                    (sender as TextBox).Text = "";
                else if ((sender as TextBox).Text == "")
                    (sender as TextBox).Text = "Usuario";
            }
            catch
            {
                if ((sender as PasswordBox).Password == "Contraseña")
                    (sender as PasswordBox).Password = "";
                else if ((sender as PasswordBox).Password == "")
                    (sender as PasswordBox).Password = "Password";
            }
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(textbox_user.Text) && !String.IsNullOrWhiteSpace(textbox_password.Password))
            {
                
            }
            else 
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void button_Inicio_Click(object sender, RoutedEventArgs e)
        {
            if (Frame_Content.Content == Page_wellcome)
                return;
            Frame_Content.Content = Page_wellcome;
        }

        private void button_Nuevo_Click(object sender, RoutedEventArgs e)
        {
            if (Frame_Content.Content == Page_create)
                return;
            Frame_Content.Content = Page_create;
        }

        private void button_Completos_Click(object sender, RoutedEventArgs e)
        {
            if (Page_history.CurrentPlace == "Done")
                return;
            Page_history.VerifyOrigin("Done");
            Frame_Content.Content = Page_history;
        }

        private void button_Pendientes_Click(object sender, RoutedEventArgs e)
        {
            if (Page_history.CurrentPlace == "Incomplete")
                return;
            Page_history.VerifyOrigin("Incomplete");
            Frame_Content.Content = Page_history;
        }

        private void button_login_Click(object sender, RoutedEventArgs e)
        {
            if (!Login(textbox_password.Password, textbox_user.Text))
                MessageBox.Show("El usuario o la contraseña son incorrectos.");
            else 
            {
                Frame_Content.Content = Page_wellcome;
                Grid_Content.Visibility = Visibility.Visible;
                Grid_Login.Visibility = Visibility.Collapsed;
            }
        }

        public bool Login(string password, string user) 
        {
            if (!String.IsNullOrWhiteSpace(password) && !String.IsNullOrWhiteSpace(user) &&
                textbox_user.Text != "Usuario" && textbox_password.Password != "Password")
                return true;
            else
                return false;
        }
    }
}
