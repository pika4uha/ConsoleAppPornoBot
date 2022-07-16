using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPornoBot
{
    internal class GuessNumberGame
    {
        private Random random;
        private int compNumber;
        private int countPornoWatching;
        private int pornoLinkLenght;

        private List<string> pornoLink = new List<string>() { "https://vk.cc/cf6UcU", "https://vk.cc/cf6Umv", "https://vk.cc/cf6Upv", "https://vk.cc/cf6UDO", "https://vk.cc/cf6UFT", "https://vk.cc/cf6UJ4", "https://vk.cc/cf6UKQ", "https://vk.cc/cf6UQt", "https://vk.cc/cf6USa", "https://vk.cc/cf6UTg" }; //старт с 0

        private List<string> pornoGif = new List<string>() { "https://media1.tenor.com/images/ac490638afc4207e74156126798ba6b7/tenor.gif?itemid=26217013" };

        public GuessNumberGame()
        {
            random = new Random();
        }

        private void Init()
        {
            compNumber = random.Next(1, 10 + 1);
        }

        private void HowManyTimes()
        {
            countPornoWatching++;
        }

        private void ListLenght()
        {
            pornoLinkLenght = pornoLink.Count;
        }

        public string ProcessMessage(string messageText)
        {
            switch (messageText)
            {
                case "/start":
                    return "Вы запустили бота, используйте команду /help чтобы узнать больше 👋";

                case "/help":
                    return $"/get_porno - Получить ссылку на порно\n/how_many_times - Узнать, сколько я смотрел порно\n/how_many_links - Узнать, сколько порно у нас в коллекции\nСвязь с администрацией 🤙: https://t.me/pika4uha";

                case "/how_many_times":
                    return $"Я в шоке, вы смотрели порно {countPornoWatching} раз 😮";

                case "/get_porno":
                    Init();
                    HowManyTimes();
                    return $"🤙" +
                        $"Вы можете скачать нашу фирменную гифку:{pornoGif[0]}\n\n👉Ваша ссылка:{pornoLink[compNumber]}";

                case "/how_many_links":
                    ListLenght();
                    return $"У нас в коллекции {pornoLinkLenght} самых сочных видео 😎";

                default:
                    return "неизвестная команда, /help";

            }
        }
    }
}
