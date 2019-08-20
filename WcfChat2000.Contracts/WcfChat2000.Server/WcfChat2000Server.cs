using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using WcfChat2000.Contracts;

namespace WcfChat2000.Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    class WcfChat2000Server : IServer
    {

        Dictionary<string, IClient> users = new Dictionary<string, IClient>();

        public void Login(string username)
        {
            Console.WriteLine($"Login: {username}");

            if (users.ContainsKey(username))
                OperationContext.Current.GetCallbackChannel<IClient>().LoginResponse(false, "Der Benutzername ist bereits in verwendung");
            else
            {
                var channel = OperationContext.Current.GetCallbackChannel<IClient>();
                users.Add(username, channel);

                channel.LoginResponse(true, "");
                channel.ShowText($"Hallo {username}");
                channel.ShowUsers(users.Keys);
                ExecuteForAllUsers(x => x.ShowUsers(users.Keys));

            }

        }

        public void Logout()
        {
            Console.WriteLine($"Logout");
        }

        public void SendPic(Stream pic)
        {
            Console.WriteLine($"SendPic ...");

            var ms = new MemoryStream();
            pic.CopyTo(ms);
            ExecuteForAllUsers(x =>
            {
                ms.Position = 0;
                x.ShowPic(ms);
            });
        }

        public void SendText(string text)
        {
            Console.WriteLine($"SendText: {text}");

            var caller = OperationContext.Current.GetCallbackChannel<IClient>();
            var callerEntry = users.FirstOrDefault(x => x.Value == caller);

            var msg = $"[{callerEntry.Key}] {text}";

            ExecuteForAllUsers(x => x.ShowText(msg));
        }

        private void ExecuteForAllUsers(Action<IClient> action)
        {
            var caller = OperationContext.Current.GetCallbackChannel<IClient>();
            var callerEntry = users.FirstOrDefault(x => x.Value == caller);

            foreach (var item in users.ToList())
            {
                try
                {
                    action.Invoke(item.Value);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Fehler: {ex.Message}");
                    users.Remove(item.Key);
                    Console.WriteLine($"{item.Key} wurde entfernt");
                    ExecuteForAllUsers(x => x.ShowUsers(users.Keys));
                }
            }
        }

    }
}
