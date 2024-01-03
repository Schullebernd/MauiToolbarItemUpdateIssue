namespace MauiToolbarItemIssue;

public partial class SubPage1 : ContentPage
{
	public SubPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		// We open the second sub page - SubPage2 and the icon in this sub page is not beeing updated
		Navigation.PushAsync(new SubPage2());
    }
}