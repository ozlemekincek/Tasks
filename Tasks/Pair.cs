using System.Collections.Generic;
using System.Linq;

namespace Tasks
{
    class Pair
    {
        public int x, y;
        public Pair() { }
        public Pair(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int MaxPair(int[] A)
        {
            Dictionary<int,
              List<Pair>> sumOfPairs = new Dictionary<int,
                                               List<Pair>>();
            for (int i = 0; i <= A.Length; i++)
            {
                for (int k = i + 1; k <= A.Length - 1; k++)
                {
                    int sum = A[i] + A[k];

                    if (sumOfPairs.ContainsKey(sum))
                    {
                        List<Pair> newPair = sumOfPairs[sum];
                        bool isExist = false;
                        for (int p = 0; p < sumOfPairs[sum].Count; p++)
                        {
                            int x = sumOfPairs[sum][p].x;
                            int y = sumOfPairs[sum][p].y;

                            if ((x == i || x == k) ||
                                (y == i || y == k))
                            {
                                isExist = true;
                            }

                        }
                        if (!isExist)
                            newPair.Add(new Pair(i, k));

                        sumOfPairs[sum] = newPair;
                    }
                    else
                    {
                        sumOfPairs[sum] = new List<Pair>();
                        sumOfPairs[sum].Add(new Pair(i, k));
                    }

                }

            }
            return sumOfPairs.Select(x => x.Value.Count).Max();
        }

    }
}