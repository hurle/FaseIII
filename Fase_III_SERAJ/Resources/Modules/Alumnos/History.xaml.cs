using Fase_III_SERAJ.Resources.Models;
using Fase_III_SERAJ.Resources.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Fase_III_SERAJ.Resources.Modules.Alumnos
{
    /// <summary>
    /// Lógica de interacción para History.xaml
    /// </summary>
    public partial class History : Page
    {
        private ViewModelHistory viewModel;
        public string CurrentPlace;
        public History()
        {
            InitializeComponent();
            CurrentPlace = "";
            viewModel = new ViewModelHistory();
            this.DataContext = viewModel;
        }

        public void VerifyOrigin(string origen)
        {
            switch (origen) 
            {
                case "":
                    GridBackground.Background = Brushes.Lavender;
                    LabelTitle.Content = "Bitacora";
                    break;
                case "Done":
                    GridBackground.Background = Brushes.CadetBlue;
                    LabelTitle.Content = "Terminados";
                    LabelTitle.Foreground = Brushes.White;
                    break;
                case "Incomplete":
                    GridBackground.Background = Brushes.IndianRed;
                    LabelTitle.Content = "Pendientes";
                    LabelTitle.Foreground = Brushes.White;
                    break;
            }
            GetStudentsBy(LabelTitle.Content as String);
        }

        private void GetStudentsBy(string Content) 
        {
            MessageBox.Show(Content);
            //viewModel.listStudent = //Obtener listado de base de datos
        }

    }
}
