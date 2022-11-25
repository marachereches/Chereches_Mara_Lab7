namespace Chereches_Mara_Lab7;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"You rated {count} star";
		else
			CounterBtn.Text = $"You rated {count} stars";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

