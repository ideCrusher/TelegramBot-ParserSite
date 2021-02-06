using System;
using System.ComponentModel;
using System.Windows.Forms;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace НовыйБот
{
    public partial class Main : Form
    {
        BackgroundWorker bw;
        public static Main m = new Main();
        public Main()
        {
            InitializeComponent();
            bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork; // метод bw_DoWork будет работать асинхронно
        }
        private void Main_Load(object sender, EventArgs e)
        {
            m = this;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            BtnRunClick();
            loading.Habr();
            loading.DTF();
            loading.Igromania();

            Monitoring Mon = new Monitoring();
            Mon.Show();

            button1.Enabled = false;
            textBox1.Enabled = false;

           

        }
        void BtnRunClick()
        {
            var text = textBox1.Text; // получаем содержимое текстового поля txtKey в переменную text
            if (bw.IsBusy != true)
            {
                bw.RunWorkerAsync(text); // передаем эту переменную в виде аргумента методу bw_DoWork
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        async void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            var key = e.Argument as String; // получаем ключ из аргументов
            try
            {
                var Bot = new Telegram.Bot.TelegramBotClient(key); // инициализируем API
                await Bot.SetWebhookAsync("");
                //Bot.SetWebhook(""); // Обязательно! убираем старую привязку к вебхуку для бота
                int offset = 0; // отступ по сообщениям
                while (true)
                {
                    var updates = await Bot.GetUpdatesAsync(offset); // получаем массив обновлений
                    foreach (var update in updates) // Перебираем все обновления
                    {
                        var message = update.Message;
                        if (message.Type == MessageType.Text)
                        {
                            if (message.Text == "/start" || message.Text == "Назад")
                            {
                                var replyKeyboardMarkup = new ReplyKeyboardMarkup(
                                new KeyboardButton[][]
                                {
                                  new[]
                                  {
                                      new KeyboardButton("Habr"),
                                      new KeyboardButton("DTF"),
                                      new KeyboardButton("Igromania"),
                                  },
                                  new[]
                                  {
                                      new KeyboardButton("О Боте"),
                                  },
                                  },
                                resizeKeyboard: true
                                );
                                await Bot.SendTextMessageAsync(message.Chat.Id, "Выбирай! ", ParseMode.Default, false, false, 0, replyKeyboardMarkup);
                            }
                            if (message.Text == "Habr")
                            {
                                var replyKeyboardMarkup = new ReplyKeyboardMarkup(
                            new KeyboardButton[][]
                            {
                                  new[]
                                  {
                                      new KeyboardButton("Все потоки"),
                                      new KeyboardButton("Менеджмент"),
                                      new KeyboardButton("Маркетинг"),
                                  },
                                  new[]
                                  {
                                      new KeyboardButton("Разработка"),
                                      new KeyboardButton("Администрирование"),
                                      new KeyboardButton("Дизайн"),
                                      new KeyboardButton("Научпоп"),
                                  },
                                  new[]
                                  {
                                      new KeyboardButton("Назад"),
                                  },
                              },
                            resizeKeyboard: true
                            );
                                await Bot.SendTextMessageAsync(message.Chat.Id, "Выбирай!", ParseMode.Default, false, false, 0, replyKeyboardMarkup);
                            }
                            if (message.Text == "Все потоки")
                            {
                                Stats.HabrStats[0] += 1;
                                for (int i = 0; i <5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.Habr_ALL[i].ToString());
                                }
                            }
                            if (message.Text == "Менеджмент")
                            {
                                Stats.HabrStats[1] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.Habr_DEV[i].ToString());
                                }
                            }
                            if (message.Text == "Маркетинг")
                            {
                                Stats.HabrStats[2] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.Habr_ADMIN[i].ToString());
                                }
                            }
                            if (message.Text == "Разработка")
                            {
                                Stats.HabrStats[3] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.Habr_DISGN[i].ToString());
                                }
                            }
                            if (message.Text == "Администрирование")
                            {
                                Stats.HabrStats[4] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.Habr_MANEGM[i].ToString());
                                }
                            }
                            if (message.Text == "Дизайн")
                            {
                                Stats.HabrStats[5] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.Habr_MARKET[i].ToString());
                                }
                            }
                            if (message.Text == "Научпоп")
                            {
                                Stats.HabrStats[6] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.Habr_LABCHOP[i].ToString());
                                }
                            }
                            if (message.Text == "DTF")
                            {
                            var replyKeyboardMarkup = new ReplyKeyboardMarkup(
                            new KeyboardButton[][]
                            {
                                  new[]
                                  {
                                      new KeyboardButton("Игры"),
                                      new KeyboardButton("Кино и сериалы"),
                                      new KeyboardButton("Индустрия"),
                                  },
                                  new[]
                                  {
                                      new KeyboardButton("Gamedev"),
                                      new KeyboardButton("Жизнь"),
                                      new KeyboardButton("Железо"),
                                  },
                                  new[]
                                  {
                                      new KeyboardButton("Назад"),
                                  },
                              },
                            resizeKeyboard: true
                            );
                                await Bot.SendTextMessageAsync(message.Chat.Id, "Выбирай!", ParseMode.Default, false, false, 0, replyKeyboardMarkup);
                            }
                            if (message.Text == "Игры")
                            {
                                Stats.DTFStats[0] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.DTF_GAMES[i].ToString());
                                }
                            }
                            if (message.Text == "Кино и сериалы")
                            {
                                Stats.DTFStats[1] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.DTF_MANDS[i].ToString());
                                }
                            }
                            if (message.Text == "Индустрия")
                            {
                                Stats.DTFStats[2] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.DTF_INDUST[i].ToString());
                                }
                            }
                            if (message.Text == "Gamedev")
                            {
                                Stats.DTFStats[3] += 1;
                                for (int i = 1; i < 6; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.DTF_GAMEDEV[i].ToString());
                                }
                            }
                            if (message.Text == "Жизнь")
                            {
                                Stats.DTFStats[4] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.DTF_LIVE[i].ToString());
                                }
                            }
                            if (message.Text == "Железо")
                            {
                                Stats.DTFStats[5] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.DTF_IRON[i].ToString());
                                }
                            }
                            if(message.Text == "Help" || message.Text == "О Боте")
                            {
                                await Bot.SendTextMessageAsync(message.Chat.Id,"Five news - это новостной бот, который по запросу отправляет вам новости на ваш выбор.");
                                await Bot.SendTextMessageAsync(message.Chat.Id,"Бот разработал Язовский EVG Евгений.");
                            }
                            if (message.Text == "Igromania")
                            {
                                var replyKeyboardMarkup = new ReplyKeyboardMarkup(
                                new KeyboardButton[][]
                                {
                                  new[]
                                  {
                                      new KeyboardButton("Игрoвые"),
                                      new KeyboardButton("Кино"),
                                      new KeyboardButton("Индуcтрия"),
                                  },
                                  new[]
                                  {
                                      new KeyboardButton("Железные"),
                                      new KeyboardButton("Скидки"),
                                      new KeyboardButton("Киберспорт"),
                                  },
                                  new[]
                                  {
                                      new KeyboardButton("Назад"),
                                  },
                                  },
                                resizeKeyboard: true
                                );

                                await Bot.SendTextMessageAsync(message.Chat.Id, "Выбирай!", ParseMode.Default, false, false, 0, replyKeyboardMarkup);
                            }
                            if (message.Text == "Игрoвые")
                            {
                                Stats.IgromStats[0] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.Igromania_GAMES[i].ToString());
                                }
                            }
                            if (message.Text == "Кино")
                            {
                                Stats.IgromStats[1] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.Igromania_MOVES[i].ToString());
                                }
                            }
                            if (message.Text == "Индуcтрия")
                            {
                                Stats.IgromStats[2] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.Igromania_INDUST[i].ToString());
                                }
                            }
                            if (message.Text == "Железные")
                            {
                                Stats.IgromStats[3] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.Igromania_IRON[i].ToString());
                                }
                            }
                            if (message.Text == "Скидки")
                            {
                                Stats.IgromStats[4] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.Igromania_SALE[i].ToString());
                                }
                            }
                            if (message.Text == "Киберспорт")
                            {
                                Stats.IgromStats[5] += 1;
                                for (int i = 0; i < 5; i++)
                                {
                                    await Bot.SendTextMessageAsync(message.Chat.Id, loading.Igromania_CYBERS[i].ToString());
                                }
                            }
                        }
                        offset = update.Id + 1;
                    }
                }
            }
            catch (Telegram.Bot.Exceptions.ApiRequestException ex)
            {
                Console.WriteLine(ex.Message); // если ключ не подошел - пишем об этом в консоль отладки
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
