using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Context;
using DataAccess.Interface;
using Entities;
using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class SatisD : Generic<Satis>, ISatis
    {
        protected readonly Scontext _context;
        public SatisD(Scontext context) : base(context)
        {
            _context = context;
        }
    }
}
