
using DotNet.Forms.Dialogs.Forms;

namespace DotNet.Forms.Dialogs
{
    public class DotNetDialogs
    {
        private  static FormDotNetDialogAlert _formAlert { get; set; }
        private static FormDotNetDialogAlert FormAlert
        {
            get
            {
                if (_formAlert == null) _formAlert = new FormDotNetDialogAlert();

                return _formAlert;
            }
            set
            {
                _formAlert = value;
            }
        }

        public static DotNetDialogResult<bool> Question(string title, string message)
        {
            FormAlert.Title = title;
            FormAlert.Message = message;
            FormAlert.SetQuestionStyle();

            return new DotNetDialogResult<bool>(FormAlert.ShowDialog());
        }

        public static DotNetDialogResult<bool> Information(string title, string message)
        {
            FormAlert.Title = title;
            FormAlert.Message = message;
            FormAlert.SetInformationStyle();

            return new DotNetDialogResult<bool>(FormAlert.ShowDialog());
        }

        public static DotNetDialogResult<bool> Danger(string title, string message)
        {
            FormAlert.Title = title;
            FormAlert.Message = message;
            FormAlert.SetDangerStyle();

            return new DotNetDialogResult<bool>(FormAlert.ShowDialog());
        }

        public static DotNetDialogResult<bool> Success(string title, string message)
        {
            FormAlert.Title = title;
            FormAlert.Message = message;
            FormAlert.SetSuccessStyle();

            return new DotNetDialogResult<bool>(FormAlert.ShowDialog());
        }

        public static DotNetDialogResult<bool> Warning(string title, string message)
        {
            FormAlert.Title = title;
            FormAlert.Message = message;
            FormAlert.SetWarningStyle();

            return new DotNetDialogResult<bool>(FormAlert.ShowDialog());
        }

    }
}


