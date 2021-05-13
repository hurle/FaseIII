using Fase_III_SERAJ.Resources.Models;
using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para Create.xaml
    /// </summary>
    public partial class Create : Page
    {
        Student student;

        public Create()
        {
            InitializeComponent();
            student = new Student();
            this.DataContext = student;
        }

        private void button_cancel_Click(object sender, RoutedEventArgs e)
        {
            student.Clear();
        }

        private void button_save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                student.DateOfBirth = DatePicker_dateofBird.SelectedDate;
                student.Valid();
                MessageBox.Show("Se creo con exito el nuevo registro!");
                student.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
