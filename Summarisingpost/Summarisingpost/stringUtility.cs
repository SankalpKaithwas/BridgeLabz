using System;
using System.Collections.Generic;
using System.Text;

namespace Summarisingpost
{
    class stringUtility
    {
       public static string SummerizeText(string Text, int maxLength = 20)
        {


            if (Text.Length < maxLength)
                return Text;

            var words = Text.Split(' ');
            var totalchar = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalchar += word.Length + 1;
                if (totalchar > maxLength)
                    break;
            }
            return String.Join(" ", summaryWords) + "...";

        }
    }
}
