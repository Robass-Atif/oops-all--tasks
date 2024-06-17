using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_with_window_form
{
    public partial class frmForMemory : Form
    {
        public frmForMemory()
        {
            InitializeComponent();
           
            
        }
        protected override void SetVisibleCore(bool value)
        {
            if (!IsHandleCreated)
            {
                // Create the handle before setting visibility
                CreateHandle();
                value = false; // Set initial visibility to false
            }

            base.SetVisibleCore(value);
        }
        private void frmForMemory_Load(object sender, EventArgs e)
        {
           
        }
    }
}
