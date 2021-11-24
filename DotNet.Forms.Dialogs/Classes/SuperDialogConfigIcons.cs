namespace DotNet.Forms.Dialogs.Classes
{
    public class SuperDialogConfigIcons
    {
        private SuperDialogImage _input { get; set; }
        public SuperDialogImage Input 
        {
            get
            {
                if (_input == null) _input = new SuperDialogImage(Properties.Resources.window);
                return _input;
            }
            set
            {
                _input = value;
            }
        }
        private SuperDialogImage _success { get; set; }
        public SuperDialogImage Success
        {
            get
            {
                if (_success == null) _success = new SuperDialogImage(Properties.Resources.success);
                return _success;
            }
            set
            {
                _success = value;
            }
        }
        private SuperDialogImage _danger { get; set; }
        public SuperDialogImage Danger
        {
            get
            {
                if (_danger == null) _danger = new SuperDialogImage(Properties.Resources.danger);
                return _danger;
            }
            set
            {
                _danger = value;
            }
        }
        private SuperDialogImage _info { get; set; }
        public SuperDialogImage Info
        {
            get
            {
                if (_info == null) _info = new SuperDialogImage(Properties.Resources.information);
                return _info;
            }
            set
            {
                _info = value;
            }
        }
        private SuperDialogImage _warning { get; set; }
        public SuperDialogImage Warning
        {
            get
            {
                if (_warning == null) _warning = new SuperDialogImage(Properties.Resources.warning);
                return _warning;
            }
            set
            {
                _warning = value;
            }
        }
        private SuperDialogImage _question { get; set; }
        public SuperDialogImage Question
        {
            get
            {
                if (_question == null) _question = new SuperDialogImage(Properties.Resources.question);
                return _question;
            }
            set
            {
                _question = value;
            }
        }
    }
}

