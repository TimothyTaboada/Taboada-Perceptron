using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputPerceptron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double[] inputs = { 0, 0, 0, 0 };
        Perceptron p = new Perceptron();

        // Switches colors and input state
        private void ToggleButton(int index, Button btn)
        {
            switch (inputs[index])
            {
                case 0:
                    inputs[index] = 1;
                    btn.BackColor = Color.Green;
                    break;
                case 1:
                    inputs[index] = 0;
                    btn.BackColor = Color.Red;
                    break;
            }
        }

        // Check what output should be diplayed
        private void CzecState()
        {
            switch(p.Predict(inputs))
            {
                case 0:
                    output.BackColor = Color.Gray; break;
                case 1:
                    output.BackColor = Color.Yellow; break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleButton(0, ((Button)sender));
            CzecState();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToggleButton(1, ((Button)sender));
            CzecState();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleButton(2, ((Button)sender));
            CzecState();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ToggleButton(3, ((Button)sender));
            CzecState();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputs = new double[] { 0, 0, 0, 0 };
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            output.BackColor = Color.Red;
        }
    }
}
