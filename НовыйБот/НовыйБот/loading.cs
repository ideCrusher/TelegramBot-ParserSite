using System.Collections;
using System.IO;

namespace НовыйБот
{
    class loading
    {
        public static ArrayList Habr_ALL = new ArrayList();
        public static ArrayList Habr_DEV = new ArrayList();
        public static ArrayList Habr_ADMIN = new ArrayList();
        public static ArrayList Habr_DISGN = new ArrayList();
        public static ArrayList Habr_MANEGM = new ArrayList();
        public static ArrayList Habr_MARKET = new ArrayList();
        public static ArrayList Habr_LABCHOP = new ArrayList();
        public static void Habr()
        {
            Habr_ALL.Clear();
            Habr_DEV.Clear();
            Habr_ADMIN.Clear();
            Habr_DISGN.Clear();
            Habr_MANEGM.Clear();
            Habr_MARKET.Clear();
            Habr_LABCHOP.Clear();
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/habr/ALL.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if(line != "")
                    {
                        Habr_ALL.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/habr/DEV.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        Habr_DEV.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/habr/ADMIN.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        Habr_ADMIN.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/habr/DISGN.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        Habr_DISGN.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/habr/MENEGM.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        Habr_MANEGM.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/habr/MARKET.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        Habr_MARKET.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/habr/LABCHOP.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        Habr_LABCHOP.Add(line);
                    }
                }
            }
        }
        public static ArrayList DTF_GAMES = new ArrayList();
        public static ArrayList DTF_MANDS = new ArrayList();
        public static ArrayList DTF_INDUST = new ArrayList();
        public static ArrayList DTF_GAMEDEV = new ArrayList();
        public static ArrayList DTF_LIVE = new ArrayList();
        public static ArrayList DTF_IRON = new ArrayList();
        public static void DTF()
        {
            DTF_GAMES.Clear();
            DTF_MANDS.Clear();
            DTF_INDUST.Clear();
            DTF_GAMEDEV.Clear();
            DTF_LIVE.Clear();
            DTF_IRON.Clear();
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/DTF/GAMES.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        DTF_GAMES.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/DTF/MANDS.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        DTF_MANDS.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/DTF/INDUST.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        DTF_INDUST.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/DTF/GAMEDEV.TXT"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        DTF_GAMEDEV.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/DTF/LIVE.TXT"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        DTF_LIVE.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/DTF/IRON.TXT"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        DTF_IRON.Add(line);
                    }
                }
            }
        }
        public static ArrayList Igromania_GAMES = new ArrayList();
        public static ArrayList Igromania_MOVES = new ArrayList();
        public static ArrayList Igromania_INDUST = new ArrayList();
        public static ArrayList Igromania_IRON = new ArrayList();
        public static ArrayList Igromania_SALE = new ArrayList();
        public static ArrayList Igromania_CYBERS = new ArrayList();

        public static void Igromania()
        {
            Igromania_GAMES.Clear();
            Igromania_MOVES.Clear();
            Igromania_INDUST.Clear();
            Igromania_IRON.Clear();
            Igromania_SALE.Clear();
            Igromania_CYBERS.Clear();
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/Igromania/GAMES.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        Igromania_GAMES.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/Igromania/MOVES.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        Igromania_MOVES.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/Igromania/INDUST.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        Igromania_INDUST.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/Igromania/IRON.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        Igromania_IRON.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/Igromania/SALE.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        Igromania_SALE.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader("C:/Users/User/Desktop/Бот+Парсер+Потоки/SAVE/Igromania/CYBERS.txt"))
            {
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        Igromania_CYBERS.Add(line);
                    }
                }
            }
        }

    }
}
