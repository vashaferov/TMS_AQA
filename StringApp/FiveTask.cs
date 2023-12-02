using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StringApp
{
    public class FiveTask
    {
        static public bool CheckCorrectFormatString(string s)
        {
            string pattern = @"^\d{4}-[a-zA-Z]{3}-\d{4}-[a-zA-Z]{3}-\d[a-zA-Z]\d[a-zA-Z]$";

            return Regex.IsMatch(s, pattern);
        }

        static public string BlockNums(string s)
        {
            string pattern = @"\d{4}";
            string results = string.Empty;

            MatchCollection matches = Regex.Matches(s, pattern);

            foreach (Match match in matches)
            {
                results += match.Value + " ";
            }

            return results;
        }

        static public string NumberWithoutLettersBlock(string s)
        {
            string pattern = @"[a-z]{3}";

            MatchCollection matches = Regex.Matches(s, pattern);

            foreach (Match match in matches)
            {
                s = s.Replace(match.Value, "***");
            }

            return s;
        }

        static public string OnlyLettersToLower(string s)
        {
            string pattern = @"[a-zA-Z]";
            string results = string.Empty;

            MatchCollection matches = Regex.Matches(s, pattern);

            results = @$"{matches[0]}{matches[1]}{matches[2]}/{matches[3]}{matches[4]}{matches[5]}/{matches[6]}/{matches[7]}";

            return results.ToLower();
        }

        static public string OnlyLettersToUpper(string s)
        {
            string pattern = @"[a-zA-Z]";
            StringBuilder results = new StringBuilder();

            MatchCollection matches = Regex.Matches(s, pattern);

            foreach (Match match in matches)
                results.Append(match.Value);

            results.Insert(3, "/").Insert(7, "/").Insert(9, "/");

            return results.ToString().ToUpper();
        }

        static public string FindInTextABC(string s, string findText)
        {
            string results = string.Empty;

            string subStr = s.ToLower();
            int index = subStr.IndexOf(findText);
            if (index != -1) 
            {
                results = $"В тексте найдено \"{findText}\":\n{s.Insert(index, "|").Insert(index + findText.Length + 1, "|")}";
            }
            else
                results = $"В тексте не найдена последовательность \"{findText}\"";

            return results;
        }

        static public string FindTextStart(string s, string findText)
        {
            string results = string.Empty;

            int index = s.IndexOf(findText);

            if (index == -1)
                results = $"В тексте не найдена последовательность \"{findText}\"";
            else if (index > 2)
                results = $"В тексте найдена последовательность \"{findText}\", но она не в первом блоке цифр";
            else if (index < 2)
                results = $"В тексте найдена последовательность \"{findText}\", и она в первом блоке цифр";

            return results;
        }

        static public string FindTextEnd(string s, string findText)
        {
            string results = string.Empty;

            int index = s.LastIndexOf(findText);

            if (index == -1)
                results = $"В тексте найдена последовательность \"{findText}\"";
            else if (index < 18)
                results = $"В тексте найдена последовательность \"{findText}\", но она не в последнем блоке";
            else if (index >= 18)
                results = $"В тексте найдена последовательность \"{findText}\", и она в последнем блоке";

            return results;
        }
    }
}
