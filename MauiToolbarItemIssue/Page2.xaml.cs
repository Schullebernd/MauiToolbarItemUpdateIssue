namespace MauiToolbarItemIssue;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {
		// We open the first sub page - SubPage1 and the icon in this page will show correctly
		Navigation.PushAsync(new SubPage1());
    }
}