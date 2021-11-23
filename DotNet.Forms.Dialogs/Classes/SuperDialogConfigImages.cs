using System.Drawing;
using System.IO;

namespace DotNet.Forms.Dialogs.Classes
{
    public class SuperDialogConfigImages
    {
        private SuperDialogImage _icon { get; set; }
        public SuperDialogImage Icon 
        {
            get
            {
                if (_icon == null) _icon = new SuperDialogImage(Properties.Resources.window);
                return _icon;
            }
            set
            {
                _icon = value;
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

    public class SuperDialogImage
    {
        public SuperDialogImage(byte[] bytes)
        {
            Bytes = bytes;
        }

        public SuperDialogImage(string fileName)
        {
            FileName = fileName;
        }

        public SuperDialogImage(Stream stream)
        {
            _stream = stream;
        }

        public SuperDialogImage(Bitmap bitmap)
        {
            Image = bitmap;
        }

        public Image Image { get; set; }

        public string _fileName { get; set; }
        public string FileName 
        {
            get
            {
                return _fileName;
            }
            set
            {
                Image = Image.FromFile(value);
            }
        }

        public Stream _stream { get; set; }
        public Stream Stream
        {
            get
            {
                return _stream;
            }
            set
            {
                Image = Image.FromStream(value);
            }
        }

        public byte[] _bytes { get; set; }
        public byte[] Bytes
        {
            get
            {
                return _bytes;
            }
            set
            {
                using (var ms = new MemoryStream(value, 0, value.Length))
                {
                    ms.Write(value, 0, value.Length);
                    Image = Image.FromStream(ms, true);
                }
            }
        }
    }
}

