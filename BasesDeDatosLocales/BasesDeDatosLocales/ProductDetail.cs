using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BasesDeDatosLocales
{
    public class ProductDetailPage : ContentPage
    {
        public ProductDetailPage(string productName)
        {
            Title = productName;

            var productDetailLabel = new Label
            {
                Text = "Detalles del producto: " + productName,
                FontSize = 20,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var goBackButton = new Button
            {
                Text = "Volver",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            goBackButton.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };

            var content = new StackLayout
            {
                Children = { productDetailLabel, goBackButton }
            };

            Content = content;
        }
    }
}
