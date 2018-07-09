using System;
using System.Reflection;
using _Model;
namespace _20180709Property
{
    class Program
    {
        static void Main(string[] args)
        {
            ProPertiesFun<model>();
        }

        public static void ProPertiesFun<T>()
        {
            var GetProPertie = typeof(T).GetProperties();
            var TModel = Activator.CreateInstance<T>();

            foreach (var p in GetProPertie)
            {
                if (p.PropertyType == typeof(string))
                {
                    p.SetValue(TModel, "1234");
                }
                else
                {
                    p.SetValue(TModel, 123);
                }
            }
        }
    }
}
