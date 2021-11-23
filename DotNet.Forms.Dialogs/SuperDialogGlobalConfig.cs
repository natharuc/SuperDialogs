using DotNet.Forms.Dialogs.Classes;

namespace DotNet.Forms.Dialogs
{
    public static class SuperDialogGlobalConfig
    {
        private static SuperDialogConfigColors _colors { get; set; }
        public static SuperDialogConfigColors Colors
        {
            set
            {
                _colors = value;
            }
            get
            {
                if (_colors == null) _colors = new SuperDialogConfigColors();
                return _colors;
            }
        }

        private static SuperDialogConfigFonts _fonts { get; set; }
        public static SuperDialogConfigFonts Fonts
        {
            set
            {
                _fonts = value;
            }
            get
            {
                if (_fonts == null) _fonts = new SuperDialogConfigFonts();
                return _fonts;
            }
        }

    }
}


