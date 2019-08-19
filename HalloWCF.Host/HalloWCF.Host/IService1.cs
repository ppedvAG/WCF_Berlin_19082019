using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace HalloWCF.Host
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string WelcheWochentagIstHeute();

        [OperationContract]
        IEnumerable<Bääääh> GetAllTheBääääh();
    }

    [DataContract]
    public class Bääääh
    {
        [DataMember(Name = "BlubAnzahl")]
        public int AnzahlBlub { get; set; }
        [DataMember]
        public string Hihihihih { get; set; }

        public int SuperGeheim { get; set; }
    }
}
