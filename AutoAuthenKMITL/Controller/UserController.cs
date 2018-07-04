using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoAuthenKMITL.Controller
{
    class UserController
    {
        private static string baseURL = "https://mylogin.kmitl.ac.th:8445/PortalServer";

        public static bool sendLogin(string username,string password)
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["userName"] = username.Trim().ToString();
                data["password"] = password.Trim().ToString();
                data["validCode"] = "";
                data["authLan"] = "en";
                data["hasValidateNextUpdatePassword"] = "true";
                data["browserFlag"] = "en";
                data["ClientIp"] = "";
                wb.Headers["User-Agent"] = "CSAG_AUTOTHEN_KMITL";

                byte[] byteArray = wb.UploadValues(baseURL+"/Webauth/webAuthAction!login.action", "POST", data);
                wb.Encoding = UTF8Encoding.UTF8;

                dynamic dataOject = JsonConvert.DeserializeObject(Encoding.ASCII.GetString(byteArray));
                bool canVisitorApplication = dataOject.data.canVisitorApplication;
                if (canVisitorApplication)
                {
                    DataStrac.account = dataOject.data.account;
                    DataStrac.failCount = dataOject.data.failCount;
                    DataStrac.ip = dataOject.data.ip;
                    DataStrac.sessionId = dataOject.data.sessionId;
                    DataStrac.webHeatbeatPeriod = dataOject.data.webHeatbeatPeriod;
                    DataStrac.token = dataOject.token;
                    return true;
                }
                else
                {
                    DataStrac.failCount = dataOject.data.failCount;
                    DataStrac.sessionId = dataOject.data.sessionId;
                    return false;
                }
            }
        }
        public static bool sendHart() {
            return true;
        }
        public static bool sendLogout()
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                wb.Headers["User-Agent"] = "CSAG_AUTOTHEN_KMITL";
                wb.Headers["X-XSRF-TOKEN"] = DataStrac.token;
                byte[] byteArray = wb.UploadValues(baseURL+"/Webauth/webAuthAction!logout.action", "POST", data);
                wb.Encoding = UTF8Encoding.UTF8;
                return true;
            }
        }
    }
}
