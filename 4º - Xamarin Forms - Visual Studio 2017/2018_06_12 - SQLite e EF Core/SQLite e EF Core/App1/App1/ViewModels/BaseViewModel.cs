using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App1.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public bool IsBusy { get; set; } = false;
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;
            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
