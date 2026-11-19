namespace DesktopApp;

public partial class Form1 : Form
{

    private Button button1;

    public Form1()
    {
        InitializeComponent();
    }

    public void OnClick(Object sender, EventArgs e){
        
        this.Text="Button is clicked";
    }

    public void OnMouseDown(Object sender, MouseEventArgs e){
        
        this.Text="MOuse is down";
        int x=e.X;
        int y=e.Y;
        if (e.Button == MouseButtons.Left)
            {
                this.Text=x + " , "+ y;
            }
    }

    public void OnMouseUp(Object sender, MouseEventArgs e){
        
        this.Text="MOuse is UP";
    }

    public void OnMouseMove(Object sender, EventArgs e){
        
        this.Text="MOuse is UP";
    }
}
