using Abstract_Factory;
using System;
using System.Drawing;
using System.Windows.Forms;
public partial class MainForm : Form
{
    private ComboBox comboBox;
    private IShapeFactory currentFactory;
    private IShape circle;
    private IShape square;
    private IShape triangle;

    public MainForm()
    {
        InitializeComponent();

        comboBox = new ComboBox();
        comboBox.Dock = DockStyle.Top;
        comboBox.Items.AddRange(new string[] { "Красный", "Синий", "Жёлтый" });
        comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

        Controls.Add(comboBox);
        this.Paint += MainForm_Paint;
        comboBox.SelectedIndex = 0; 
    }

    private void InitializeComponent()
    {
        this.SuspendLayout();
        this.ClientSize = new System.Drawing.Size(284, 261);
        this.Name = "MainForm";
        this.ResumeLayout(false);
    }

    private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (comboBox.SelectedIndex)
        {
            case 0:
                currentFactory = new RedFactory();
                break;
            case 1:
                currentFactory = new BlueFactory();
                break;
            case 2:
                currentFactory = new YellowFactory();
                break;
        }

        circle = currentFactory.CreateCircle();
        square = currentFactory.CreateSquare();
        triangle = currentFactory.CreateTriangle();

        Invalidate();
    }

    private void MainForm_Paint(object sender, PaintEventArgs e)
    {
        if (circle != null && square != null && triangle != null)
        {
            circle.Draw(e.Graphics, 10, 50);
            square.Draw(e.Graphics, 70, 50);
            triangle.Draw(e.Graphics, 130, 50);
        }
    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
    }
}



