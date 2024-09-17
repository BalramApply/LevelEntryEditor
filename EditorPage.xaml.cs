namespace LevelEntryEditor;

public partial class EditorPage : ContentPage
{
	public EditorPage()
	{
		InitializeComponent();
	}

	private void UpdateLength(Object sender, TextChangedEventArgs args)
	{
		lblLength.Text = "Length: " + editorQuestion.Text.Length.ToString() + " character";
	}
}