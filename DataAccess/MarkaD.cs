using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Interface;
using Entities;
namespace DataAccess
{
    public class MarkaD : Generic<Marka>, IMarka
    {
        protected readonly Scontext _context;
        public MarkaD(Scontext context) : base(context)
        {
            _context = context;
        }
    }
}
