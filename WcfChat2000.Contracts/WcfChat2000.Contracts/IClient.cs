using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.Text;

namespace WcfChat2000.Contracts
{
    [ServiceContract]
    public interface IClient
    {
        [OperationContract(IsOneWay = true)]
        void LoginResponse(bool ok, string msg);

        [OperationContract(IsOneWay = true)]
        void ShowText(string text);

        [OperationContract(IsOneWay = true)]
        void ShowPic(Stream pic);

        [OperationContract(IsOneWay = true)]
        void ShowUsers(IEnumerable<string> users);
    }
}
