using System;

namespace TeSoft.Api.API.DataContracts.Requests
{
    public class UserCreationRequest
    {
        public DateTime Date { get; set; }

        public User User { get; set; }
    }
}
