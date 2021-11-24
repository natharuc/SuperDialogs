using System.Drawing;

namespace DotNet.Forms.Dialogs.Classes
{
    public class SuperDialogFont
    {
        public SuperDialogFont(string fontFamily, float fontSize, bool bold)
        {
            FontFamily = fontFamily;
            Size = fontSize;
            Bold = bold;
        }

        private Font _value { get; set; }


        public Font Value
        {
            get
            {
                if (_value == null) _value = new Font("Lucida Console", 12);
                return _value;
            }
            set
            {
                _value = value;
            }

        }

        public string FontFamily
        {
            get
            {
                return Value.FontFamily.Name;
            }
            set
            {
                Value = new Font(value, this.Size);
            }

        }
        public float Size
        {
            get
            {
                return Value.Size;
            }
            set
            {
                Value = new Font(this.FontFamily, value);
            }
        }
        public bool Bold
        {
            get
            {
                return Value.Style == FontStyle.Bold;
            }
            set
            {
                Value = new Font(this.FontFamily, this.Size, value ? FontStyle.Bold : FontStyle.Regular);

            }
        }
        public bool Italic
        {
            get
            {
                return Value.Style == FontStyle.Italic;
            }
            set
            {
                Value = new Font(this.FontFamily, this.Size, value ? FontStyle.Italic : FontStyle.Regular);
            }
        }
        public bool Underline
        {
            get
            {
                return Value.Style == FontStyle.Underline;
            }
            set
            {
                Value = new Font(this.FontFamily, this.Size, value ? FontStyle.Underline : FontStyle.Regular);
            }
        }

        public bool Strikeout
        {
            get
            {
                return Value.Style == FontStyle.Strikeout;
            }
            set
            {
                Value = new Font(this.FontFamily, this.Size, value ? FontStyle.Strikeout : FontStyle.Regular);
            }
        }

    }
}

