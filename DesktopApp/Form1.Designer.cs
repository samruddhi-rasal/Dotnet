namespace DesktopApp;

partial class Form1
{
   
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

   
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Text = "Form1";
        
        this.button1 = new Button();

        this.button1.Text = "Click Me";
        this.button1.Location = new Point(100, 100);
        this.button1.Click+=OnClick;


        //Add subscriber:
         this.MouseDown += OnMouseDown;
         this.MouseUp+=OnMouseUp;
         this.MouseMove+=OnMouseMove;
         

        this.Controls.Add(this.button1);
    
    
    }

    #endregion
}
