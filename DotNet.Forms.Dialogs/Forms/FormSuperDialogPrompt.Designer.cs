
namespace DotNet.Forms.Dialogs.Forms
{
    partial class FormSuperDialogPrompt
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
            tableLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            labelValidation = new System.Windows.Forms.Label();
            panelButtons = new System.Windows.Forms.Panel();
            buttonCancel = new System.Windows.Forms.Button();
            buttonYesOk = new System.Windows.Forms.Button();
            pictureBoxIcon = new System.Windows.Forms.PictureBox();
            labelMessage = new System.Windows.Forms.Label();
            panelImput = new System.Windows.Forms.Panel();
            textBoxImput = new System.Windows.Forms.TextBox();
            tableLayoutPanelPrincipal.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            panelImput.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelPrincipal
            // 
            tableLayoutPanelPrincipal.AutoSize = true;
            tableLayoutPanelPrincipal.ColumnCount = 2;
            tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelPrincipal.Controls.Add(labelValidation, 0, 2);
            tableLayoutPanelPrincipal.Controls.Add(panelButtons, 0, 3);
            tableLayoutPanelPrincipal.Controls.Add(pictureBoxIcon, 0, 0);
            tableLayoutPanelPrincipal.Controls.Add(labelMessage, 1, 0);
            tableLayoutPanelPrincipal.Controls.Add(panelImput, 0, 1);
            tableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelPrincipal.Location = new System.Drawing.Point(5, 5);
            tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            tableLayoutPanelPrincipal.RowCount = 4;
            tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            tableLayoutPanelPrincipal.Size = new System.Drawing.Size(444, 169);
            tableLayoutPanelPrincipal.TabIndex = 0;
            // 
            // labelValidation
            // 
            tableLayoutPanelPrincipal.SetColumnSpan(labelValidation, 2);
            labelValidation.Dock = System.Windows.Forms.DockStyle.Fill;
            labelValidation.Enabled = false;
            labelValidation.Font = new System.Drawing.Font("Lucida Console", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelValidation.ForeColor = System.Drawing.Color.Firebrick;
            labelValidation.Location = new System.Drawing.Point(3, 91);
            labelValidation.Name = "labelValidation";
            labelValidation.Size = new System.Drawing.Size(438, 20);
            labelValidation.TabIndex = 2;
            labelValidation.Text = "Message";
            labelValidation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            labelValidation.Visible = false;
            // 
            // panelButtons
            // 
            tableLayoutPanelPrincipal.SetColumnSpan(panelButtons, 2);
            panelButtons.Controls.Add(buttonCancel);
            panelButtons.Controls.Add(buttonYesOk);
            panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            panelButtons.Location = new System.Drawing.Point(3, 114);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new System.Drawing.Size(438, 52);
            panelButtons.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            buttonCancel.BackColor = System.Drawing.Color.White;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCancel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonCancel.Location = new System.Drawing.Point(9, 9);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(123, 33);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonYesOk
            // 
            buttonYesOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            buttonYesOk.BackColor = System.Drawing.Color.White;
            buttonYesOk.FlatAppearance.BorderSize = 0;
            buttonYesOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonYesOk.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonYesOk.Location = new System.Drawing.Point(302, 9);
            buttonYesOk.Name = "buttonYesOk";
            buttonYesOk.Size = new System.Drawing.Size(123, 33);
            buttonYesOk.TabIndex = 1;
            buttonYesOk.Text = "Yes";
            buttonYesOk.UseVisualStyleBackColor = false;
            buttonYesOk.Click += buttonYesOk_Click;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBoxIcon.Image = Properties.Resources.success;
            pictureBoxIcon.InitialImage = null;
            pictureBoxIcon.Location = new System.Drawing.Point(3, 3);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new System.Drawing.Size(37, 33);
            pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxIcon.TabIndex = 0;
            pictureBoxIcon.TabStop = false;
            // 
            // labelMessage
            // 
            labelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            labelMessage.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelMessage.Location = new System.Drawing.Point(46, 0);
            labelMessage.Name = "labelMessage";
            labelMessage.Padding = new System.Windows.Forms.Padding(5);
            labelMessage.Size = new System.Drawing.Size(395, 39);
            labelMessage.TabIndex = 1;
            labelMessage.Text = "Message";
            labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelImput
            // 
            tableLayoutPanelPrincipal.SetColumnSpan(panelImput, 2);
            panelImput.Controls.Add(textBoxImput);
            panelImput.Dock = System.Windows.Forms.DockStyle.Fill;
            panelImput.Location = new System.Drawing.Point(3, 42);
            panelImput.Name = "panelImput";
            panelImput.Padding = new System.Windows.Forms.Padding(10);
            panelImput.Size = new System.Drawing.Size(438, 46);
            panelImput.TabIndex = 0;
            // 
            // textBoxImput
            // 
            textBoxImput.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxImput.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxImput.Location = new System.Drawing.Point(10, 10);
            textBoxImput.MaxLength = int.MaxValue;
            textBoxImput.Multiline = true;
            textBoxImput.Name = "textBoxImput";
            textBoxImput.Size = new System.Drawing.Size(418, 26);
            textBoxImput.TabIndex = 0;
            textBoxImput.TextChanged += textBoxImput_TextChanged;
            textBoxImput.KeyDown += textBoxImput_KeyDown;
            // 
            // FormSuperDialogPrompt
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonFace;
            ClientSize = new System.Drawing.Size(454, 179);
            Controls.Add(tableLayoutPanelPrincipal);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSuperDialogPrompt";
            Padding = new System.Windows.Forms.Padding(5);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Title";
            KeyDown += FormDotNetDialogAlert_KeyDown;
            tableLayoutPanelPrincipal.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            panelImput.ResumeLayout(false);
            panelImput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonYesOk;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel panelImput;
        private System.Windows.Forms.TextBox textBoxImput;
        private System.Windows.Forms.Label labelValidation;
    }
}

