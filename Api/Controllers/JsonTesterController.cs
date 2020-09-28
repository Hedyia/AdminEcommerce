using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Api.Controllers
{
    class Item 
    {
        public string Name { get; set; }
        public int Count { get; set; }
    }
    public class JsonTesterController : ApiController
    {
        Dictionary<string, HashSet<Item>> _variations = new Dictionary<string, HashSet<Item>>();
        [HttpGet]
        public ActionResult GetProducts()
        {
            var jsonFile = System.IO.File.ReadAllText("../Api/wwwroot/uploads/file.json");
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            var products = JsonConvert.DeserializeObject<MainProduct>(jsonFile);
            foreach (var product in products.Products)
            {
                foreach (var variation in product.Variations)
                {
                    if (!_variations.ContainsKey(variation.Name))
                    {
                        _variations.Add(variation.Name, new HashSet<Item>());
                    }
                    foreach (var value in variation.Value)
                    {
                        var item = _variations[variation.Name].FirstOrDefault(x=> x.Name == value);
                        if(item == null) 
                        {
                            _variations[variation.Name].Add(new Item{Name = value, Count=1});
                        }
                        else 
                            item.Count++;

                    }
                }
            }
            return Ok(_variations);
        }
    }
}