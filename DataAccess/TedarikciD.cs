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
    public class TedarikciD : Generic<Tedarikci>, ITedarikci
    {

        protected readonly Scontext _context;
        public TedarikciD(Scontext context) : base(context)
        {
            _context = context;
        }

    }
}
