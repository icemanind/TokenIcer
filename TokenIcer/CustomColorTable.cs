using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokenIcer
{
    public class CustomColorTable : ProfessionalColorTable
    {
        public override Color MenuBorder => Color.FromArgb(168, 168, 168);
        public override Color MenuStripGradientBegin => Color.FromArgb(110, 110, 110);
        public override Color MenuStripGradientEnd => Color.FromArgb(110, 110, 110);
        public override Color ToolStripDropDownBackground => Color.FromArgb(100, 100, 100);
        public override Color MenuItemSelected => Color.FromArgb(140,140,140);
        public override Color MenuItemPressedGradientBegin => Color.FromArgb(128, 128, 128);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(168, 168, 168);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(168, 168, 168);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(128, 128, 128);

        public override Color ToolStripPanelGradientBegin => Color.LightGreen;
        public override Color ToolStripContentPanelGradientBegin => Color.LightGreen;
        public override Color ToolStripContentPanelGradientEnd => Color.LightGreen;
        public override Color ToolStripGradientBegin => Color.LightGreen;
        public override Color ToolStripGradientEnd => Color.LightGreen;

        public override Color MenuItemBorder => Color.FromArgb(168, 168, 168);

        public override Color ImageMarginGradientBegin => Color.FromArgb(110, 110, 110);
        public override Color ImageMarginGradientMiddle => Color.FromArgb(110, 110, 110);
        public override Color ImageMarginGradientEnd => Color.FromArgb(110, 110, 110);
    }
}
