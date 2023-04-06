using MediaElement.ViewModels;
using Mopups.Services;

namespace MediaElement;

public partial class MyPopupPage 
{
	public MyPopupPage()
	{
		InitializeComponent();
        BindingContext = new VideoUrlViewModel();
    }

    private void LoginButton_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PopAsync();
    }
}