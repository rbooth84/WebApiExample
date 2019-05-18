using RestSharp;
using SharedClientObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleClient
{
    public class Client
    {
        private readonly RestClient restClient = new RestClient("http://localhost:54702");

        public UserPermissions DoLogin(string username, string password)
        {
            var login = new Login() { Username = username, Password = password };
            var request = new RestRequest("api/login", Method.POST);
            request.AddJsonBody(login);
            return restClient.Execute<UserPermissions>(request)?.Data;
        }

    }
}
