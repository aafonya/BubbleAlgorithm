using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 10; i > 0; i--)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<String> stringList = new List<String>();

            foreach (String stringy in listBox1.Items)
            {
                stringList.Add(stringy);
            }

            for (int i = 0; i < listBox1.Items.Count ; i++)
            {
                for (int j = 0; j < listBox1.Items.Count; j++)
                {
                    string temp;
                    if (stringList[i].CompareTo(stringList[j]) == -1)
                    {
                        temp = stringList[i];
                        stringList[i] = stringList[j];
                        stringList[j] = temp;
                    }
                }
            }
            foreach(String stringy in stringList)
            {
                listBox2.Items.Add(stringy);
            }
        }
    }
}
