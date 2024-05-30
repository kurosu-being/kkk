using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT用 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        public void Sing() { 
            MessageBox.Show("publicです");
            pictureBox1.Image
        }

        private void PrivateMethod() {
            MessageBox.Show("privateです");
        }
    }
}
