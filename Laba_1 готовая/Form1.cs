namespace Laba_1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) => new Form2().ShowDialog();

    private void button2_Click(object sender, EventArgs e)
    {
        var myForm = new Form3();
        myForm.Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        var myForm = new Form4();
        myForm.Show();
    }
}