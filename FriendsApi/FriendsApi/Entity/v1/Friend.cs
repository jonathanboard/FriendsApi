using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FriendsApi.Entity.v1
{
    public class Friend
    {
        public string Name { get; set;}
        public string Address { get; set; }
        public string Email { get; set; }
        public Guid Id { get; set; }
    }
}