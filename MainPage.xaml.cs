namespace MauiAttached;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        ColumnLayout.SetFill(line2, true);
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		ColumnLayout.SetFill(line2,!ColumnLayout.GetFill(line2));
    }
}

