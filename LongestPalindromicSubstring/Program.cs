using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Key-in a string:");
            while (true)
            {
                string input = Console.ReadLine();
                Console.WriteLine(PalindromicString(input));
            }
        }

        static string PalindromicString(string s)
        {
            int i = 0, j = 0, k=0;
            string answer = string.Empty;
            int answerLength = 0;
            int currentLength = 0;
            int stringLength = s.Length;
            while (i< stringLength){
                //if(i< stringLength-1) j = i + 1;
                //if(i> 0) k = i - 1;
                k = j = i;
                while (k >= 0 && j < stringLength)
                {
                    if (s[i] == s[j] )
                    {
                        j++;
                    }else if(s[i] == s[k])
                    {
                        k--;
                    }
                    else
                    {
                        break;
                    }
                }
                        k++;
                        j--;
                while (k > 0 && j < stringLength-1)
                {
                    if(s[k] == s[j])
                    {
                    j++;
                    k--;
                    }
                    else { break; }
                }
                k++;
                j--;
                //while (s[i] == s[j] && j< stringLength-1)
                //{
                //    j++;
                //}
                //while (s[i] == s[k] && k > 0)
                //{
                //    k--;
                //}
                //while(s[k] == s[j])
                //{
                //    if (j == stringLength) break;
                //    if (k == 0) break;
                //    j++;
                //    k--;
                //}
                currentLength = j - k + 1;
                if (answerLength < currentLength)
                {
                    answerLength = currentLength;
                    answer = s.Substring(k, answerLength);
                }
                i++;
            }
            return answer;
        }
    }
}
