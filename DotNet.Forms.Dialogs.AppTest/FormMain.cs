using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet.Forms.Dialogs.AppTest
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            DotNetDialogs.Information(textBoxTitle.Text, richTextBoxMessage.Text);
        }


        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            DotNetDialogs.Question(textBoxTitle.Text, richTextBoxMessage.Text);
        }

        private void buttonDanger_Click(object sender, EventArgs e)
        {
            DotNetDialogs.Danger(textBoxTitle.Text, richTextBoxMessage.Text);
        }

        private void buttonWarning_Click(object sender, EventArgs e)
        {
            DotNetDialogs.Warning(textBoxTitle.Text, richTextBoxMessage.Text);
        }

        private void buttonSuccess_Click(object sender, EventArgs e)
        {
            DotNetDialogs.Success(textBoxTitle.Text, richTextBoxMessage.Text);
        }

        private void checkBoxDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            SuperDialogGlobalConfig.DarkMode = checkBoxDarkTheme.Checked;
        }

        private void buttonColorInformation_Click(object sender, EventArgs e)
        {
            SuperDialogGlobalConfig.Colors.Information.Value = SelectColorAndAplyToButton(buttonColorInformation);
        }

        private void buttonColorSuccess_Click(object sender, EventArgs e)
        {
            SuperDialogGlobalConfig.Colors.Success.Value = SelectColorAndAplyToButton(buttonColorSuccess);
        }

        private void buttonColorQuestion_Click(object sender, EventArgs e)
        {
            SuperDialogGlobalConfig.Colors.Question.Value = SelectColorAndAplyToButton(buttonColorQuestion);
        }

        private void buttonColorDanger_Click(object sender, EventArgs e)
        {
            SuperDialogGlobalConfig.Colors.Danger.Value = SelectColorAndAplyToButton(buttonColorDanger);
        }

        private void buttonColorWarning_Click(object sender, EventArgs e)
        {
            SuperDialogGlobalConfig.Colors.Warning.Value = SelectColorAndAplyToButton(buttonColorWarning);
        }


        private Color SelectColorAndAplyToButton(Button button)
        {

            if (colorDialogMain.ShowDialog() == DialogResult.OK)
            {
                button.ForeColor = colorDialogMain.Color;
                button.Text = ColorTranslator.ToHtml(colorDialogMain.Color);
                return colorDialogMain.Color;
            }

            return button.ForeColor;
        }

        private Font SelectFontAndAplyToButton(Button button)
        {

            if (fontDialogMain.ShowDialog() == DialogResult.OK)
            {
                button.Font = fontDialogMain.Font;
                button.Text = $"{button.Font.Name};{button.Font.Size}pt";
                return fontDialogMain.Font;
            }

            return button.Font;
        }

        private void buttonButtonFonts_Click(object sender, EventArgs e)
        {
            SuperDialogGlobalConfig.Fonts.Buttons.Value = SelectFontAndAplyToButton(buttonButtonsFont);
        }

        private void textOkButton_TextChanged(object sender, EventArgs e)
        {
            SuperDialogGlobalConfig.Buttons.Ok.Text = textBoxOkButtonText.Text;
        }

        private void textBoxYesButtonText_TextChanged(object sender, EventArgs e)
        {
            SuperDialogGlobalConfig.Buttons.Yes.Text = textBoxYesButtonText.Text;
        }

        private void textBoxNoButtonText_TextChanged(object sender, EventArgs e)
        {
            SuperDialogGlobalConfig.Buttons.No.Text = textBoxNoButtonText.Text;
        }

        private void textBoxCancelButtonText_TextChanged(object sender, EventArgs e)
        {
            SuperDialogGlobalConfig.Buttons.Cancel.Text = textBoxCancelButtonText.Text;
        }

        private void buttonMessageFont_Click(object sender, EventArgs e)
        {
            SuperDialogGlobalConfig.Fonts.Message.Value = SelectFontAndAplyToButton(buttonMessageFont);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonTestPrompt_Click(object sender, EventArgs e)
        {
            var result = DotNetDialogs.Prompt<string>(textBoxTitle.Text, richTextBoxMessage.Text);

            if (result.Value != null)
            {
                DotNetDialogs.Information("Result", result.Value);
            }
        }
    }
}
