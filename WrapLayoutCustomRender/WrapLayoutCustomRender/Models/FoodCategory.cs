using WrapLayoutCustomRender.Models.DataObjects;
using WrapLayoutCustomRender.Models.Entities;

namespace WrapLayoutCustomRender.Models
{
    public class FoodCategory : ObservableBaseObject
    {
        string _name;
        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(); } }

        string _description;
        public string Description { get { return _description; } set { _description = value; OnPropertyChanged(); } }

        Picture _image;
        public Picture Image { get { return _image; } set { _image = value; OnPropertyChanged(); } }
    }
}
