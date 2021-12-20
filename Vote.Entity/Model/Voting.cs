using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vote.Entity.Model
{
    class Voting
    {
        [Key]
        public int VoteId { get; set; }
        public int VoteA { get; set; }
        public int VoteB { get; set; }
    }
}
