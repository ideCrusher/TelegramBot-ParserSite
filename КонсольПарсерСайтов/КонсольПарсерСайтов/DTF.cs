using System.Collections;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace КонсольПарсерСайтов
{
    class DTF
    {
        public static ArrayList DTF_GAMES = new ArrayList();
        public static ArrayList DTF_MANDS = new ArrayList();
        public static ArrayList DTF_INDUST = new ArrayList();
        public static ArrayList DTF_GAMEDEV = new ArrayList();
        public static ArrayList DTF_LIVE = new ArrayList();
        public static ArrayList DTF_IRON = new ArrayList();
        static string[] Link_DTF_GAMES = { "https://dtf.ru/games/entries/new", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/DTF/GAMES.TXT" };
        static string[] Link_DTF_MANDS = { "https://dtf.ru/cinema/entries/new", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/DTF/MANDS.TXT" };
        static string[] Link_DTF_INDUST = { "https://dtf.ru/gameindustry/entries/new", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/DTF/INDUST.TXT" };
        static string[] Link_DTF_GAMEDEV = { "https://dtf.ru/gamedev/entries/new", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/DTF/GAMEDEV.TXT" };
        static string[] Link_DTF_LIVE = { "https://dtf.ru/life/entries/new", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/DTF/LIVE.TXT" };
        static string[] Link_DTF_IRON = { "https://dtf.ru/hard/entries/new", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/DTF/IRON.TXT" };

        public static void DTF_Uploud()
        {
            string[] URL = {""};
            ArrayList Trans = new ArrayList();
            string linkes = "";
            int A = 0;
            while (A < 6)
            {
                switch (A)
                {
                    case 0:
                        URL[0] = Link_DTF_GAMES[0];
                        linkes = Link_DTF_GAMES[1];
                        break;
                    case 1:
                        URL[0] = Link_DTF_MANDS[0];
                        linkes = Link_DTF_MANDS[1];
                        break;
                    case 2:
                        URL[0] = Link_DTF_INDUST[0];
                        linkes = Link_DTF_INDUST[1];
                        break;
                    case 3:
                        URL[0] = Link_DTF_GAMEDEV[0];
                        linkes = Link_DTF_GAMEDEV[1];
                        break;
                    case 4:
                        URL[0] = Link_DTF_LIVE[0];
                        linkes = Link_DTF_LIVE[1];
                        break;
                    case 5:
                        URL[0] = Link_DTF_IRON[0];
                        linkes = Link_DTF_IRON[1];
                        break;                   
                }
                IWebDriver driver = new ChromeDriver();
                driver.Url = URL[0];
                var links = driver.FindElements(By.ClassName($"content-feed__link"));             
                foreach (IWebElement link in links)
                {                   
                    Trans.Add($"{link.GetAttribute("href")}\n");
                }
                StreamWriter SavevFile = new StreamWriter(linkes);
                foreach (var item in Trans)
                {
                    SavevFile.WriteLine(item);
                }
                SavevFile.Close();
                driver.Close();
                driver.Quit();
                Trans.Clear();
                A++;
            }
        }
    }
}
