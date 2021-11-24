using System.Drawing;

namespace DotNet.Forms.Dialogs.Classes
{
    public class SuperDialogColor
    {
        public Color Value { get; set; }

        public string HEX
        {
            get
            {
                return "#" + Value.R.ToString("X2") + Value.G.ToString("X2") + Value.B.ToString("X2");
            }
            set
            {
                if (!value.StartsWith("#"))
                {
                    value = $"#{value}";
                }

                Value = ColorTranslator.FromHtml(value);
            }
        }

        /// <summary>
        /// Create a color from hexadecimal code.
        /// </summary>
        /// <param name="hex">Example: #F0F0F0</param>
        public SuperDialogColor(string hex)
        {
            Value = ColorTranslator.FromHtml(hex);
        }

        /// <summary>
        /// Create a color from RGB code.
        /// </summary>
        /// <param name="red">Example: 81</param>
        /// <param name="green">Example: 247</param>
        /// <param name="blue">Example: 203</param>
        public SuperDialogColor(int red, int green, int blue)
        {
            Value = Color.FromArgb(red, green, blue);
        }

    }
}

