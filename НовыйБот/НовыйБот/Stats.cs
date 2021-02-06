
using System.Linq;

namespace НовыйБот
{
    class Stats
    {
        public static int[] HabrStats = { 0, 0, 0, 0, 0, 0, 0 };
        public static string[] HabrStrings = {"Все потоки", "Менеджмент" , "Маркетинг" , "Разработка" , "Администрирование" , "Дизайн" , "Научпоп" };

        public static int[] DTFStats = { 0, 0, 0, 0, 0, 0};
        public static string[] DTFStrings = { "Игры" , "Кино и сериалы" , "Индустрия" , "Gamedev" , "Жизнь" , "Железо" };

        public static int[] IgromStats = { 0, 0, 0, 0, 0, 0};
        public static string[] IgromStrings = { "Игрoвые" , "Кино" , "Индуcтрия" , "Железные" , "Скидки" , "Киберспорт" };

        public static int MaxInt, MinInt,ALL;
        public static string ThemsMax, ThemsMin, MaxS, MinS;

        public static void CountStats()
        {
            ALL = 0;
            ThemsMax = "";
            ThemsMin = "";
            int[] MaxX = { HabrStats.Max(), DTFStats.Max(), IgromStats.Max() };
            int[] MinN = { HabrStats.Min(), DTFStats.Min(), IgromStats.Min() };       
            MaxInt = MaxX.Max();
            MinInt = MinN.Min(); 
            for(int i = 0; i<HabrStats.Length; i++)
            {
                ALL = ALL + HabrStats[i];
                if (HabrStats[i] == MaxInt)
                {
                    ThemsMax = "Habr";
                    MaxS = HabrStrings[i];
                }
                if(HabrStats[i] == MinInt)
                {
                    ThemsMin = "Habr";
                    MinS = HabrStrings[i];
                }
            }
            for (int i = 0; i < DTFStats.Length; i++)
            {
                ALL = ALL + DTFStats[i];
                if (DTFStats[i] == MaxInt)
                {
                    ThemsMax = "DTF";
                    MaxS = DTFStrings[i];
                }
                if(DTFStats[i] == MinInt)
                {
                    ThemsMin = "DTF";
                    MinS = DTFStrings[i];
                }
            }
            for (int i = 0; i < IgromStats.Length; i++)
            {
                ALL = ALL + IgromStats[i];
                if (IgromStats[i] == MaxInt)
                {
                    ThemsMax = "Igromania";
                    MaxS = IgromStrings[i];
                }
                if(IgromStats[i] == MinInt)
                {
                    ThemsMin = "Igromania";
                    MinS = IgromStrings[i];
                }
            }
        }
    }
}
