using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly IEnumerable<Item> Items = new[]
        {
            new Item 
            {
                Id = 1,
                Name = "The Godfather",
                ImageId = 1,
                Ranking = 0,
                ItemType = 1
            },
            new Item 
            {
                Id = 2,
                Name = "Highlander",
                ImageId = 2,
                Ranking = 0,
                ItemType = 1
            },
            new Item 
            {
                Id = 3,
                Name = "Highlander II",
                ImageId = 3,
                Ranking = 0,
                ItemType = 1
            },
            new Item 
            {
                Id = 4,
                Name = "The Last of the Mohicans",
                ImageId = 4,
                Ranking = 0,
                ItemType = 1
            },
            new Item 
            {
                Id = 5,
                Name = "Police Academy Six",
                ImageId = 5,
                Ranking = 0,
                ItemType = 1
            },
            new Item 
            {
                Id = 6,
                Name = "Rear Window",
                ImageId = 6,
                Ranking = 0,
                ItemType = 1
            },
            new Item 
            {
                Id = 7,
                Name = "Road House",
                ImageId = 7,
                Ranking = 0,
                ItemType = 1
            },
            new Item 
            {
                Id = 8,
                Name = "The Shawnsaw Redemption",
                ImageId = 8,
                Ranking = 0,
                ItemType = 1
            },
            new Item 
            {
                Id = 9,
                Name = "Star Trek IV",
                ImageId = 9,
                Ranking = 0,
                ItemType = 1
            },
            new Item 
            {
                Id = 10,
                Name = "Superman IV",
                ImageId = 10,
                Ranking = 0,
                ItemType = 1
            }
        };

        [HttpGet]
        [Route("{itemType:int}")]
        public Item[] Get(int itemType)
        {
            Item[] items = Items.Where(i => i.ItemType == itemType).ToArray();
            return items;
        }
    }
}