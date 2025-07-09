using Cake.Core;
using Cake.Core.Annotations;
using Telegram.Bot;

namespace ThinCakeTelegram;

public static class CakeExtensions
{
  [CakeMethodAlias]
  public static void SendTelegramMessage(this ICakeContext context, string botToken, long chatId, string message)
  {
    var bot = new TelegramBotClient(botToken);
    bot.SendMessage(chatId, message).Wait();
  }
}
