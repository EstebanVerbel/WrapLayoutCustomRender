using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WrapLayoutCustomRender.Models.Entities
{
    public class ObservableBaseObject : INotifyPropertyChanged
    {

        public ObservableBaseObject()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
