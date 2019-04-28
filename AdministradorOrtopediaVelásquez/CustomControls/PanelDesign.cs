using System.Drawing;
using System.Windows.Forms;

namespace AdministradorOrtopediaVelásquez.CustomControls
{
    class PanelDesign :Panel
    {

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.BorderStyle = BorderStyle.None;
            e.Graphics.DrawRectangle(new Pen(Color.LightGray, 2), this.ClientRectangle);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
