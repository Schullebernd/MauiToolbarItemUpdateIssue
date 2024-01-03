namespace MauiToolbarItemIssue;

public partial class SubPage2 : ContentPage
{
	public SubPage2()
	{
		InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Activating this code, brings the correct toolbaritem
        /*
        this.ToolbarItems.Clear();
        ToolbarItem item = new ToolbarItem()
        {
            Text = "1 / 10"
        };
        this.ToolbarItems.Add(item);
        */
    }
}