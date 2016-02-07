using System.Data.Entity;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Web.Http.Description;
using System.Web.Http;
using FriendsApi.Services;
using FriendsApi.Entity.v1;
using FriendsApi.FriendsDomainService;

namespace FriendsApi.Controllers
{
    public class FriendsController : ApiController
    {
        private readonly IFriendsService _friendsService;

        public FriendsController(IFriendsService friendsService)
        {
            _friendsService = friendsService;
        }

        public FriendsController()
            :this(new FriendsService())
        {

        }

        [ResponseType(typeof(Entity.v1.Friend[]))]
        public async Task<IHttpActionResult> Get()
        {
            var request = new GetFriendsRequest();
            var response = await _friendsService.GetFriendsAsync(request);
            var returnVal = new List<Entity.v1.Friend>();

            if(response != null && response.Friends != null)
            {
                foreach(var friend in response.Friends)
                {
                    returnVal.Add(MapFriend(friend));
                }

            }

            return this.Ok( returnVal.ToArray());
        }

        private Entity.v1.Friend MapFriend(FriendsDomainService.Friend friend)
        {
            return new Entity.v1.Friend
            {
                Name = friend.Name,
                Address = friend.Address,
                Email = friend.Email
            };
        }
    }
}
