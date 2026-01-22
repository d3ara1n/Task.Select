namespace TaskSelect
{
    public static class Extensions
    {
        extension(System.Threading.Tasks.Task)
        {
            public static async Task Select<T1, T2>(Task<T1> t1, Task<T2> t2)
            {
                await Task.WhenAny(t1, t2);
            }

            public static async Task Select<T1, T2, T3>(Task<T1> t1, Task<T2> t2, Task<T3> t3)
            {
                await Task.WhenAny(t1, t2, t3);
            }

            public static async Task Select<T1, T2, T3, T4>(Task<T1> t1, Task<T2> t2, Task<T3> t3, Task<T4> t4)
            {
                await Task.WhenAny(t1, t2, t3, t4);
            }

            public static async Task Select<T1, T2, T3, T4, T5>(Task<T1> t1, Task<T2> t2, Task<T3> t3, Task<T4> t4, Task<T5> t5)
            {
                await Task.WhenAny(t1, t2, t3, t4, t5);
            }

            public static async Task Select<T1, T2, T3, T4, T5, T6>(Task<T1> t1, Task<T2> t2, Task<T3> t3, Task<T4> t4, Task<T5> t5, Task<T6> t6)
            {
                await Task.WhenAny(t1, t2, t3, t4, t5, t6);
            }


            public static async Task Select<T1, T2, T3, T4, T5, T6, T7>(Task<T1> t1, Task<T2> t2, Task<T3> t3, Task<T4> t4, Task<T5> t5, Task<T6> t6, Task<T7> t7)
            {
                await Task.WhenAny(t1, t2, t3, t4, t5, t6, t7);
            }

            public static async Task Select<T1, T2, T3, T4, T5, T6, T7, T8>(Task<T1> t1, Task<T2> t2, Task<T3> t3, Task<T4> t4, Task<T5> t5, Task<T6> t6, Task<T7> t7, Task<T8> t8)
            {
                await Task.WhenAny(t1, t2, t3, t4, t5, t6, t7, t8);
            }
        }
    }
}
