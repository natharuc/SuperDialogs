using System.Text;

namespace DotNet.Forms.Dialogs.Services
{
    internal static class MessageBreakLineService
    {
        const int MaxLength = 60;
        public static string BreakLine(string message)
        {
            if (message.Length <= MaxLength)
            {
                return message;
            }

            var lines = new StringBuilder();
            
            var words = message.Split(' ');

            var line = new StringBuilder();

            foreach (var word in words)
            {
                if (line.Length + word.Length > MaxLength)
                {
                    lines.AppendLine(line.ToString());
                    line.Clear();
                }

                line.Append(word + " ");
            }

            lines.AppendLine(line.ToString());

            return lines.ToString();
        }
    }
}
