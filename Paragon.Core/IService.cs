using System.ServiceModel;

namespace Paragon.Core
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract, XmlSerializerFormat]
        bool Login(string username, string password);

        [OperationContract, XmlSerializerFormat]
        bool Register(string email, string username, string password);
    }
}
