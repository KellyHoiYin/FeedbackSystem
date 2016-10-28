using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback
{
    class HeaderItem
    {
        private string title;
        private string inputType;
        private string valueChosen;
        private List<string> valueItems;

        public string Title { get; set; }
        public string InputType { get; set; }
        public string ValueChosen { get; set; }
        public List<string> ValueItem
        {
            get { return ValueItem; }
            set { ValueItem = value; }
        }

        public FlowLayoutPanel createPanelForInputType(string chosen)
        {
            FlowLayoutPanel rtnPanel = new FlowLayoutPanel();

            switch (chosen)
            {
                case "text":
                    rtnPanel = createStaticTextBox();
                    break;
                case "date":
                    rtnPanel = createDateSelectionBox();
                    break;
                case "list":
                    rtnPanel = createCombolist();
                    break;
                case "query":
                default:
                    //to confirm the input type is within the acceptable range, but this shouldn't happen as the input type is chosen from a predefined list
                    throw new ArgumentOutOfRangeException("I didnt mean it");
            }

            rtnPanel.AutoScroll = true;
            rtnPanel.AutoSize = true;
            return rtnPanel;
        }

        public FlowLayoutPanel createStaticTextBox()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.LeftToRight;

            Label label = new Label();
            label.Text = "Input text: ";

            TextBox textBox = new TextBox();
            //textBox.MaxLength = 256;
            
            try
            {
                panel.Controls.Add(label);
                panel.Controls.Add(textBox);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            return panel;
        }

        public FlowLayoutPanel createDateSelectionBox()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.LeftToRight;

            Label label = new Label();
            label.AutoSize = true;
            label.Text = "Select the date type: ";

            RadioButton choice1 = new RadioButton();
            RadioButton choice2 = new RadioButton();
            RadioButton choice3 = new RadioButton();

            choice1.Text = "Today's Date";
            choice2.Text = "Review / Interview Dare";
            choice3.Text = "Manual";

            choice1.AutoSize = true;
            choice2.AutoSize = true;
            choice3.AutoSize = true;

            try
            {
                panel.Controls.Add(label);
                panel.Controls.Add(choice1);
                panel.Controls.Add(choice2);
                panel.Controls.Add(choice3);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            return panel;
        }

        public FlowLayoutPanel createCombolist()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.LeftToRight;

            Label label = new Label();
            label.Text = "Input list (separate your values with ','): ";

            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Height = 100;
            textBox.Width = 250;

            try
            {
                panel.Controls.Add(label);
                panel.Controls.Add(textBox);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            return panel;
        }

        public FlowLayoutPanel createQueryBox()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.FlowDirection = FlowDirection.LeftToRight;

            Label label = new Label();
            label.Text = "Select your wanted list (that will be retrieve from the database):";

            TextBox textBox = new TextBox();
            //textBox.MaxLength = 256;

            try
            {
                panel.Controls.Add(label);
                panel.Controls.Add(textBox);
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }
            return panel;
        }
    }
}
