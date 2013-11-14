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
        RegisterResult Register(string email, string username, string password);

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
        WrongPassword = 0x02,
        UnknownFailure = 0x03
    }

    [XmlType]
    public enum RegisterResult : byte
    {
        Success = 0x00,
        UsernameExists = 0x01,
        EmailExists = 0x02,
        UnknownFailure = 0x03
    }
}
