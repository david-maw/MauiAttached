namespace MauiAttached;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        columnLayout.SetFill(line2, true);
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		columnLayout.SetFill(line2,!columnLayout.GetFill(line2));
    }
}

