using System.Windows.Forms;

namespace DotNet.Forms.Dialogs
{
    public class DotNetDialogResult<T>
    {
        private DialogResult _dialogResult { get; set; }

        internal DotNetDialogResult(DialogResult dialogResult)
        {
            _dialogResult = dialogResult;
        }

        /// <summary>
        /// If the user clicks YesButton
        /// </summary>
        public bool YesOk
        {
            get
            {
                return _dialogResult == DialogResult.OK || _dialogResult == DialogResult.Yes;
            }
        }
        /// <summary>
        /// If the user clicks NoButton
        /// </summary>
        public bool No 
        {
            get
            {
                return _dialogResult == DialogResult.No;
            }
        }
        /// <summary>
        /// If the user clicks Cancel
        /// </summary>
        public bool Cancel 
        {
            get
            {
                return _dialogResult == DialogResult.Cancel;
            }
        }

        /// <summary>
        /// If the user doesn't click any button
        /// </summary>
        public bool Undefined 
        {
            get
            {
                return (_dialogResult != DialogResult.Yes && _dialogResult != DialogResult.No && _dialogResult != DialogResult.Cancel);
            }
        }
        public T Value { get; private set; }
    }
}