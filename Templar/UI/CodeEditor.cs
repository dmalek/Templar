using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Templar.Aplication.Models;

namespace Templar.UI
{
    public partial class CodeEditor : UserControl, IRefreshableContent
    {
        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;
        private const int WM_MOUSEWHEEL = 0x20A;

        public delegate void ScrollBarChangedEventHandler(object sender, EventArgs e);
        public event ScrollBarChangedEventHandler ScrollBarChanged;

        public CodeEditor()
        {
            InitializeComponent();         
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_VSCROLL || m.Msg == WM_HSCROLL || m.Msg == WM_MOUSEWHEEL)
            {
                if (ScrollBarChanged != null)
                {
                    ScrollBarChanged(this, EventArgs.Empty);    
                }
            }
        }

        private CodeTemplateModel? _code = null;
        public CodeTemplateModel? Code { 
            get
            {
                return _code;
            }
            set
            {
                _code = value;
                RefreshContent();
            }
        }

        public void RefreshContent()
        {
            txtTemplate.Text = _code?.Template;
            txtTemplate.Select(0, 0);

            txtCode.Text = _code?.Source;
            txtCode.Select(0, 0);

            toolStripButton1.Enabled = (_code != null);
            splitContainer1.SplitterDistance = (int)(splitContainer1.Width / 2);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Code != null)
            {
                Code.Template = txtTemplate.Text;
            }            
        }
    }
}
