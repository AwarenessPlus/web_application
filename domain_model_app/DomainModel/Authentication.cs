using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace DomainModel
{
    public class Authentication
    {
        [Key]
        private int _authenticationID;

        private String _userName;
        private String _password;

        public Authentication()
        {

        }


        public void EncryptPassword(String textPassword)
        {
            MD5CryptoServiceProvider x = new();
            byte[] bs = Encoding.UTF8.GetBytes(textPassword);
            bs = x.ComputeHash(bs);
            StringBuilder s = new();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            String hash = s.ToString();
            this._password = hash;
        }

        public string UserName { get => _userName; set => _userName = value; }
        public string Password { get => _password; set => _password = value; }
        public int AuthenticationID { get => _authenticationID; set => _authenticationID = value; }
    }
}
