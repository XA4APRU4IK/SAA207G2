namespace Abstract_Factory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Button button1;
        private ComboBox comboBoxColors;
        private ComboBox comboBoxShapes;

        private void InitializeComponent()
        {
            button1 = new Button();
            comboBoxColors = new ComboBox();
            comboBoxShapes = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 84);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxColors
            // 
            comboBoxColors.FormattingEnabled = true;
            comboBoxColors.Items.AddRange(new object[] { "Красный", "Желтый", "Синий" });
            comboBoxColors.Location = new Point(12, 12);
            comboBoxColors.Name = "comboBoxColors";
            comboBoxColors.Size = new Size(121, 23);
            comboBoxColors.TabIndex = 1;
            // 
            // comboBoxShapes
            // 
            comboBoxShapes.FormattingEnabled = true;
            comboBoxShapes.Items.AddRange(new object[] { "Круг", "Триугольник", "Квадрат" });
            comboBoxShapes.Location = new Point(12, 41);
            comboBoxShapes.Name = "comboBoxShapes";
            comboBoxShapes.Size = new Size(121, 23);
            comboBoxShapes.TabIndex = 2;
            // 
            // Form1
            // 
            ClientSize = new Size(731, 380);
            Controls.Add(comboBoxShapes);
            Controls.Add(comboBoxColors);
            Controls.Add(button1);
            Name = "Form1";
            ResumeLayout(false);
        }
    }
}
