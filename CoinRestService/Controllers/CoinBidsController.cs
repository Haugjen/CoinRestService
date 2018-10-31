using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using modelLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoinRestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinBidsController : ControllerBase
    {

        // data list of Bids
        private static List<CoinBid> bids = new List<CoinBid>()
        {
            new CoinBid(1, "Gold DK 1640", 2500, "Mike"),
            new CoinBid(2, "Gold NL 1764", 5000, "Anbo"),
            new CoinBid(3, "Gold FR 1644", 0, "Auction"),
            new CoinBid(4, "Gold FR 1644", 35000, "Hammer"),
            new CoinBid(5, "Silver GR 333", 2500, "Mike")
        };


        // GET: api/CoinBids
        [HttpGet]
        [Route("")]
        public IList<CoinBid> GetBids()
        {
            return bids;
        }

        // GET: api/CoinBids/5
        [HttpGet]
        [Route("{id}")]
        public CoinBid GetOneBid(int id)
        {
            return bids.Find(c => c.Id == id);
        }

        // POST: api/CoinBids
        [HttpPost]
        [Route("")]
        public bool AddCoinBid([FromBody]CoinBid newCoinBid)
        {
            CoinBid bid = GetOneBid(newCoinBid.Id);
            if (bid == null) // no bid at this Id 
            {
                bids.Add(newCoinBid);
                return true;
            }

            return false;
        }

       
    }
}
