using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XF_HarmonicInterfaces.Models
{
    public class Session : INotifyPropertyChanged
    {
        private Guid _id_Session;
        private string _name_Session;
        private string _image_Session;

        public Guid Id_Session
        {
            get => _id_Session;
            set {
                _id_Session = value;
                RaisePropertyChanged(nameof(Id_Session));
            }
        }

        public string Name_Session
        {
            get => _name_Session;
            set
            {
                _name_Session = value;
                RaisePropertyChanged(nameof(Name_Session));
            }
        }

        public string Image_Session
        {
            get => _image_Session;
            set
            {
                _image_Session = value;
                RaisePropertyChanged(nameof(Image_Session));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
