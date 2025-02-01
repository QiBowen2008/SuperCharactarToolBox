using SuperTextToolBox.PowerPointAddIn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTextToolBox.PowerPointAddIn
{
    public partial class frmSlidesToPics : Sunny .UI .UIForm 
    {
        public frmSlidesToPics()
        {
            InitializeComponent();
        }

        private void frmSlidesToPics_Load(object sender, EventArgs e)
        {
            Microsoft .Office .Interop . PowerPoint.Presentation presentation = Globals.ThisAddIn.Application.ActivePresentation;
            label2.Text = presentation.Slides.Count.ToString();
        }
    }
}
