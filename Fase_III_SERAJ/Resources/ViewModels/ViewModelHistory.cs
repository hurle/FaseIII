using Fase_III_SERAJ.Resources.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Media;

namespace Fase_III_SERAJ.Resources.ViewModels
{
    class ViewModelHistory : INotifyPropertyChanged
    {
        private ObservableCollection<Student_ToGrid> _listStudent;
        public ObservableCollection<Student_ToGrid> listStudent
        {
            get { return _listStudent; }
            set
            {
                if (value != _listStudent)
                {
                    _listStudent = value;
                    OnPropertyChanged("listStudent");
                }
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ViewModelHistory() 
        {
            listStudent = new ObservableCollection<Student_ToGrid>();
            int f = 0;
            while (f < 50)
            {
                listStudent.Add(new Student_ToGrid()
                {
                    Address = "Direccion " + f.ToString(),
                    DateOfBirth = DateTime.Now,
                    IdSERAJ = f.ToString(),
                    Name = "Nombre" + f.ToString(),
                    Program = "Programa" + f.ToString(),
                    StudyDegree = "Grado de estudios" + f.ToString(),
                    DateOfBird_ToGrid = DateTime.Now.ToString()
                });
                f++;
            }
        }
    }

    public class Student_ToGrid : Student
    {
        private string _DateOfBird_ToGrid;
        public string DateOfBird_ToGrid 
        {
            get { return _DateOfBird_ToGrid; }
            set
            {
                if (value != _DateOfBird_ToGrid)
                {
                    _DateOfBird_ToGrid = value.ToString();
                    OnPropertyChanged("DateOfBird_ToGrid");
                }
            }
        }
    }
}
