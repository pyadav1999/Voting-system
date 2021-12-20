using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Voting_system.Models;
using System.Data;
using Voting_system.Context;
using System.Data.Entity;

namespace Voting_system.Repository
{
    public class VotingRepository : IVotingRepositorycs
    {
        private VoteDbContext _votecontext;
        public VotingRepository(VoteDbContext VoteContext)
        {
            this._votecontext = VoteContext;
        }
        public IEnumerable<Voting> GetVotes()
        {
            return _votecontext.Votings.ToList();
        }

        public void InsertVotes(Voting votes)
        {
            _votecontext.Votings.Add(votes);
        }

        public void Save()
        {
            _votecontext.SaveChanges();
        }

        public void UpdateVotes(Voting votes)
        {
            _votecontext.Entry(votes).State= EntityState.Modified;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

      
    }

    public class imgRepository : IimgReository
    {
        private VoteDbContext _img;
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<image> GetImages()
        {
            return _img.images.ToList();
        }

        public void insertimg(image img)
        {
            _img.images.Add(img);
        }

        public void save()
        {
            _img.SaveChanges();
        }
    }
}