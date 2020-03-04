using System;
using System.Collections.Generic;
using System.Text;

namespace CoreTest.MyLib.Models
{
    public class UIPopupOpenFile
    {
        public string FileTypeFilter { get; set; }
        public string Title { get; set; }
        public UIPopupOpenFile(string title, string fileTypeFilter)
        {
            Title = title;
            FileTypeFilter = fileTypeFilter;
        }
    }
}
