using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCF_REST.Host
{
    [ServiceContract]
    interface IAutoService
    {
        [OperationContract]
        [WebGet(UriTemplate ="Autos")]
        IEnumerable<Auto> GetAllAutos();

        [OperationContract]
        [WebGet(UriTemplate = "Auto?lenk={zahl}")]
        IEnumerable<Auto> GetAutoMitAnzahlLenkräder(string zahl);

        [OperationContract]
        [WebInvoke(Method ="POST",UriTemplate ="Autos")]
        void AddAuto(Auto auto);

        [OperationContract]
        [WebInvoke(Method ="PUT",UriTemplate ="Autos")]
        void UpdateAuto(Auto auto);

        [OperationContract]
        [WebInvoke(Method ="DELETE",UriTemplate ="Auto?id={id}")]
        void DeleteAuto(int id);
    }




}
