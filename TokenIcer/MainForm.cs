using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokenIcer
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();

         menuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomColorTable());
      }
   }
}
