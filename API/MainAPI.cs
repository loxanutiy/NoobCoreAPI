using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class MainAPI
    {
        public User ReadUser(string username)
        {
            User finalizeduser = new User();
            
            return finalizeduser;
        }

        public async Task<string> GetUserResponse(string username, string password)
        {
            using (var client = new WebClient())
            {
                var reqparm = new System.Collections.Specialized.NameValueCollection()
                {
                    { "username", username },
                    { "passwd", password }
                };
                byte[] responsebytes = await client.UploadValuesTaskAsync("https://passport.yandex.ru/passport?mode=auth&retpath=https://mail.yandex.ru", reqparm);
                string response = Encoding.UTF8.GetString(responsebytes);
                return response;
            }
        }
    }
}
