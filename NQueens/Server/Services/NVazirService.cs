namespace NQueens.Server.Services
{
    public class NVazirService
    {
        //  public int[] col;
        public Array col;
        public List<int> answers = new List<int>();
        static int N;
        public NVazirService(int n)
        {
            col = Array.CreateInstance(typeof(int), new int[1] { n }, new int[1] { 1 });
            //  col = new int[n+1];
            N = n;


        }
        public void Queens(int i)
        {
            if (Promising(i))
            {

                if (i == N)
                {

                    foreach (var item in col)
                    {
                        // if(item!=0)
                        // answers.Add(item);
                        answers.Add((int)item);
                    }
                    return;
                }

                else
                {
                    i++;
                    for (int j = 1; j <= N; j++)
                    {
                        // col[i]=j;
                        col.SetValue(j, i);
                        Queens(i);
                    }

                }
            }
        }
        public bool Promising(int i)
        {
            int k;
            bool check;
            k = 1;
            check = true;
            while (k < i && check)
            {
                int col_i = Convert.ToInt32(col.GetValue(i));
                int col_k = Convert.ToInt32(col.GetValue(k));

                if (col_i == col_k || Math.Abs(col_i - col_k) == i - k)
                    check = false;
                k++;
            }
            return check;
        }

    }
}
