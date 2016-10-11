using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emotible.Models;

namespace Emotible.Controller
{
    public class DataAccessController
    {
        //private EmotibleDataContext dataContext;

        public DataAccessController()
        {
            //dataContext = new EmotibleDataContext();
        }

        public Emote AddEmote()
        {
            //TODO: Share this reference
            using (var dataContext = new EmotibleDataContext())
            {
                //return await Task.Run(() =>
                //{
                    dataContext.Emotes.Add(new Emote() {EmoteText = "Hello, I'm an Emote", Name = "First Emote"});
                    dataContext.SaveChanges();
                    return dataContext.Emotes.First();
                //});
            }
        }
    }
}
