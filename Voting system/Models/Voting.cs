using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Voting_system.Models
{
    public class Voting
    {
        [Key]
        public int Id { get; set; }
        [Range(0, 1000)]
        [Required]
        public int VoteA { get; set; }
        [Range(0, 1000)]
        [Required]
        public int VoteB { get; set; }
           
        public byte[] img { get; set; }
        
    }
}