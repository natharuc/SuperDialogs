using System.Windows.Forms;

namespace DotNet.Forms.Dialogs.Forms
{
    public partial class FormSuperDialogAlert : Form
    {
        public string Title { get; set; }
        public string Message { get; set; }

        public FormSuperDialogAlert()
        {
            InitializeComponent();
        }

    }
}
