using System.ServiceModel;
using System.Xml.Serialization;

namespace Paragon.Core
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract, XmlSerializerFormat]
        LoginResult Login(string username, string password);

        [OperationContract, XmlSerializerFormat]
        bool Register(string email, string username, string password);

        [OperationContract, XmlSerializerFormat]
        int CreateThread(int forumId, string subject, string body);

        [OperationContract, XmlSerializerFormat]
        bool IsOnline();

    }
    [XmlType]
    public enum LoginResult : byte
    {
        Success = 0x00,
        WrongUsername = 0x01,
        WrongPassword = 0x02
    }
}
