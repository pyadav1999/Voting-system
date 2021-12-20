using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Voting_system.Models
{
    public class image
    {
        [Key]
        public int Id { get; set; }

        public byte[] img {get;set;}
    }
}