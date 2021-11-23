
using DotNet.Forms.Dialogs.Forms;

namespace DotNet.Forms.Dialogs
{
    public class SuperDialogs
    {
        private  static FormSuperDialogAlert _formAlert { get; set; }
        private static FormSuperDialogAlert FormAlert
        {
            get
            {
                if (_formAlert == null) _formAlert = new FormSuperDialogAlert();

                return _formAlert;
            }
            set
            {
                _formAlert = value;
            }
        }

        public static bool? Question(string title, string message)
        {
            return FormAlert.ShowDialog() == System.Windows.Forms.DialogResult.Yes;
        }
    }
}
