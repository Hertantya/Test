using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public List <String> User() 
            {
            return new List<String>
            {
                "UserName",
                "Email",
                "encrypted_password",
                "phone",
                "address",
                "city",
                "country",
                "name",
                "postcode",
            };
            }
        public List<String> SignIn()
        {
            return new List<String>
            {
                "Email",
                "password",
            };
        }
        public List<String> CreateNewShooping()
        {
            return new List<String>
            {
                "createDate",
                "name",
                "id"
            };
        }

    }
}