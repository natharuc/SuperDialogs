using System.Drawing;
using System.IO;

namespace DotNet.Forms.Dialogs.Classes
{
    public class SuperDialogConfigButtons
    {
        private SuperDialogButton _no { get; set; }
        public SuperDialogButton No
        {
            get
            {
                if (_no == null) _no = new SuperDialogButton("No");
                return _no;
            }
            set
            {
                _no = value;
            }
        }
        private SuperDialogButton _cancel { get; set; }
        public SuperDialogButton Cancel
        {
            get
            {
                if (_cancel == null) _cancel = new SuperDialogButton("Cancel");
                return _cancel;
            }
            set
            {
                _cancel = value;
            }
        }
        private SuperDialogButton _yes { get; set; }
        public SuperDialogButton Yes
        {
            get
            {
                if (_yes == null) _yes = new SuperDialogButton("Yes");
                return _yes;
            }
            set
            {
                _yes = value;
            }
        }
        private SuperDialogButton _ok { get; set; }
        public SuperDialogButton Ok
        {
            get
            {
                if (_ok == null) _ok = new SuperDialogButton("Ok");
                return _ok;
            }
            set
            {
                _ok = value;
            }
        }
    }

}

