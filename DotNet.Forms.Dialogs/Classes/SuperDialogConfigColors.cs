using System.Drawing;

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
        public SuperDialogColor Info
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

    public class SuperDialogColor
    {
        public Color Color { get; set; }

        public string HEX
        {
            get
            {
                return "#" + Color.R.ToString("X2") + Color.G.ToString("X2") + Color.B.ToString("X2");
            }
            set
            {
                if (!value.StartsWith("#"))
                {
                    value = $"#{value}";
                }

                Color = ColorTranslator.FromHtml(value);
            }
        }

        /// <summary>
        /// Create a color from hexadecimal code.
        /// </summary>
        /// <param name="hex">Example: #F0F0F0</param>
        public SuperDialogColor(string hex)
        {
            Color = ColorTranslator.FromHtml(hex);
        }

        /// <summary>
        /// Create a color from RGB code.
        /// </summary>
        /// <param name="red">Example: 81</param>
        /// <param name="green">Example: 247</param>
        /// <param name="blue">Example: 203</param>
        public SuperDialogColor(int red, int green, int blue)
        {
            Color = Color.FromArgb(red, green, blue);
        }

    }
}

