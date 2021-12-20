using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Voting_system.Models;

namespace Voting_system.Context
{
    public class VoteDbContext:DbContext
    {

        public VoteDbContext() : base("name=VotinConn")
        {

        }

        public DbSet<Voting> Votings { get; set; }
        public DbSet<image> images { get; set; }
    }
}