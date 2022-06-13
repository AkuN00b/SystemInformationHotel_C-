using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir_Kel02
{
    public partial class SIHotel : Form
    {
        // Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public SIHotel()
        {
            InitializeComponent();
        }

        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 3;
            progressBar.Value = startpoint;

            if(progressBar.Value == 99)
            {
                progressBar.Value = 100;
                timer1.Stop();
                FormLogin fl = new FormLogin();
                this.Hide();
                fl.Show();
            }
        }

        private void SIHotel_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void SIHotel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
