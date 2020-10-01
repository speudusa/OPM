using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPM.Models
{
    public class Kiddo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public ParentUser Parent { get; set; }

        public int ParentId { get; set; }

        public Kiddo(int id, string userName)
        {
            Id = id;
            UserName = userName;
        }
    }
}
