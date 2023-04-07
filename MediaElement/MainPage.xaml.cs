using MediaElement.ViewModels;
using Mopups.Interfaces;

namespace MediaElement;

public partial class MainPage : ContentPage
{
    private IPopupNavigation popupNavigation;

    public MainPage(IPopupNavigation popupNavigation)
    {
        this.InitializeComponent();
        BindingContext = new VideoUrlViewModel();
        this.popupNavigation = popupNavigation;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        popupNavigation.PushAsync(new MyPopupPage());
    }
}