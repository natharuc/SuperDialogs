using System.Drawing;
using System.IO;

namespace DotNet.Forms.Dialogs.Classes
{
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

