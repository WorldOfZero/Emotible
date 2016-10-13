using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Emotible.ViewModels
{
    public class WrapGridViewModel : INotifyPropertyChanged
    {
        private int numberOfColumns = 2;
        private double itemWidth = 150;

        public int NumberOfColumns
        {
            get { return numberOfColumns; }
            set
            {
                if (numberOfColumns != value)
                {
                    numberOfColumns = value;
                    OnPropertyChanged();
                }
            }
        }

        public double ItemWidth
        {
            get
            {
                return itemWidth;
            }
            set
            {
                if (itemWidth != value)
                {
                    itemWidth = value;
                    OnPropertyChanged();
                }
            }
        }

        private double controlWidth = 300;
        public double ControlItemWidth
        {
            get { return controlWidth; }
            set
            {
                if (controlWidth != value)
                {
                    ItemWidth = value/NumberOfColumns;
                    controlWidth = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
