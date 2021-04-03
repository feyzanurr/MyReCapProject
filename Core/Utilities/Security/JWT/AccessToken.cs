using System;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }
        //sureli kullanim saglayacak
        public DateTime Expiration { get; set; }
    }
}