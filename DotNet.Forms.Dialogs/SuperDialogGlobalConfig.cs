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

        private static SuperDialogConfigIcons _icons { get; set; }
        public static SuperDialogConfigIcons Icons
        {
            set
            {
                _icons = value;
            }
            get
            {
                if (_icons == null) _icons = new SuperDialogConfigIcons();
                return _icons;
            }
        }

        private static SuperDialogConfigButtons _buttons { get; set; }
        public static SuperDialogConfigButtons Buttons
        {
            set
            {
                _buttons = value;
            }
            get
            {
                if (_buttons == null) _buttons = new SuperDialogConfigButtons();
                return _buttons;
            }
        }

        public static bool Dark { get; set; }
    }
}


