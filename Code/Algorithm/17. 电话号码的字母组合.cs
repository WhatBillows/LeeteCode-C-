using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Algorithm
{
    internal class _17
    {
        string[] letterMap = new string[10]
        {
           "", // 0
           "", // 1
           "abc", // 2
           "def", // 3
           "ghi", // 4
           "jkl", // 5
           "mno", // 6
           "pqrs", // 7
           "tuv", // 8
           "wxyz", // 9
        };

        string _digits;
        List<string> _resultList = new();

        public IList<string> LetterCombinations(string digits)
        {
            _digits = digits;

            Backtrack(0, "");

            return _resultList;
        }

        void Backtrack(int index, string path)
        {
            if (index == _digits.Length)
            {
                if (path.Length != 0)
                {
                    StringBuilder @string = new StringBuilder(path);
                    _resultList.Add(@string.ToString());
                }
                return;
            }
            //当前index的数字。
            int curNum = _digits[index] - '0';
            string curStr = letterMap[curNum];

            for (int i = 0; i < curStr.Length; i++)
            {
                StringBuilder @string = new StringBuilder(path);
                index++;
                @string.Append(curStr[i]);
                Backtrack(index, @string.ToString());
                @string.Remove(@string.Length - 1, 1);
                index--;
            }
        }
    }
}
