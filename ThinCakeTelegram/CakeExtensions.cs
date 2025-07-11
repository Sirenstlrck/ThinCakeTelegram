using Cake.Core;
using Cake.Core.Annotations;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace ThinCakeTelegram;

public static class CakeExtensions
{
  [CakeMethodAlias]
  public static void SendTelegramMessage(this ICakeContext context, string botToken, long chatId, string message)
  {
    var bot = new TelegramBotClient(botToken);
    bot.SendMessage(chatId, message).Wait();
  }

  [CakeMethodAlias]
  public static void SendTelegramDocument(this ICakeContext context, string botToken, long chatId, string caption, Stream content)
  {
    var bot = new TelegramBotClient(botToken);
    bot.SendDocument(chatId, InputFile.FromStream(content), caption).Wait();
  }
}
