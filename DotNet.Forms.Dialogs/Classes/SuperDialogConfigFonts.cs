namespace DotNet.Forms.Dialogs.Classes
{
    public class SuperDialogConfigFonts
    {
        private SuperDialogFont _message { get; set; }
        /// <summary>
        /// Default FontFamily is <b>Lucida Console</b>, and size is <b>12</b> and style <b>regular</b>.
        /// </summary>
        public SuperDialogFont Message
        {
            get
            {
                if (_message == null) _message = new SuperDialogFont("Lucida Console", 12, false);

                return _message;
            }
            set
            {
                _message = value;
            }
        }

        private SuperDialogFont _buttons { get; set; }
        /// <summary>
        /// Default FontFamily is <b>Lucida Console</b>, and size is <b>12</b> and style <b>regular</b>.
        /// </summary>
        public SuperDialogFont Buttons
        {
            get
            {
                if (_buttons == null) _buttons = new SuperDialogFont("Lucida Console", 12, false);

                return _buttons;
            }
            set
            {
                _buttons = value;
            }
        }
    }
}

