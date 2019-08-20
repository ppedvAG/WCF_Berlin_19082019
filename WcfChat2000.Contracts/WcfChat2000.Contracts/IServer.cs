using System.IO;
using System.ServiceModel;

namespace WcfChat2000.Contracts
{
    [ServiceContract(CallbackContract = typeof(IClient))]
    public interface IServer
    {
        [OperationContract(IsOneWay = true)]
        void SendText(string text);

        [OperationContract(IsOneWay = true)]
        void SendPic(Stream pic);

        [OperationContract(IsOneWay = true)]
        void Login(string username);

        [OperationContract(IsOneWay = true)]
        void Logout();
    }
}
