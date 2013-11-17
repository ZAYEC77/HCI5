using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileBrowser
{
    class SwapBuffer
    {
        static List<String> copy = new List<string>();
        static List<String> cut = new List<string>();
        public static void SetCopy(List<String> l)
        {
		    copy.Clear();
            copy.AddRange(l);
            cut.Clear();
        }
        public static void SetCut(List<String> l)
        {

        }
        public static void Paste(String dir)
        {

        }
    }
}
