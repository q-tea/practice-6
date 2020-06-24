using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Dashboard : Form
    {
        private Double operand = 0;
        private Double buffer = 0;
        private String operation = "";
        private bool operation_is_pressed = false;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            textBoxSub.Clear();
            operation = "";
            buffer = 0;
            operand = 0;
            operation_is_pressed = false;
        }

        private void button_Equal_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operation)
                {
                    case "+":
                        textBoxResult.Text = Convert.ToString(buffer + Double.Parse(textBoxResult.Text));
                        break;
                    case "-":
                        textBoxResult.Text = Convert.ToString(buffer - Double.Parse(textBoxResult.Text));
                        break;
                    case "/":
                        textBoxResult.Text = Convert.ToString(buffer / Double.Parse(textBoxResult.Text));
                        break;
                    case "*":
                        textBoxResult.Text = Convert.ToString(buffer * Double.Parse(textBoxResult.Text));
                        break;
                }
                textBoxSub.Clear();
                operation = "";
                buffer = 0;
            }
            catch
            {
                buttonCE_Click(sender, e);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (((textBoxResult.Text == "0") && (button.Text != ",")) || operation_is_pressed)
            {
                textBoxResult.Clear();
                operation_is_pressed = false;
            }
            
            textBoxResult.Text += button.Text;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button_Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            try
            {
                operand = Double.Parse(textBoxResult.Text);
                if (!operation_is_pressed)
                {
                    switch (operation)
                    {
                        case "+":
                            buffer += operand;
                            break;
                        case "-":
                            buffer -= operand;
                            break;
                        case "/":
                            buffer /= operand;
                            break;
                        case "*":
                            buffer *= operand;
                            break;
                        default:
                            buffer = operand;
                            break;
                    }
                    textBoxSub.Text = buffer + " " + button.Text + " ";
                }
                operation = button.Text;
                operation_is_pressed = true;
            }
            catch
            {
                buttonCE_Click(sender, e);
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            Control control_dashboard = (Control)sender;
            Control control_button_0 = (Control)button0;
            Control control_button_1 = (Control)button1;
            Control control_button_2 = (Control)button2;
            Control control_button_3 = (Control)button3;
            Control control_button_4 = (Control)button4;
            Control control_button_5 = (Control)button5;
            Control control_button_6 = (Control)button6;
            Control control_button_7 = (Control)button7;
            Control control_button_8 = (Control)button8;
            Control control_button_9 = (Control)button9;
            Control control_button_dot = (Control)buttonDot;
            Control control_button_ce = (Control)buttonCE;
            Control control_button_plus = (Control)buttonPlus;
            Control control_button_minus = (Control)buttonMinus;
            Control control_button_division = (Control)buttonDivided;
            Control control_button_multiply = (Control)buttonMultiplied;
            Control control_button_equal = (Control)buttonEqual;
            int width = (control_dashboard.Size.Width - 34) / 4;
            int height = (control_dashboard.Height - 110) / 5;
            Size button_size = new Size(width, height);
            control_button_0.Size = button_size;
            control_button_1.Size = button_size;
            control_button_2.Size = button_size;
            control_button_3.Size = button_size;
            control_button_4.Size = button_size;
            control_button_5.Size = button_size;
            control_button_6.Size = button_size;
            control_button_7.Size = button_size;
            control_button_8.Size = button_size;
            control_button_9.Size = button_size;
            control_button_ce.Size = button_size;
            control_button_dot.Size = button_size;
            control_button_plus.Size = button_size;
            control_button_minus.Size = button_size;
            control_button_division.Size = button_size;
            control_button_multiply.Size = button_size;
            control_button_equal.Size = new Size(width * 4, height);
            control_button_8.Location = new Point(control_button_7.Location.X + width , 60);
            control_button_9.Location = new Point(control_button_8.Location.X + width , 60);
            control_button_plus.Location = new Point(control_button_9.Location.X + width , 60);
            control_button_4.Location = new Point(9, control_button_7.Location.Y + height);
            control_button_5.Location = new Point(control_button_4.Location.X + width , control_button_8.Location.Y + height);
            control_button_6.Location = new Point(control_button_5.Location.X + width , control_button_9.Location.Y + height);
            control_button_minus.Location = new Point(control_button_6.Location.X + width, control_button_plus.Location.Y + height);
            control_button_1.Location = new Point(9, control_button_4.Location.Y + height);
            control_button_2.Location = new Point(control_button_1.Location.X + width, control_button_5.Location.Y + height);
            control_button_3.Location = new Point(control_button_2.Location.X + width, control_button_6.Location.Y + height);
            control_button_multiply.Location = new Point(control_button_3.Location.X + width, control_button_minus.Location.Y + height);
            control_button_ce.Location = new Point(9, control_button_1.Location.Y + height);
            control_button_0.Location = new Point(control_button_ce.Location.X + width, control_button_2.Location.Y + height);
            control_button_dot.Location = new Point(control_button_0.Location.X + width, control_button_3.Location.Y + height);
            control_button_division.Location = new Point(control_button_dot.Location.X + width, control_button_multiply.Location.Y + height);
            control_button_equal.Location = new Point(9, control_button_ce.Location.Y + height);
        }
    }
}
