
using DotNet.Forms.Dialogs.Forms;
using System;
using System.Windows.Forms;

namespace DotNet.Forms.Dialogs
{
    public static class DotNetDialogs
    {
        private static DialogResult GetDialogResult(string title, string message, Action<FormDotNetDialogAlert> action)
        {
            using (var form = new FormDotNetDialogAlert())
            {
                form.Title = title;
                form.Message = message;
                action(form);
                return form.ShowDialog();
            }
        }

        public static DotNetDialogResult<bool> Question(string title, string message)
        {
            return new DotNetDialogResult<bool>(GetDialogResult(title, message, (form) => form.SetInformationStyle()));
        }

        public static DotNetDialogResult<bool> Information(string title, string message)
        {
            return new DotNetDialogResult<bool>(GetDialogResult(title, message, (form) => form.SetInformationStyle()));
        }

        public static DotNetDialogResult<bool> Success(string title, string message)
        {
            return new DotNetDialogResult<bool>(GetDialogResult(title, message, (form) => form.SetSuccessStyle()));
        }

        public static DotNetDialogResult<bool> Warning(string title, string message)
        {
            return new DotNetDialogResult<bool>(GetDialogResult(title, message, (form) => form.SetWarningStyle()));
        }

        public static DotNetDialogResult<T> Prompt<T>(string title, string message)
        {
            using (var formPrompt = new FormSuperDialogPrompt(typeof(T)))
            {
                formPrompt.Title = title;

                formPrompt.Message = message;

                formPrompt.SetQuestionStyle();

                var dialogResult = formPrompt.ShowDialog();

                var result = new DotNetDialogResult<T>(dialogResult)
                {
                    Value = formPrompt.GetValue<T>()
                };

                return result;
            }
        }

        public static DotNetDialogResult<bool> Danger(string title, string message)
        {
            return new DotNetDialogResult<bool>(GetDialogResult(title, message, (form) => form.SetDangerStyle()));
        }
        
        public static DotNetDialogResult<bool> Danger(Exception ex)
        {
            return Danger("Erro", ex.Message);
        }
    }
}


