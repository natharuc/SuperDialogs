using DotNet.Forms.Dialogs.Services;
using DotNet.Forms.Dialogs.Services.Extensions;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace DotNet.Forms.Dialogs.Forms
{
    internal partial class FormSuperDialogPrompt : Form
    {
        private readonly Type _valueType;
        
        private bool _selectFile { get; set; }
        public bool SelectFile
        {
            get
            {
                return _selectFile;
            }
            set
            {
                _selectFile = value;
                textBoxImput.Visible = !value;
                buttonSelectFile.Visible = value;
            }
        }

        public string Title
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }
        public string Message
        {
            get
            {
                return labelMessage.Text;
            }
            set
            {
                labelMessage.Font = SuperDialogGlobalConfig.Fonts.Message.Value;
                labelMessage.Text = MessageBreakLineService.BreakLine(value);
                this.AdjustFormSize(labelMessage.Text, labelMessage.Font);
            }
        }

        public Image CurrentImage
        {
            get
            {
                return pictureBoxIcon.Image;
            }
            set
            {

                pictureBoxIcon.Image = value;

                this.Icon = Icon.FromHandle(((Bitmap)value).GetHicon());
            }
        }

        private bool _showYesButtonStyle { get; set; }
        public bool ShowYesButtonStyle
        {
            get
            {
                return _showYesButtonStyle;
            }
            set
            {
                _showYesButtonStyle = value;
                ApplyButtonsConfiguration();
            }
        }

        private Color _currentColor { get; set; }
        public Color CurrentColor
        {
            get
            {
                return _currentColor;
            }
            set
            {
                _currentColor = value;

                labelMessage.ForeColor = value;
                buttonCancel.ForeColor = value;
                buttonYesOk.ForeColor = value;
                buttonSelectFile.ForeColor = value;
                AplyTheme();
            }
        }

        public FormSuperDialogPrompt(Type valueType)
        {
            InitializeComponent();

            _valueType = valueType;

            SelectFile = (_valueType == typeof(FileInfo));
        }

        private void AplyTheme()
        {
            var formBackColor = Color.FromArgb(240, 240, 240);
            var buttonsBackColor = Color.FromArgb(255, 255, 255);

            if (SuperDialogGlobalConfig.DarkMode)
            {
                formBackColor = Color.FromArgb(40, 40, 40);
                buttonsBackColor = Color.FromArgb(30, 30, 30);
            }

            this.BackColor = formBackColor;
            buttonYesOk.BackColor = buttonsBackColor;
            buttonSelectFile.BackColor = buttonsBackColor;
            buttonCancel.BackColor = buttonsBackColor;
        }

        private void ApplyButtonsConfiguration()
        {
            #region Yes/Ok Button

            if (ShowYesButtonStyle)
            {
                buttonYesOk.Text = SuperDialogGlobalConfig.Buttons.Yes.Text;
            }
            else
            {
                buttonYesOk.Text = SuperDialogGlobalConfig.Buttons.Ok.Text;
            }

            #endregion


            buttonCancel.Text = SuperDialogGlobalConfig.Buttons.Cancel.Text;


            buttonCancel.Font = SuperDialogGlobalConfig.Fonts.Buttons.Value;
            buttonYesOk.Font = SuperDialogGlobalConfig.Fonts.Buttons.Value;
        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }

        internal void SetQuestionStyle()
        {
            ShowYesButtonStyle = true;
            buttonCancel.Visible = true;
            CurrentColor = SuperDialogGlobalConfig.Colors.Question.Value;
            CurrentImage = Properties.Resources.question;
        }

        internal void SetDangerStyle()
        {
            ShowYesButtonStyle = false;
            buttonCancel.Visible = false;
            CurrentColor = SuperDialogGlobalConfig.Colors.Danger.Value;
            CurrentImage = Properties.Resources.danger;
        }

        internal void SetSuccessStyle()
        {
            ShowYesButtonStyle = false;
            buttonCancel.Visible = false;
            CurrentColor = SuperDialogGlobalConfig.Colors.Success.Value;
            CurrentImage = Properties.Resources.success;
        }

        internal void SetInformationStyle()
        {
            ShowYesButtonStyle = false;
            buttonCancel.Visible = false;
            CurrentColor = SuperDialogGlobalConfig.Colors.Information.Value;
            CurrentImage = Properties.Resources.information;
        }

        internal void SetWarningStyle()
        {
            ShowYesButtonStyle = false;
            buttonCancel.Visible = false;
            CurrentColor = SuperDialogGlobalConfig.Colors.Warning.Value;
            CurrentImage = Properties.Resources.warning;
        }

        private void FormDotNetDialogAlert_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    DialogResult = DialogResult.Abort;
                    Close();
                    break;
            }
        }



        private void textBoxImput_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    if (IsNotValidValue()) return;

                    DialogResult = DialogResult.OK;

                    Close();

                    break;
                case Keys.Escape:
                    DialogResult = DialogResult.Abort;
                    Close();
                    break;
            }
        }

        public bool IsNotValidValue()
        {
            if (SelectFile)
            {
                if (buttonSelectFile.Tag == null)
                {
                    labelValidation.Text = "Select a file";

                    labelValidation.Visible = true;

                    return true;
                }

                return false;
            }

            try
            {

                var converter = TypeDescriptor.GetConverter(_valueType);

                if (converter != null)
                {
                    // Cast ConvertFromString(string text) : object to (T)
                    _ = converter.ConvertFromString(textBoxImput.Text.Trim());
                }

                return false;

            }
            catch (Exception ex)
            {
                labelValidation.Text = ex.Message;

                labelValidation.Visible = true;

                return true;
            }
        }

        private void textBoxImput_TextChanged(object sender, EventArgs e)
        {
            labelValidation.Visible = false;
        }

        private void buttonYesOk_Click(object sender, EventArgs e)
        {
            if (IsNotValidValue()) return;

            DialogResult = DialogResult.OK;

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;

            Close();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                buttonSelectFile.Text = dialog.FileName;
                buttonSelectFile.Tag = new FileInfo(dialog.FileName);
            }
        }

        internal T GetValue<T>()
        {
            if (SelectFile)
                return (T)buttonSelectFile.Tag;

            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));

                if (converter != null)
                {
                    // Cast ConvertFromString(string text) : object to (T)
                    return (T)converter.ConvertFromString(textBoxImput.Text.Trim());
                }

                return default(T);
            }
            catch (NotSupportedException)
            {
                return default(T);
            }
        }
    }
}
