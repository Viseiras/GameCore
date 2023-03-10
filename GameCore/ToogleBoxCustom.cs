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
    /// <summary>
    /// Control personalizado que simula un togglebox para alternar entre el modo oscuro y modo dia.
    /// </summary>
    public partial class ToogleBoxCustom : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor= Color.DarkSlateBlue;
        private Color offBackColor = Color.LightBlue;
        private Color offToggleColor = Color.LightCyan;
        /// <summary>
        /// Iniciamos el tamaño minimo del toggle box
        /// </summary>
        public ToogleBoxCustom()
        {
            this.MinimumSize = new Size(45, 22);
        }
        /// <summary>
        /// Esta funcion sirve para hacer más grande el toggle box desde la vista diseño
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Le da aspecto visual al toggle box
        /// </summary>
        /// <param name="e"></param>
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
