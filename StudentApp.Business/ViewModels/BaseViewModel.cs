using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Business.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {

        }

        protected bool SetProperty<T>(ref T backingstore, T value,
            [CallerMemberName] string propertyName = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingstore, value))
                return false;

            backingstore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changes = PropertyChanged;
            if (changes == null)
            {
                return;
            }

            changes.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
