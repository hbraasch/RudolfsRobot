using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RudolfsRobot
{


    public partial class frmStartup : Form
    {
        MotorLibrary motorLibrary;

        public frmStartup()
        {
            InitializeComponent();
            initRobot();
        }

        private void initRobot()
        {
            motorLibrary = new MotorLibrary();
        }

        private void btnMoveMotors_Click(object sender, EventArgs e)
        {
            motorLibrary.moveMotorTo(0, 1500);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            motorLibrary.resetDevice();
        }
    }
}
