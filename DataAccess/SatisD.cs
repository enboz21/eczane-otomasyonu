using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interface;
using Entities;
using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class SatisD : Generic<Satis>, ISatis
    {
    }
}
