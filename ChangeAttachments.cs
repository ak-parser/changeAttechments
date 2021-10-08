using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pract1
{
    class ChangeAttachments
    {
        public static void ChangeString(string[] input)
        {
            int countSymb = 0;
            foreach (var elem in input)
                countSymb += elem.Count(i => i == '#');

            if (countSymb % 2 != 0)
                throw new ArgumentException("String is incorrect");

            int currentCountSymb = 1;
            for (int index = 0; index < input.Length && currentCountSymb <= countSymb; index++)
            {
                StringBuilder stringBuilderInput = new StringBuilder(input[index]);
                for (int i = 0; i < stringBuilderInput.Length && currentCountSymb <= countSymb; i++)
                {
                    if (stringBuilderInput[i] == '#')
                    {
                        if (currentCountSymb <= (countSymb / 2))
                        {
                            stringBuilderInput[i] = '<';
                            currentCountSymb++;
                        }
                        else
                        {
                            stringBuilderInput[i] = '>';
                            currentCountSymb++;
                        }
                    }
                }

                input[index] = stringBuilderInput.ToString();
            }
        }
    }
}
