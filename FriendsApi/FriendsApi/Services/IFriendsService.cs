using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FriendsApi.FriendsDomainService;
using System.Threading.Tasks;

namespace FriendsApi.Services
{
    public interface IFriendsService
    {
        GetFriendsResponse GetFriends(GetFriendsRequest request);
        Task<GetFriendsResponse> GetFriendsAsync(GetFriendsRequest request);
    }
}
