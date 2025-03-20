using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repasodelaboratorio
{
    public partial class FormAsistencia: Form
    {
        public FormAsistencia()
        {
            InitializeComponent();
        }

        private void buttoncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
