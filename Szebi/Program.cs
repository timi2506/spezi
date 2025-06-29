using System;
using System.Drawing;
using System.Windows.Forms;

class SbeziForm : Form
{
    private PictureBox pictureBox;

    public SbeziForm()
    {
        Text = "Sbezi";
        WindowState = FormWindowState.Maximized;

        pictureBox = new PictureBox
        {
            Dock = DockStyle.Fill,
            ImageLocation = "https://encrypted-tbn3.gstatic.com/shopping?q=tbn:ANd9GcRC_FtMUMkmCE7t3F266wXMrljNnyKAlU1HGlMUh4rUo1R0aWpN21YAaWWBNPkTjByO81GbE7qr",
            SizeMode = PictureBoxSizeMode.Zoom
        };

        Controls.Add(pictureBox);
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new SbeziForm());
    }
}
