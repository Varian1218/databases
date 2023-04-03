// using System.Security.Cryptography;
// using System.Text;
//
// namespace Databases
// {
//     public class Databases : IDatabase
//     {
//         private IDatabase _impl;
//         private byte[] _optionalEntropy;
//
//         public IDatabase Impl
//         {
//             set => _impl = value;
//         }
//
//         public string Query(string key)
//         {
//             return Encoding.ASCII.GetString(ProtectedData.Unprotect(Encoding.ASCII.GetBytes(
//                     _impl.Query(key)),
//                 _optionalEntropy,
//                 DataProtectionScope.CurrentUser
//             ));
//         }
//
//         public void Update(string key, string value)
//         {
//             _impl.Update(key, Encoding.ASCII.GetString(ProtectedData.Protect(
//                 Encoding.ASCII.GetBytes(value),
//                 _optionalEntropy,
//                 DataProtectionScope.CurrentUser
//             )));
//         }
//     }
// }