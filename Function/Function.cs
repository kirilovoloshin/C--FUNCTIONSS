
namespace Function
{
    public enum SortOrder { Ascending, Descending }
    public static class Function
    {
        public static bool IsSorted(int[] array, SortOrder order)
        {
            var flag = true;
            
            if(order == SortOrder.Ascending)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                        flag = false;
                }
            }else if (order == SortOrder.Descending)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                        flag = false;
                }
            }
            return flag;
        }
        public static void Transform(int[] array, SortOrder order)
        {
            if (!IsSorted(array, order)) return;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += i;
            }
        }
       
        public static double MultArithmeticElements(double a, double t, int n)
        {
            var sum = a;

            for (int i = 0; i < n-1; i++)
            {
                a += t;
                sum *= a;
            }

            return sum;
        }
        public static double SumGeometricElements(double a, double t, double alim)
        {
            var sum =0d;
            while (a > alim)
            {
                sum += a;
                a *= t;
            }

            return sum;
        }
    }
}

