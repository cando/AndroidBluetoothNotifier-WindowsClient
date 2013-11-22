using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidBluetoothNotifier
{
    public class WrapLabel : Label
    {
        public WrapLabel()
        {
            this.AutoSize = false;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            this.FitToContents();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            this.FitToContents();
        }

        protected virtual void FitToContents()
        {
            Size size;
            int maxHeight = Int32.Parse(ConfigurationManager.AppSettings["MaximumNotificationHeight"]);
            size = this.GetPreferredSize(new Size(this.Width, 0));
            if (size.Height > maxHeight)
            {
                this.Height = maxHeight;
                return;
            }
            this.Height = size.Height;
        }

        [DefaultValue(false), Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool AutoSize
        {
            get { return base.AutoSize; }
            set { base.AutoSize = value; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }
}
