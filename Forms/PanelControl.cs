using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ADRASHA_Main
{
    public partial class PanelControl : UserControl
    {
        public PanelControl()
        {
            InitializeComponent();
            this.kryptonGroup2.Panel.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
        }

        

        #region MyRegion

        private Color color1 = System.Drawing.Color.FromArgb(93,203,232);
        private Color color2 = System.Drawing.Color.FromArgb(93,203,232);
        private float colorangle=0f;
        private int rounding = 0;


        [Category("Custom Props")]
        public Color Color1
        {
            get { return color1; }
            set { color1 = value; this.kryptonGroup2.StateCommon.Back.Color1 = value; }
        }

        [Category("Custom Props")]
        public Color Color2
        {
            get { return color2; }
            set { color2 = value; this.kryptonGroup2.StateCommon.Back.Color2 = value; }
        }

        [Category("Custom Props")]
        public float Angle
        {
            get { return colorangle; }
            set { colorangle = value; this.kryptonGroup2.StateCommon.Back.ColorAngle = value; }
        }

        [Category("Custom Props")]
        public int Rounding
        {
            get { return rounding; }
            set { rounding = value; this.kryptonGroup1.StateCommon.Border.Rounding= value; }
        }

        #endregion
    }
}
