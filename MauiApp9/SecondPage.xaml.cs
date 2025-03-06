using System.Collections.ObjectModel;

namespace MauiApp9;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
	}

    public ObservableCollection<string> Items { get; } = [];

    private void AddItemClicked(object sender, EventArgs e)
    {
        Items.Add("Item " + (Items.Count + 1));
    }
}