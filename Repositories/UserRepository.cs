using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exam_webapi.Models;

namespace exam_webapi.Repositories
{
    public class UserRepository
    {
        public List<User> collection { get; set; }
        public UserRepository()
        {
            collection = new List<User>();
        }

    }
}