namespace Calculator.CustomForms
{
    using System.Windows.Forms;
    
    public partial class ParanthesTextBox : TextBox
    {
        public ParanthesTextBox()
        {
            InitializeComponent();
/*            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;*/
        }
    }
}
