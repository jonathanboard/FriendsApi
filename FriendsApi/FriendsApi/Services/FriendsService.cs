using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FriendsApi.FriendsDomainService;
using System.Threading.Tasks;

namespace FriendsApi.Services
{
    public class FriendsService : IFriendsService
    {
        public GetFriendsResponse GetFriends(GetFriendsRequest request)
        {
            using (var client = new FriendServiceClient())
            {
                return client.GetFriends(request);
            }
        }

        public async Task<GetFriendsResponse> GetFriendsAsync(GetFriendsRequest request)
        {
            using (var client = new FriendServiceClient())
            {
                return await client.GetFriendsAsync(request);
            }
        }
    }
}