using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPM.Models
{
    public class ParentUser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public string ContactEmail { get; set; }

        public List<Kiddo> Kiddo { get; set; }

        public ParentUser(string userName, int id)
        {
            Id = id;
            UserName = userName;
        }

    }
}
