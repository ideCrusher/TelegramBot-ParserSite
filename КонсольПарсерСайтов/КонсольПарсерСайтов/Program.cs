using System;
using System.Threading;
using System.Reflection;
using System.Diagnostics;

namespace КонсольПарсерСайтов
{
    class Program
    {
        public static Thread treads1 = new Thread(Threads1);
        public static Thread treads2 = new Thread(Threads2);
        public static Thread treads3 = new Thread(Threads3);
        public static void Main(string[] args)
        {
            try
            {
                treads1.Start();
                treads2.Start();
                treads3.Start();
            }
            catch
            {
                Process.Start(Assembly.GetExecutingAssembly().Location);
                Environment.Exit(0);
            }
        }
        public static void Threads1()
        {
            Habr.Habr_Uploud();
            treads1.Abort();
        }
        public static void Threads2()
        {
            DTF.DTF_Uploud();
            treads2.Abort();
        }
        public static void Threads3()
        {
            Igromania.Igromania_Uploud();
            treads3.Abort();
        }
    }
}
