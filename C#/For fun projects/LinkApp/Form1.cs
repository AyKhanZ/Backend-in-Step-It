namespace LinkApp;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void link_button_Click(object sender, EventArgs e)
    {
        //var uri = "https://www.google.com"; 
        if (link_textBox.Text.StartsWith("https://www."))
        {
            var uri = link_textBox.Text;
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }
        else MessageBox.Show("Incorrect input link!");
    }
}