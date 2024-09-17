namespace LevelEntryEditor;

public partial class EntryPage : ContentPage
{
	public EntryPage()
	{
		InitializeComponent();
	}
	private void OnCompleted(Object sender, EventArgs args)
	{
		DisplayAlert("Complete", "Welcome" + entryName2.Text + "!", "OK");
	}

	private void Highlight(object sender, EventArgs args)
	{
        Entry entry = sender as Entry;
		entry.BackgroundColor = Colors.Yellow;
    }

    private void Unhighlight(object sender, EventArgs args)
    {
        Entry entry = sender as Entry;
        entry.BackgroundColor = Colors.White;
    }

    private void TextPassword(object sender, EventArgs args)
	{
		Entry entry = sender as Entry;
		String upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		String lower = "abcdefghijklmnopqrstuvwxyz";
		String numbers = "1234567890";
		bool flag = true;
		bool uc = false, lc = false, num = false;

		flag = entry.Text.Length < 8 ? false : flag;
		for (int i = 0; i < entry.Text.Length; i++)
		{
			uc = upper.Contains(entry.Text.Substring(i, 1)) ? true : uc;
			lc = lower.Contains(entry.Text.Substring(i, 1)) ? true : lc;
            num = numbers.Contains(entry.Text.Substring(i, 1)) ? true : num;
        }
		if(flag && uc && lc && num)
		{
			lblValid.Text = "Password is VALID!";
			lblValid.TextColor = Colors.Green;
		}
		else
		{
            lblValid.Text = "Password is InVALID!";
            lblValid.TextColor = Colors.Red;
        }
	}
}