using System.Drawing;
using System.Windows.Forms;

namespace DotNet.Forms.Dialogs.Services.Extensions
{
    public static class FormExtensions
    {
        public static void AdjustFormSize(this Form form, string text, Font font)
        {
            var size = TextRenderer.MeasureText(text, font);
            var newWidth = size.Width + 100;
            var newHeight = size.Height + 200;
            form.Width = form.Width > newWidth ? form.Width : newWidth;
            form.Height = form.Height > newHeight ? form.Height : newHeight;
        }
    }
}
