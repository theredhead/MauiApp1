using System.ComponentModel;
using System.Runtime.CompilerServices;
using PropertyChangingEventArgs = System.ComponentModel.PropertyChangingEventArgs;
using PropertyChangingEventHandler = System.ComponentModel.PropertyChangingEventHandler;

namespace MauiApp1.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged, INotifyPropertyChanging
    {
        public event PropertyChangingEventHandler PropertyChanging;
        public event PropertyChangedEventHandler PropertyChanged;

        protected void SetBackingField<T>(ref T field, T value, [CallerMemberName] string name = null) where T : IComparable<T>
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(name));
            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
