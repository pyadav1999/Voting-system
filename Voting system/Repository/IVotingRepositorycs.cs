using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_system.Models;

namespace Voting_system.Repository
{
    public interface IVotingRepositorycs: IDisposable
    {
        IEnumerable<Voting> GetVotes();
  
        void InsertVotes(Voting votes);
        void UpdateVotes(Voting votes);
        void Save();


    }

    public interface IimgReository:IDisposable
    {
        IEnumerable<image> GetImages();
        void insertimg(image img);
        void save();
    }
}
