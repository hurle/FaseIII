using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Fase_III_SERAJ.Resources.Models
{
    public class Student : INotifyPropertyChanged
    {
        private string _Name { get; set; }
        private DateTime? _DateOfBirth { get; set; }
        private string _IdSERAJ { get; set; }
        private string _Address { get; set; }
        private string _StudyDegree { get; set; }
        private string _Program { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Name
        {
            get { return _Name; }
            set
            {
                if (value != _Name)
                {
                    _Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }
        public DateTime? DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {
                if (value != _DateOfBirth)
                {
                    _DateOfBirth = value;
                    OnPropertyChanged("DateOfBirth");
                }
            }
        }
        public string IdSERAJ {
            get { return _IdSERAJ; }
            set
            {
                if (value != _IdSERAJ)
                {
                    _IdSERAJ = value;
                    OnPropertyChanged("IdSERAJ");
                }
            }
        }
        public string Address {
            get { return _Address; }
            set
            {
                if (value != _Address)
                {
                    _Address = value;
                    OnPropertyChanged("Address");
                }
            }
        }
        public string StudyDegree {
            get { return _StudyDegree; }
            set
            {
                if (value != _StudyDegree)
                {
                    _StudyDegree = value;
                    OnPropertyChanged("StudyDegree");
                }
            }
        }
        public string Program {
            get { return _Program; }
            set
            {
                if (value != _Program)
                {
                    _Program = value;
                    OnPropertyChanged("Program");
                }
            }
        }

        public void Valid()
        {
            if (String.IsNullOrEmpty(Name))
                throw new Exception("Se debe ingresar un nombre");
            if (DateOfBirth == null)
                throw new Exception("Se debe ingresar una fecha de nacimiento");
            if (String.IsNullOrEmpty(IdSERAJ))
                throw new Exception("Se debe ingresar una matricula correcta");
            if (String.IsNullOrEmpty(Address))
                throw new Exception("Se debe ingresar una direccion");
            if (String.IsNullOrEmpty(StudyDegree))
                throw new Exception("Se debe ingresar un grado de estudios");
            if (String.IsNullOrEmpty(Program))
                throw new Exception("Se debe ingresar el nombre del programa donde se registra");
        }

        public void Clear() 
        {
            Name = "";
            DateOfBirth = null;
            IdSERAJ = "";
            Address = "";
            StudyDegree = "";
            Program = "";
        }
    }
}
