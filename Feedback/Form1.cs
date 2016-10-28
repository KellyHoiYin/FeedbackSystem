using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }

        private void Form1_Load()
        {
            HeaderItem item = new HeaderItem();
            //panel1.Controls.Add(item.createStaticTextBox());

            //panel1.ScrollControlIntoView = Panel.ScrollStateVScrollVisible;

             ComboBox combo = new ComboBox();
             combo.Items.Add("text");
             combo.Items.Add("date");
             combo.Items.Add("query");
             combo.Items.Add("list");
            combo.SelectedIndexChanged += cb_SelectedIndexChanged;

             panel1.Controls.Add(combo);
            //event handler that when the combobox is changed then call the createPanelForInputType(throwing in the 
            //selected value in the combobox)

            
            
            /*
            try {
                var controls = lay.Controls.OfType<RadioButton>();
            }
            catch (Exception)
            {
                MessageBox.Show("Oh uh");
            }*/
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (!cb.Focused)
            {
                return;
            }
            else
            {
                //MessageBox.Show("Selected Value: " + cb.SelectedItem);
                try
                {
                    FlowLayoutPanel lay = new FlowLayoutPanel();
                    lay = (new HeaderItem()).createPanelForInputType((string)cb.SelectedItem);
                    panel1.Controls.Add(lay);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }
    }
}

