using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * xinxin@jpush.cn
 * 2013-12-12
 */
namespace JPushApiClient
{
    /**
     * 
     * 发送信息对象
     */
    partial class Example
    {
        static void Main(string[] args)
        {
            Console.Write("************");
            Console.WriteLine();

            String result;
            String master_secret = "570f9aadcffe791658dde66b";
            String app_key = "7ebc243ae2b37128472b0875";
            int sendno = 9;
            JPushClient client = new JPushClient(app_key, master_secret, 0);
            result = client.sendNotificationByTag("tag", sendno, "des", "tag notify title", "tag notify content", "android", "", "");

            Console.Write("sendNotificationByTag************" + result);
            Console.WriteLine();



            //
            sendno++;
            result = client.sendCustomMesByTag("tag", sendno, "des", "tag notify title", "tag notify content", "android", "", "");

            Console.Write("sendNotificationByTag************" + result);
            Console.WriteLine();

            //
            sendno++;
            result = client.sendNotificationByAlias("alias", sendno, "des", "tag notify title", "tag notify content", "android", "", "");

            Console.Write("sendNotificationByTag************" + result);
            Console.WriteLine();

            //
            sendno++;
            result = client.sendCustomMesByAlias("alias", sendno, "des", "tag notify title", "tag notify content", "android", "", "");

            Console.Write("sendNotificationByTag************" + result);
            Console.WriteLine();
            //
            //
            sendno++;
            result = client.sendNotificationByAppkey(sendno, "des", "tag notify title", "tag notify content", "android", "", "");

            Console.Write("sendNotificationByTag************" + result);
            Console.WriteLine();
            //
            //
            sendno++;
            result = client.sendCustomMesByAppkey(sendno, "des", "tag notify title", "tag notify content", "android", "", "");

            Console.Write("sendNotificationByTag************" + result);
            Console.WriteLine();

            String msg_ids = "929123086,1197558554";
            result = client.getReceivedApi(msg_ids);

            Console.Write("sendNotificationByTag************" + result);
            Console.WriteLine();
        }
    }
}