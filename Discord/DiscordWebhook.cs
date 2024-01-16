using Newtonsoft.Json;
using System.Collections.Specialized;
using System.IO;
using System.Net;

namespace DuvyGuard_Firewall
{
    class DiscordWebhook
    {
        private static readonly string DiscordWebhookUrl = Main.discordWebhookUrl;

        public static void SendEmbed(string descripcion, string color, string autor, string titulo)
        {
            string token = DiscordWebhookUrl;

            WebRequest wr = (HttpWebRequest)WebRequest.Create(token);
            wr.ContentType = "application/json";
            wr.Method = "POST";

            using (StreamWriter sw = new StreamWriter(wr.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(new
                {
                    username = "DuvyGuard",
                    embeds = new[]
                    {
                        new
                        {
                            description = descripcion,
                            title = titulo,
                            color = color,
                            avatar_url = "https://i.imgur.com/mQsCOHj.png",
                            thumbnail = new
                            {
                                url = "https://i.imgur.com/mQsCOHj.png"
                                //width = thumbnailWidth,
                                //height = thumbnailHeight
                            },
                            author = new
                            {
                                name = autor,
                                icon_url = "https://i.imgur.com/mQsCOHj.png"
                            },
                            footer = new
                            {
                                text = "DuvyGuard Firewall © 2024",
                                icon_url = "https://i.imgur.com/mQsCOHj.png"
                            }
                        }
                    }
                });

                sw.Write(json);
            }

            HttpWebResponse response = (HttpWebResponse)wr.GetResponse();
        }

        public static byte[] Post(string url, NameValueCollection pairs)
        {
            using (WebClient webClient = new WebClient())
            {
                return webClient.UploadValues(url, pairs);
            }
        }

        public static void SendPlainText(string msg)
        {
            Post(DiscordWebhookUrl, new NameValueCollection()
            {
                {
                    "username",
                    "DuvyGuard"
                },
                {
                    "avatar_url",
                    "https://i.imgur.com/mQsCOHj.png"
                },
                {
                    "content",
                    msg
                }
            });
        }
    }
}
