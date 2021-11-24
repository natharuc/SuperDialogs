
namespace DotNet.Forms.Dialogs.AppTest
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonInformation = new System.Windows.Forms.Button();
            this.buttonSuccess = new System.Windows.Forms.Button();
            this.buttonDanger = new System.Windows.Forms.Button();
            this.buttonQuestion = new System.Windows.Forms.Button();
            this.buttonWarning = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxDarkTheme = new System.Windows.Forms.CheckBox();
            this.fontDialogMain = new System.Windows.Forms.FontDialog();
            this.colorDialogMain = new System.Windows.Forms.ColorDialog();
            this.buttonColorInformation = new System.Windows.Forms.Button();
            this.buttonColorSuccess = new System.Windows.Forms.Button();
            this.buttonColorQuestion = new System.Windows.Forms.Button();
            this.buttonColorDanger = new System.Windows.Forms.Button();
            this.buttonColorWarning = new System.Windows.Forms.Button();
            this.buttonMessageFont = new System.Windows.Forms.Button();
            this.buttonButtonsFont = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOkButtonText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxYesButtonText = new System.Windows.Forms.TextBox();
            this.textBoxNoButtonText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCancelButtonText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInformation
            // 
            this.buttonInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformation.Location = new System.Drawing.Point(10, 241);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(120, 40);
            this.buttonInformation.TabIndex = 8;
            this.buttonInformation.Text = "Information";
            this.buttonInformation.UseVisualStyleBackColor = true;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // buttonSuccess
            // 
            this.buttonSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSuccess.Location = new System.Drawing.Point(136, 241);
            this.buttonSuccess.Name = "buttonSuccess";
            this.buttonSuccess.Size = new System.Drawing.Size(120, 40);
            this.buttonSuccess.TabIndex = 10;
            this.buttonSuccess.Text = "Success";
            this.buttonSuccess.UseVisualStyleBackColor = true;
            this.buttonSuccess.Click += new System.EventHandler(this.buttonSuccess_Click);
            // 
            // buttonDanger
            // 
            this.buttonDanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDanger.Location = new System.Drawing.Point(388, 241);
            this.buttonDanger.Name = "buttonDanger";
            this.buttonDanger.Size = new System.Drawing.Size(120, 40);
            this.buttonDanger.TabIndex = 14;
            this.buttonDanger.Text = "Danger";
            this.buttonDanger.UseVisualStyleBackColor = true;
            this.buttonDanger.Click += new System.EventHandler(this.buttonDanger_Click);
            // 
            // buttonQuestion
            // 
            this.buttonQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuestion.Location = new System.Drawing.Point(262, 241);
            this.buttonQuestion.Name = "buttonQuestion";
            this.buttonQuestion.Size = new System.Drawing.Size(120, 40);
            this.buttonQuestion.TabIndex = 12;
            this.buttonQuestion.Text = "Question";
            this.buttonQuestion.UseVisualStyleBackColor = true;
            this.buttonQuestion.Click += new System.EventHandler(this.buttonQuestion_Click);
            // 
            // buttonWarning
            // 
            this.buttonWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWarning.Location = new System.Drawing.Point(514, 241);
            this.buttonWarning.Name = "buttonWarning";
            this.buttonWarning.Size = new System.Drawing.Size(120, 40);
            this.buttonWarning.TabIndex = 16;
            this.buttonWarning.Text = "Warning";
            this.buttonWarning.UseVisualStyleBackColor = true;
            this.buttonWarning.Click += new System.EventHandler(this.buttonWarning_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(10, 27);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(246, 23);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.Text = "What is Lorem Ipsum?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(10, 71);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(246, 56);
            this.richTextBoxMessage.TabIndex = 3;
            this.richTextBoxMessage.Text = resources.GetString("richTextBoxMessage.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // checkBoxDarkTheme
            // 
            this.checkBoxDarkTheme.AutoSize = true;
            this.checkBoxDarkTheme.Location = new System.Drawing.Point(10, 189);
            this.checkBoxDarkTheme.Name = "checkBoxDarkTheme";
            this.checkBoxDarkTheme.Size = new System.Drawing.Size(89, 19);
            this.checkBoxDarkTheme.TabIndex = 26;
            this.checkBoxDarkTheme.Text = "Dark Theme";
            this.checkBoxDarkTheme.UseVisualStyleBackColor = true;
            this.checkBoxDarkTheme.CheckedChanged += new System.EventHandler(this.checkBoxDarkTheme_CheckedChanged);
            // 
            // buttonColorInformation
            // 
            this.buttonColorInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.buttonColorInformation.Location = new System.Drawing.Point(10, 287);
            this.buttonColorInformation.Name = "buttonColorInformation";
            this.buttonColorInformation.Size = new System.Drawing.Size(120, 40);
            this.buttonColorInformation.TabIndex = 9;
            this.buttonColorInformation.Text = "#38BDF8";
            this.buttonColorInformation.UseVisualStyleBackColor = true;
            this.buttonColorInformation.Click += new System.EventHandler(this.buttonColorInformation_Click);
            // 
            // buttonColorSuccess
            // 
            this.buttonColorSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.buttonColorSuccess.Location = new System.Drawing.Point(136, 287);
            this.buttonColorSuccess.Name = "buttonColorSuccess";
            this.buttonColorSuccess.Size = new System.Drawing.Size(120, 40);
            this.buttonColorSuccess.TabIndex = 11;
            this.buttonColorSuccess.Text = "#22C55E";
            this.buttonColorSuccess.UseVisualStyleBackColor = true;
            this.buttonColorSuccess.Click += new System.EventHandler(this.buttonColorSuccess_Click);
            // 
            // buttonColorQuestion
            // 
            this.buttonColorQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(139)))), ((int)(((byte)(250)))));
            this.buttonColorQuestion.Location = new System.Drawing.Point(262, 287);
            this.buttonColorQuestion.Name = "buttonColorQuestion";
            this.buttonColorQuestion.Size = new System.Drawing.Size(120, 40);
            this.buttonColorQuestion.TabIndex = 13;
            this.buttonColorQuestion.Text = "#A78BFA";
            this.buttonColorQuestion.UseVisualStyleBackColor = true;
            this.buttonColorQuestion.Click += new System.EventHandler(this.buttonColorQuestion_Click);
            // 
            // buttonColorDanger
            // 
            this.buttonColorDanger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorDanger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(113)))), ((int)(((byte)(133)))));
            this.buttonColorDanger.Location = new System.Drawing.Point(388, 287);
            this.buttonColorDanger.Name = "buttonColorDanger";
            this.buttonColorDanger.Size = new System.Drawing.Size(120, 40);
            this.buttonColorDanger.TabIndex = 15;
            this.buttonColorDanger.Text = "#FB7185";
            this.buttonColorDanger.UseVisualStyleBackColor = true;
            this.buttonColorDanger.Click += new System.EventHandler(this.buttonColorDanger_Click);
            // 
            // buttonColorWarning
            // 
            this.buttonColorWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColorWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(204)))), ((int)(((byte)(21)))));
            this.buttonColorWarning.Location = new System.Drawing.Point(514, 287);
            this.buttonColorWarning.Name = "buttonColorWarning";
            this.buttonColorWarning.Size = new System.Drawing.Size(120, 40);
            this.buttonColorWarning.TabIndex = 17;
            this.buttonColorWarning.Text = "#FACC15";
            this.buttonColorWarning.UseVisualStyleBackColor = true;
            this.buttonColorWarning.Click += new System.EventHandler(this.buttonColorWarning_Click);
            // 
            // buttonMessageFont
            // 
            this.buttonMessageFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMessageFont.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMessageFont.Location = new System.Drawing.Point(262, 27);
            this.buttonMessageFont.Name = "buttonMessageFont";
            this.buttonMessageFont.Size = new System.Drawing.Size(372, 33);
            this.buttonMessageFont.TabIndex = 5;
            this.buttonMessageFont.Text = "Lucida Console; 10pt";
            this.buttonMessageFont.UseVisualStyleBackColor = true;
            this.buttonMessageFont.Click += new System.EventHandler(this.buttonMessageFont_Click);
            // 
            // buttonButtonsFont
            // 
            this.buttonButtonsFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonButtonsFont.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonButtonsFont.Location = new System.Drawing.Point(262, 94);
            this.buttonButtonsFont.Name = "buttonButtonsFont";
            this.buttonButtonsFont.Size = new System.Drawing.Size(372, 33);
            this.buttonButtonsFont.TabIndex = 7;
            this.buttonButtonsFont.Text = "Lucida Console; 12pt";
            this.buttonButtonsFont.UseVisualStyleBackColor = true;
            this.buttonButtonsFont.Click += new System.EventHandler(this.buttonButtonFonts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Message Font";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Button\'s Font";
            // 
            // textBoxOkButtonText
            // 
            this.textBoxOkButtonText.Location = new System.Drawing.Point(10, 156);
            this.textBoxOkButtonText.Name = "textBoxOkButtonText";
            this.textBoxOkButtonText.Size = new System.Drawing.Size(150, 23);
            this.textBoxOkButtonText.TabIndex = 19;
            this.textBoxOkButtonText.Text = "Ok";
            this.textBoxOkButtonText.TextChanged += new System.EventHandler(this.textOkButton_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ok Button Text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Yes Button Text";
            // 
            // textBoxYesButtonText
            // 
            this.textBoxYesButtonText.Location = new System.Drawing.Point(166, 156);
            this.textBoxYesButtonText.Name = "textBoxYesButtonText";
            this.textBoxYesButtonText.Size = new System.Drawing.Size(150, 23);
            this.textBoxYesButtonText.TabIndex = 21;
            this.textBoxYesButtonText.Text = "Yes";
            this.textBoxYesButtonText.TextChanged += new System.EventHandler(this.textBoxYesButtonText_TextChanged);
            // 
            // textBoxNoButtonText
            // 
            this.textBoxNoButtonText.Location = new System.Drawing.Point(322, 156);
            this.textBoxNoButtonText.Name = "textBoxNoButtonText";
            this.textBoxNoButtonText.Size = new System.Drawing.Size(150, 23);
            this.textBoxNoButtonText.TabIndex = 23;
            this.textBoxNoButtonText.Text = "No";
            this.textBoxNoButtonText.TextChanged += new System.EventHandler(this.textBoxNoButtonText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "No Button Text";
            // 
            // textBoxCancelButtonText
            // 
            this.textBoxCancelButtonText.Location = new System.Drawing.Point(484, 156);
            this.textBoxCancelButtonText.Name = "textBoxCancelButtonText";
            this.textBoxCancelButtonText.Size = new System.Drawing.Size(150, 23);
            this.textBoxCancelButtonText.TabIndex = 25;
            this.textBoxCancelButtonText.Text = "Cancel";
            this.textBoxCancelButtonText.TextChanged += new System.EventHandler(this.textBoxCancelButtonText_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cancel Button Text";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 351);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCancelButtonText);
            this.Controls.Add(this.textBoxNoButtonText);
            this.Controls.Add(this.textBoxYesButtonText);
            this.Controls.Add(this.buttonButtonsFont);
            this.Controls.Add(this.buttonMessageFont);
            this.Controls.Add(this.checkBoxDarkTheme);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOkButtonText);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.buttonWarning);
            this.Controls.Add(this.buttonQuestion);
            this.Controls.Add(this.buttonDanger);
            this.Controls.Add(this.buttonSuccess);
            this.Controls.Add(this.buttonColorWarning);
            this.Controls.Add(this.buttonColorDanger);
            this.Controls.Add(this.buttonColorQuestion);
            this.Controls.Add(this.buttonColorSuccess);
            this.Controls.Add(this.buttonColorInformation);
            this.Controls.Add(this.buttonInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotNet.Dialogs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInformation;
        private System.Windows.Forms.Button buttonSuccess;
        private System.Windows.Forms.Button buttonDanger;
        private System.Windows.Forms.Button buttonQuestion;
        private System.Windows.Forms.Button buttonWarning;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxDarkTheme;
        private System.Windows.Forms.FontDialog fontDialogMain;
        private System.Windows.Forms.ColorDialog colorDialogMain;
        private System.Windows.Forms.Button buttonColorInformation;
        private System.Windows.Forms.Button buttonColorSuccess;
        private System.Windows.Forms.Button buttonColorQuestion;
        private System.Windows.Forms.Button buttonColorDanger;
        private System.Windows.Forms.Button buttonColorWarning;
        private System.Windows.Forms.Button buttonMessageFont;
        private System.Windows.Forms.Button buttonButtonsFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOkButtonText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxYesButtonText;
        private System.Windows.Forms.TextBox textBoxNoButtonText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCancelButtonText;
        private System.Windows.Forms.Label label8;
    }
}

