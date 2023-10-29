using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP4365_P2
{
    public partial class Form_viewStock : Form
    {
        public Form_viewStock(string stockSymbol, List<candlestick> candlesticks)
        {
            InitializeComponent();
        }
    }
}
