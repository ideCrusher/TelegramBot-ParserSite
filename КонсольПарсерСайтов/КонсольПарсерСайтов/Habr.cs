using System.Collections;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace КонсольПарсерСайтов
{
    class Habr
    {
        public static ArrayList Habr_ALL = new ArrayList();
        public static ArrayList Habr_DEV = new ArrayList();
        public static ArrayList Habr_ADMIN = new ArrayList();
        public static ArrayList Habr_DISGN = new ArrayList();
        public static ArrayList Habr_MANEGM = new ArrayList();
        public static ArrayList Habr_MARKET = new ArrayList();
        public static ArrayList Habr_LABCHOP = new ArrayList();
        static string[] Link_Habr_ALL = { "https://habr.com/ru/news/", "/html/body/div[1]/div[3]/div/div[1]/div[1]/div[3]/ul", "//li/article/h2/a", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/habr/ALL.txt" };
        static string[] Link_Habr_DEV = { "https://habr.com/ru/flows/develop/news/", "/html/body/div[1]/div[3]/div/div/div[1]/div[3]/ul", "//li/article/h2/a", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/habr/DEV.txt" };
        static string[] Link_Habr_ADMIN = { "https://habr.com/ru/flows/admin/news/", "/html/body/div[1]/div[3]/div/div/div[1]/div[3]/ul", "//li/article/h2/a", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/habr/ADMIN.txt" };
        static string[] Link_Habr_DISGN = { "https://habr.com/ru/flows/design/news/", "/html/body/div[1]/div[3]/div/div/div[1]/div[3]/ul", "//li/article/h2/a", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/habr/DISGN.txt" };
        static string[] Link_Habr_MENEGM = { "https://habr.com/ru/flows/management/news/", "/html/body/div[1]/div[3]/div/div/div[1]/div[3]/ul", "//li/article/h2/a", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/habr/MENEGM.txt" };
        static string[] Link_Habr_MARKET = { "https://habr.com/ru/flows/marketing/news/", "/html/body/div[1]/div[3]/div/div/div[1]/div[3]/ul", ".//li/article/h2/a", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/habr/MARKET.txt" };
        static string[] Link_Habr_LABCHOP = { "https://habr.com/ru/flows/popsci/news/", "/html/body/div[1]/div[3]/div/div/div[1]/div[3]/ul", "//li/article/h2/a", "C:/Users/Zver/Desktop/Бот+Парсер+Потоки/SAVE/habr/LABCHOP.txt" };
        public static void Habr_Uploud()
        {
            string[] URL = { "", "", "" };
            ArrayList Trans = new ArrayList();
            string linkes = "";
            int A = 0;
            while (A < 7)
            {
                switch (A)
                {
                    case 0:
                        URL[0] = Link_Habr_ALL[0];
                        URL[1] = Link_Habr_ALL[1];
                        URL[2] = Link_Habr_ALL[2];
                        linkes = Link_Habr_ALL[3];
                        break;
                    case 1:
                        URL[0] = Link_Habr_DEV[0];
                        URL[1] = Link_Habr_DEV[1];
                        URL[2] = Link_Habr_DEV[2];
                        linkes = Link_Habr_DEV[3];
                        break;
                    case 2:
                        URL[0] = Link_Habr_ADMIN[0];
                        URL[1] = Link_Habr_ADMIN[1];
                        URL[2] = Link_Habr_ADMIN[2];
                        linkes = Link_Habr_ADMIN[3];
                        break;
                    case 3:
                        URL[0] = Link_Habr_DISGN[0];
                        URL[1] = Link_Habr_DISGN[1];
                        URL[2] = Link_Habr_DISGN[2];
                        linkes = Link_Habr_DISGN[3];
                        break;
                    case 4:
                        URL[0] = Link_Habr_MENEGM[0];
                        URL[1] = Link_Habr_MENEGM[1];
                        URL[2] = Link_Habr_MENEGM[2];
                        linkes = Link_Habr_MENEGM[3];
                        break;
                    case 5:
                        URL[0] = Link_Habr_MARKET[0];
                        URL[1] = Link_Habr_MARKET[1];
                        URL[2] = Link_Habr_MARKET[2];
                        linkes = Link_Habr_MARKET[3];
                        break;
                    case 6:
                        URL[0] = Link_Habr_LABCHOP[0];
                        URL[1] = Link_Habr_LABCHOP[1];
                        URL[2] = Link_Habr_LABCHOP[2];
                        linkes = Link_Habr_LABCHOP[3];
                        break;
                }
                IWebDriver driver = new ChromeDriver();
                driver.Url = URL[0];
                driver.FindElement(By.XPath($@"{URL[1]}"));
                var links = driver.FindElements(By.XPath($"{URL[2]}"));
                foreach (IWebElement link in links)
                {
                    Trans.Add($"{link.Text} - {link.GetAttribute("href")}\n");
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
