using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MVP_Lab_IndTask
{
    public partial class Form1 :Form,IView
    {
        Presenter presenter;

        public Form1()
        {
            InitializeComponent();
            presenter = new Presenter(this);
            textBox1.TextChanged += textBox1_TextChanged;
  
        }
        public event EventHandler<EventArgs> SetSize;
        public int InputSize
        {
            get
            {
                int res;
                if (!int.TryParse(textBox1.Text, out res))
                
                        res = 0;
                if(res==1)
                    res = 0;
                return res;
            }
            set
            {
                textBox1.Text = value.ToString();
            }
        }
        
        public string PrintMatrix
        {
            get
            {
                return label3.Text;
            }
            set
            {
                label3.Text = value;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (SetSize != null)
            {
                SetSize(this, EventArgs.Empty);

            }

        }
    }
}
