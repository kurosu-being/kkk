using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT用 {
    public class Animal {
        public void Confirm() { 
            var wForm = new Form1();
            wForm.Sing();
            wForm.PrivateMethod();
        }
    }
}
