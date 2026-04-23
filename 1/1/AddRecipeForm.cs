using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class AddRecipeForm : Form
    {
        public AddRecipeForm()
        {
            InitializeComponent();
        }

        public string Description { get; internal set; }
        public List<string> Ingredients { get; internal set; }
        public List<string> Instructions { get; internal set; }
        public int Calories { get; internal set; }
        public DateTime Date { get; internal set; }
    }
}
