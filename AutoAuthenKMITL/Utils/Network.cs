using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AutoAuthenKMITL.Utils
{
    class Network
    {
        public static bool checkShouldLoginStatus()
        {
            if (!checkForInternetConnectionGoogle() && checkForInternetConnectionKMITL())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool checkForInternetConnectionKMITL()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://www.kmitl.ac.th/en"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        private static bool checkForInternetConnectionGoogle()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("https://www.google.com/"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        private static IPAddress getDefaultGateway()
        {
            IPAddress result = null;
            var cards = NetworkInterface.GetAllNetworkInterfaces().ToList();
            if (cards.Any())
            {
                foreach (var card in cards)
                {
                    var props = card.GetIPProperties();
                    if (props == null)
                        continue;

                    var gateways = props.GatewayAddresses;
                    if (!gateways.Any())
                        continue;

                    var gateway =
                        gateways.FirstOrDefault(g => g.Address.AddressFamily.ToString() == "InterNetwork");
                    if (gateway == null)
                        continue;

                    result = gateway.Address;
                    break;
                };
            }

            return result;
        }
    }
}
