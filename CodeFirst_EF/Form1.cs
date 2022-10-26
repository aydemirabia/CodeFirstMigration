using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst_EF.EntityFramework;

namespace CodeFirst_EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Content sınıfındaki değerleri alabilmemiz ve üzerinde işlem yapabilmemiz
        //için kalıtım uygulamalıyız. Content.cs 'e kalıtım uyguladık.
        private void Form1_Load(object sender, EventArgs e)
        {
            Content c = new Content();
            c.Database.Create();
        }
    }
}
