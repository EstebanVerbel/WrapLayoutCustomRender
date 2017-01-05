using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WrapLayoutCustomRender.Models;
using WrapLayoutCustomRender.Services;
using Xamarin.Forms;

namespace WrapLayoutCustomRender.Views
{
    public partial class MainPage : ContentPage
    {

        [DataContract]
        class ImageList
        {
            [DataMember(Name = "photos")]
            public List<string> Photos = null;
        }
        
        static readonly int imageDimension = Device.OnPlatform(240, 240, 120);
        static readonly string urlSuffix =
        String.Format("?width={0}&height={0}&mode=max", imageDimension);

        public MainPage()
        {
            InitializeComponent();

            FoodCategoryService service = new Services.FoodCategoryService();
            ObservableCollection<FoodCategory> foodCategoriedCOllection = service.LoadFoodCategoryDirectory();
            
            foreach (FoodCategory foodCat in foodCategoriedCOllection)
            {
                Image image = new Image
                {
                    Source = ImageSource.FromUri(new Uri(foodCat.Image.Data.Url))
                };
                
                wrapLayout.Children.Add(image);
            }
        }
    }
}
