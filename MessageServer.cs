using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace ChatClient
{
    class MessageServer
    {
        public List<String> GetMessages()
        {
            var client = new RestClient("https://localhost:44319");
            var request = new RestRequest("/api/Message");
            var response = client.Execute<List<String>>(request);
            return response.Data;
        }

        public void SendMessage(string message)
        {
            var client = new RestClient("https://localhost:44319");
            var request = new RestRequest("/api/Message", Method.POST)
                .AddJsonBody(message);
            client.Execute(request);
        }

    }
}
