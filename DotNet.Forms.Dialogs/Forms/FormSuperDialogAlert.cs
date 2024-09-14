using DotNet.Forms.Dialogs.Services;
using DotNet.Forms.Dialogs.Services.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace DotNet.Forms.Dialogs.Forms
{
    internal partial class FormDotNetDialogAlert : Form
    {
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
                buttonNo.ForeColor = value;
                buttonYesOk.ForeColor = value;
                AplyTheme();
            }
        }

        public FormDotNetDialogAlert()
        {
            InitializeComponent();
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
            buttonNo.BackColor = buttonsBackColor;
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

            buttonNo.Text = SuperDialogGlobalConfig.Buttons.No.Text;

            buttonCancel.Text = SuperDialogGlobalConfig.Buttons.Cancel.Text;


            buttonNo.Font = SuperDialogGlobalConfig.Fonts.Buttons.Value;
            buttonCancel.Font = SuperDialogGlobalConfig.Fonts.Buttons.Value;
            buttonYesOk.Font = SuperDialogGlobalConfig.Fonts.Buttons.Value;
        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }

        internal void SetQuestionStyle()
        {
            ShowYesButtonStyle = true;
            buttonNo.Visible = true;
            buttonCancel.Visible = true;
            CurrentColor = SuperDialogGlobalConfig.Colors.Question.Value;
            CurrentImage = Properties.Resources.question;
        }

        internal void SetDangerStyle()
        {
            ShowYesButtonStyle = false;
            buttonNo.Visible = false;
            buttonCancel.Visible = false;
            CurrentColor = SuperDialogGlobalConfig.Colors.Danger.Value;
            CurrentImage = Properties.Resources.danger;
        }

        internal void SetSuccessStyle()
        {
            ShowYesButtonStyle = false;
            buttonNo.Visible = false;
            buttonCancel.Visible = false;
            CurrentColor = SuperDialogGlobalConfig.Colors.Success.Value;
            CurrentImage = Properties.Resources.success;
        }

        internal void SetInformationStyle()
        {
            ShowYesButtonStyle = false;
            buttonNo.Visible = false;
            buttonCancel.Visible = false;
            CurrentColor = SuperDialogGlobalConfig.Colors.Information.Value;
            CurrentImage = Properties.Resources.information;
        }

        internal void SetWarningStyle()
        {
            ShowYesButtonStyle = false;
            buttonNo.Visible = false;
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
                case Keys.Y:
                    if (buttonYesOk.Visible)
                        buttonYesOk.PerformClick();
                    break;
                case Keys.N:
                    if (buttonNo.Visible)
                        buttonNo.PerformClick();
                    break;
                case Keys.C:
                    if (buttonCancel.Visible)
                        buttonCancel.PerformClick();
                    break;
            }

            if(e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(Message);
            }
        }
    }
}
