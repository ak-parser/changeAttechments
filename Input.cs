using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pract1
{
    class Input
    {
        public static string[] ChangeAttachmentsFileInput()
        {
            StreamReader streamReader = new StreamReader("../../../input.txt");

            string[] input = streamReader.ReadToEnd().Split("\n", StringSplitOptions.RemoveEmptyEntries);

            return input;
        }
    }
}
