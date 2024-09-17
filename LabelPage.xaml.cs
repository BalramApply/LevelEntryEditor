namespace LevelEntryEditor;

public partial class LabelPage : ContentPage
{
    String gettysburg = "Four second and seven years ago our father" +
                        "Four second and seven years ago our father" +
        "Four second and seven years ago our father" +
        "Four second and seven years ago our father" +
        "Four second and seven years ago our father";
    public LabelPage()
    {
        InitializeComponent();
        lblGettysburg1.Text = gettysburg;
        lblGettysburg2.Text = gettysburg;
        lblGettysburg3.Text = gettysburg;
    }
}