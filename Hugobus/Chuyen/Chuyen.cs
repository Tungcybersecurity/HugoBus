using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Chuyen
{
    public partial class Chuyen : Form
    {
        ChuyenBUS service = new ChuyenBUS();
        public Chuyen()
        {
            InitializeComponent();
            loadForm();
        }
        void loadForm()
        {
            tripTable.DataSource = service.doDuLieu();
            tripTable.ReadOnly = true;
        }
    }
}
