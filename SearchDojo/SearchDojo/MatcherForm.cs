using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchDojo
{
    public partial class MatcherForm : Form
    {
        public MatcherForm()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string pattern = String.Format(@"{0}", patternBox.Text);
            MatchCollection matches = Regex.Matches(textBox.Text, pattern);
            foreach (Match match in matches)
            {
                matchesListView.Items.Add(match.ToString());
            }
        }
    }
}
