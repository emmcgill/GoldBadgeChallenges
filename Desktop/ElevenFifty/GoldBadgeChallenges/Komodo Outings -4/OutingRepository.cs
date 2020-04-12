using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Komodo_Outings__4
{
    class OutingRepository
    {
        protected List<Outing> _outingList = new List<Outing>();


        //CREATE
        public void AddNewEvent(Outing newEvent)
        {
            _outingList.Add(newEvent);
        }

        //READ ALL
        public List<Outing> ShowAllEvents()
        {
            return _outingList;
        }

    }
}
