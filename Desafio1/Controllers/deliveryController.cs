using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio1.Controllers
{
    [ApiController]
    [Route("/delivery")]
    public class DeliveryController : ControllerBase
    {
        private static List<Delivery> Deliveries(){
            return new List<Delivery>{
                new Delivery{Id = 1, codeDelivery = "123", DateDelivery = new DateTime(2022, 10, 20)},
                new Delivery{Id = 2, codeDelivery = "456", DateDelivery = new DateTime(2022, 10, 20)},
                new Delivery{Id = 3, codeDelivery = "789", DateDelivery = new DateTime(2022, 10, 20)},
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Deliveries());
        }

        [HttpPost]
        public IActionResult Post(Delivery delivery)
        {
            var deliveries = Deliveries();
            deliveries.Add(delivery);
            return Ok(deliveries);
        }
        
    }
}