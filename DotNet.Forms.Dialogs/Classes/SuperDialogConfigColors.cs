namespace DotNet.Forms.Dialogs.Classes
{
    public class SuperDialogConfigColors
    {
        private SuperDialogColor _success { get; set; }

        /// <summary>
        /// Default color <b>#22C55E</b>
        /// </summary>
        public SuperDialogColor Success
        {
            get
            {
                if (_success == null) _success = new SuperDialogColor("#22C55E");
                return _success;
            }
            set
            {
                _success = value;
            }
        }

        private SuperDialogColor _danger { get; set; }

        /// <summary>
        /// Default color <b>#FB7185</b>
        /// </summary>
        public SuperDialogColor Danger
        {
            get
            {
                if (_danger == null) _danger = new SuperDialogColor("#FB7185");
                return _danger;
            }
            set
            {
                _danger = value;
            }
        }

        private SuperDialogColor _warning { get; set; }

        /// <summary>
        /// Default color <b>#FACC15</b>
        /// </summary>
        public SuperDialogColor Warning
        {
            get
            {
                if (_warning == null) _warning = new SuperDialogColor("#FACC15");
                return _warning;
            }
            set
            {
                _warning = value;
            }
        }

        private SuperDialogColor _info { get; set; }

        /// <summary>
        /// Default color <b>#38BDF8</b>
        /// </summary>
        public SuperDialogColor Information
        {
            get
            {
                if (_info == null) _info = new SuperDialogColor("#38BDF8");
                return _info;
            }
            set
            {
                _info = value;
            }
        }

        private SuperDialogColor _question { get; set; }

        /// <summary>
        /// Default color <b>#A78BFA</b>
        /// </summary>
        public SuperDialogColor Question
        {
            get
            {
                if (_question == null) _question = new SuperDialogColor("#A78BFA");
                return _question;
            }
            set
            {
                _question = value;
            }
        }
    }
}

