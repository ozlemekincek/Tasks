using System;
using System.Text;

namespace Tasks
{
    public partial class Program
    {
        class Task1
        {
            public int Pair(String S)
            {
                int rightCount = 0, leftCount = 0,
                        result = 0, changes = 0;
                var current = new StringBuilder();
                var old = new StringBuilder();

                for (int i = 0; i < S.Length; i++)
                {
                    current.Append(S[i]);
                    if (S[i] == 'R')
                        rightCount++;
                    else
                        leftCount++;

                    if (i > 0 && S[i - 1] != S[i])                    
                        changes++;
                    
                    if (changes > 0)
                    {
                        if (rightCount == leftCount && !old.Equals(current))
                        {
                            result++;
                            old.Clear();
                            old.Append(current);
                            current.Clear();

                        }
                    }
                    if (i == S.Length - 1 && changes == 1 && rightCount == leftCount && !old.Equals(current))
                        result++;
                }
                return result;
            }
        }

    }
}