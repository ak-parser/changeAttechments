using System;
using System.Text;
using System.Linq;
using System.IO;

namespace Pract1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] input = Input.ChangeAttachmentsFileInput();

                ChangeAttachments.ChangeString(input);

                foreach (var elem in input)
                    Console.WriteLine(elem);
            }
            catch(FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
