using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam_webapi.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public UserType_Enum UserType { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}