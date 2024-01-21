using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AnimeDesktop.Base
{
    public class NotifyPropertyChangeHandler: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
