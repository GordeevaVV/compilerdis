using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CShCompiler
{
    public partial class FAnalizator : System.Windows.Forms.Form
    {
        public FAnalizator()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            FileReader fileReader = new FileReader();
            MessageBox.Show(fileReader.Reader(), "Загрузка файла", MessageBoxButtons.OK);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
