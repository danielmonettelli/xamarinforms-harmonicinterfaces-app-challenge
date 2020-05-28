using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XF_HarmonicInterfaces.Models
{
    public class Exercise : INotifyPropertyChanged
    {

        private Guid _id_Exercise;
        private string _name_Exercise;
        private string _image_Exercise;
        private string _duration_Exercise;
        private string _description_Exercise;

        public Guid Id_Exercise
        {
            get => _id_Exercise;
            set
            {
                _id_Exercise = value;
                RaisePropertyChanged(nameof(Id_Exercise));
            }
        }

        public string Name_Exercise
        {
            get => _name_Exercise;
            set
            {
                _name_Exercise = value;
                RaisePropertyChanged(nameof(Name_Exercise));
            }
        }

        public string Image_Exercise
        {
            get => _image_Exercise;
            set
            {
                _image_Exercise = value;
                RaisePropertyChanged(nameof(Image_Exercise));
            }
        }

        public string Duration_Exercise
        {
            get => _duration_Exercise;
            set
            {
                _duration_Exercise = value;
                RaisePropertyChanged(nameof(Duration_Exercise));
            }
        }

        public string Description_Exercise
        {
            get => _description_Exercise;
            set
            {
                _description_Exercise = value;
                RaisePropertyChanged(nameof(Description_Exercise));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
