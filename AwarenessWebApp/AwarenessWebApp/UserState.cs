 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwarenessWebApp
{
    public class UserState
    {
        private string _token;
        public string Token { get => _token; set => _token = value; }
        public UserState()
        {
        }
        public UserState(string token)
        {
            Token = token;
        }
        public bool isLogged()
        {
            return !String.IsNullOrEmpty(this._token);
        }
    }
}
