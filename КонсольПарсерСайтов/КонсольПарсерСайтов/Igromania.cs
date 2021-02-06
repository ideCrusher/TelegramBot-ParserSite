using System.Collections;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace КонсольПарсерСайтов
{
    class Igromania
    {
        public static ArrayList Igromania_GAMES = new ArrayList();
        public static ArrayList Igromania_MOVES = new ArrayList();
        public static ArrayList Igromania_INDUST = new ArrayList();
        public static ArrayList Igromania_IRON = new ArrayList();
        public static ArrayList Igromania_SALE = new ArrayList();
        public static ArrayList Igromania_CYBERS = new ArrayList();
        static string[] Link_Igromania_GAMES = { "https://www.igromania.ru/news/game/", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/Igromania/GAMES.txt" };              
        static string[] Link_Igromania_MOVES = { "https://www.igromania.ru/news/kino/", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/Igromania/MOVES.txt" };
        static string[] Link_Igromania_INDUST = { "https://www.igromania.ru/news/industry/", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/Igromania/INDUST.txt" };
        static string[] Link_Igromania_IRON = { "https://www.igromania.ru/news/hard/", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/Igromania/IRON.txt" };
        static string[] Link_Igromania_SALE = { "https://www.igromania.ru/news/sale/", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/Igromania/SALE.txt" };
        static string[] Link_Igromania_CYBERS = { "https://www.igromania.ru/news/cybersport/", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/Igromania/CYBERS.txt" };
        public static void Igromania_Uploud()
        {
            string[] URL = { "", "", "" };
            ArrayList Trans = new ArrayList();
            string linkes = "";
            int A = 0;
            while (A < 6)
            {
                switch (A)
                {
                    case 0:
                        URL[0] = Link_Igromania_GAMES[0];
                        linkes = Link_Igromania_GAMES[1];
                        break;
                    case 1:
                        URL[0] = Link_Igromania_MOVES[0];
                        linkes = Link_Igromania_MOVES[1];
                        break;
                    case 2:
                        URL[0] = Link_Igromania_INDUST[0];
                        linkes = Link_Igromania_INDUST[1];
                        break;
                    case 3:
                        URL[0] = Link_Igromania_IRON[0];
                        linkes = Link_Igromania_IRON[1];
                        break;
                    case 4:
                        URL[0] = Link_Igromania_SALE[0];
                        linkes = Link_Igromania_SALE[1];
                        break;
                    case 5:
                        URL[0] = Link_Igromania_CYBERS[0];
                        linkes = Link_Igromania_CYBERS[1];
                        break;
                }
                IWebDriver driver = new ChromeDriver();
                driver.Url = URL[0];
                var links = driver.FindElements(By.ClassName("aubli_name"));
                foreach (IWebElement link in links)
                {
                    Trans.Add($"{link.Text} - {link.GetAttribute("href")} \n");
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
