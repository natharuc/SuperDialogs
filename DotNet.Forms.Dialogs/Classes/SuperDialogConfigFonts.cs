using System.Drawing;

namespace DotNet.Forms.Dialogs.Classes
{
    public class SuperDialogConfigFonts
    {
        private SuperDialogFont _title { get; set; }

        /// <summary>
        /// Default FontFamily is <b>Lucida Console</b>, and size is <b>18,</b> and style <b>bold</b>.
        /// </summary>
        public SuperDialogFont Title
        {
            get
            {
                if (_title == null) _title = new SuperDialogFont("Lucida Console", 18, true);

                return _title;
            }
            set
            {
                _title = value;
            }
        }
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
    }

    public class SuperDialogFont
    {
        public SuperDialogFont(string fontFamily, float fontSize, bool bold)
        {
            FontFamily = fontFamily;
            Size = fontSize;
            Bold = bold;
        }

        private Font _font { get; set; }


        public Font Font
        {
            set
            {
                _font = value;
            }
            get
            {
                if (_font == null) _font = new Font("Lucida Console", 12);
                return _font;
            }
        }

        public string FontFamily
        {
            get
            {
                return _font.FontFamily.Name;
            }
            set
            {
                _font = new Font(value, this.Size);
            }

        }
        public float Size
        {
            get
            {
                return _font.Size;
            }
            set
            {
                _font = new Font(this.FontFamily, value);
            }
        }
        public bool Bold
        {
            get
            {
                return _font.Style == FontStyle.Bold;
            }
            set
            {
                _font = new Font(this.FontFamily, this.Size, value ? FontStyle.Bold : FontStyle.Regular);

            }
        }
        public bool Italic
        {
            get
            {
                return _font.Style == FontStyle.Italic;
            }
            set
            {
                _font = new Font(this.FontFamily, this.Size, value ? FontStyle.Italic : FontStyle.Regular);
            }
        }
        public bool Underline
        {
            get
            {
                return _font.Style == FontStyle.Underline;
            }
            set
            {
                _font = new Font(this.FontFamily, this.Size, value ? FontStyle.Underline : FontStyle.Regular);
            }
        }

        public bool Strikeout
        {
            get
            {
                return _font.Style == FontStyle.Strikeout;
            }
            set
            {
                _font = new Font(this.FontFamily, this.Size, value ? FontStyle.Strikeout : FontStyle.Regular);
            }
        }

    }
}

