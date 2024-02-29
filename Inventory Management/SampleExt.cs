using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class SampleExt : Sample
    {
        public SampleExt()
        {
            InitializeComponent();
        }
        public virtual void btnBack_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }
        public virtual void btnAdd_Click(object sender, EventArgs e)
        {

        }
        public virtual void btnEdit_Click(object sender, EventArgs e)
        {

        }
        public virtual void btnDelete_Click(object sender, EventArgs e)
        {

        }
        public virtual void btnSave_Click(object sender, EventArgs e)
        {

        }
        public virtual void textSearch_TextChanged(object sender, EventArgs e)
        {

        }
        public virtual void btnView_Click(object sender, EventArgs e)
        {

        }
        public virtual void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
