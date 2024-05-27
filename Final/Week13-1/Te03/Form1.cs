namespace Te03;

public partial class Form1 : Form
{
    // Start
    public Form1()
    {
        InitializeComponent();
    }
    // Event
    private void TrackBar_ValueChanged(System.Object? sender, System.EventArgs e)
    {
        Label[] LabelColor = {LabelRedValue, LabelGreenValue, LabelBlueValue};
        TrackBar[] TrackBarColor = {TrackBarRed, TrackBarGreen, TrackBarBlue};
        for(int i = 0; i < 3; i++)
        {
            LabelColor[i].Text = $"{TrackBarColor[i].Value}";
        }
        LabelMain.BackColor = Color.FromArgb(TrackBarColor[0].Value, TrackBarColor[1].Value, TrackBarColor[2].Value);
    }
}
