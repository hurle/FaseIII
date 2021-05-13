﻿using System;
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
            if ((sender as TextBox).Text == "Usuario" || (sender as TextBox).Text == "Contraseña")
            {
                (sender as TextBox).Text = "";
            }
            else if ((sender as TextBox).Text == "") 
            {
                if((sender as TextBox).Name == "textbox_user")
                    (sender as TextBox).Text = "Usuario";
                if ((sender as TextBox).Name == "textbox_password")
                    (sender as TextBox).Text = "Password";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (!String.IsNullOrWhiteSpace(textbox_user.Text) && !String.IsNullOrWhiteSpace(textbox_password.Password))
            {
                Frame_Content.Content = Page_wellcome;
                Grid_Content.Visibility = Visibility.Visible;
                Grid_Login.Visibility = Visibility.Collapsed;
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
    }
}
