using DTO;
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

namespace GUI.Student.InfomationStudent
{
    public partial class InforStudent3 : Form
    {
        Students getst = new Students();
        Parents getpr = new Parents();
        public InforStudent3(Students st , Parents pr)
        {
            InitializeComponent();
        }

        
        private void InforStudent3_Load(object sender, EventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
