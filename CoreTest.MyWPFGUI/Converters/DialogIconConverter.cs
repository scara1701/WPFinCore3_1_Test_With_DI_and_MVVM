using CoreTest.MyLib.Models;
using System.Windows;

namespace CoreTest.MyWPFGUI.Converters
{
    public static class DialogIconConverter 
    {
        public static MessageBoxImage Convert(DialogType dialogType)
        {
            if (dialogType == DialogType.Error) return MessageBoxImage.Error;
            if (dialogType == DialogType.Warning) return MessageBoxImage.Warning;
            return MessageBoxImage.Information;
        }

    }
}
