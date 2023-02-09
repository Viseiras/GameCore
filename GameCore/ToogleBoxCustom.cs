using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCore
{
    public partial class ToogleBoxCustom : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor= Color.DarkSlateBlue;
        private Color offBackColor = Color.LightBlue;
        private Color offToggleColor = Color.LightCyan;
        public ToogleBoxCustom()
        {
            this.MinimumSize = new Size(45, 22);
        }

        private GraphicsPath MoldeadoToggleBox()
        {
            int tamArco = this.Height - 1;
            Rectangle arcoIzq = new Rectangle(0, 0, tamArco, tamArco);
            Rectangle arcoDer = new Rectangle(this.Width - tamArco - 2, 0, tamArco, tamArco);
            
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(arcoIzq,90,180);
            path.AddArc(arcoDer, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int toggleSize = this.Height - 5;
            e.Graphics.SmoothingMode= SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.Parent.BackColor);

            //Pulsado ON
            if(this.Checked)
            {
                e.Graphics.FillPath(new SolidBrush(onBackColor),MoldeadoToggleBox());
                //Dibuja el cambio cuando se pulsa
                e.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width-this.Height+1,2,toggleSize,toggleSize));
            }
            //Desactivado OFF
            else
            {
                e.Graphics.FillPath(new SolidBrush(offBackColor), MoldeadoToggleBox());
                //Dibuja el cambio cuando se pulsa
                e.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
