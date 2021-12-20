using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Voting_system.Context;
using Voting_system.Models;
using Voting_system.Repository;

namespace Voting_system.Controllers
{
    public class VotingController : Controller
    {
        private IVotingRepositorycs _voteRepository;
        public VotingController()
        {
            this._voteRepository = new VotingRepository(new VoteDbContext());
        }
        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult uploadimg(HttpPostedFileBase file)
        {
            try
            {
                Voting model = new Voting();
                if (file == null)
                {
                    ModelState.AddModelError("", "Select a image");
                    RedirectToAction("Index", "Home");
                }
                else
                {
                    byte[] imageBytes = null;
                    BinaryReader reader = new BinaryReader(file.InputStream);
                    imageBytes = reader.ReadBytes((int)file.ContentLength);
                    model.img = imageBytes;
                    _voteRepository.InsertVotes(model);
                    _voteRepository.Save();
                   // Display(imageBytes);
                    
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            return View("Index");
        }

        public ActionResult Display()
        {
            List<Voting> model = new List<Voting>();
            model = _voteRepository.GetVotes().ToList();
           
            
            foreach (var item in model)
            {
                if (item.img != null)
                {
                    string img = Convert.ToBase64String(item.img, 0, item.img.Length);
                    string image = "data:image/jgp;base64," + img;
                  
                    
                }
            }
          
            //ScriptManager.RegisterStartupScript(this.page,this.GetType(), "script", "<script>window.open()</script>", true);
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Vote(Voting model)
        {
            
            var status = false;
            var message = "";
            var tempmodel = new object();
            try
            {
                if(ModelState.IsValid)
                {
                    _voteRepository.InsertVotes(model);
                    _voteRepository.Save();
                    status = true;
                    message = "Voted Successfully";
                }
                tempmodel = model;

                
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("", ex);
                status = false;
                message = "Error";
            }


            return Json(new { Status=status,Message=message,Tempmodel=tempmodel});

        }
        
    }
}