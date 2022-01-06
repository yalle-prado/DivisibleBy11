using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DivisibleBy11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionController : ControllerBase
    {


        [HttpPost]
        [Route("~/api/Consult/")]
        public IEnumerable<Item> Consult([FromBody] List<string> listNumbers)
        {
            //var listNumbers = JsonConvert.DeserializeObject<List<int>>(Numbers);
            List<Item> result = new List<Item>();
            bool test;
            int digitSumEve = 0;
            int digitSumOdd = 0;


            foreach (string num  in listNumbers)

            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        digitSumEve =digitSumEve + Int32.Parse(num[i].ToString() );
                         
                    }
                    else
                    {
                        digitSumOdd = digitSumOdd + Int32.Parse(num[i].ToString());
                    }

                }

                int res = digitSumOdd - digitSumEve;
                if (res % 11 == 0)
                {
                    test = true;
                }
                else
                {
                    test = false;
                }


                result.Add(new Item() { Number = Int32.Parse(num), IsMultiple = test });

            }
            return (IEnumerable<Item>)result;

            // return listNumbers;
        }

        [HttpGet]

        public IEnumerable<Item> GetDivision(int item)
        {
            // var item = new Random();

            return Enumerable.Range(1, 10).Select(index => new Item
            {
                Number = item,
                IsMultiple = true
            })
            .ToArray();
        }
    }
}

