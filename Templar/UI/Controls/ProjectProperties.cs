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

namespace Templar.UI.Controls
{
    public partial class ProjectProperties : UserControl, IRefreshableContent
    {
        public ProjectProperties()
        {
            InitializeComponent();
        }

        public ProjectFileModel ProjectFile { get; set; }

        public void RefreshContent()
        {
            propertyGrid1.SelectedObject = ProjectFile;
        }
    }
}
