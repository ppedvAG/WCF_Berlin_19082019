using System.Runtime.Serialization;
using System.ServiceModel;

namespace SelfHost.Contracts
{
    [ServiceContract]
    public interface IWetterService
    {
        [OperationContract]
        [FaultContract(typeof(OrtErrorInfo))]
        double GetTemperatur(string ort);
    }

    [DataContract]
    public class OrtErrorInfo
    {
        [DataMember]
        public string Info { get; set; }
    }

}
