using System;
using Microsoft.EntityFrameworkCore;
using Toci.AffectiveBipolar.Database.Persistence.Models;
using Toci.Common.Bll;

namespace Toci.AffectiveBipolar.Bll
{
    public class Logic<TModel> : LogicBase<TModel> where TModel : class
    {
        protected override DbContext GetEfHandle()
        {
            return new TociAffectiveBipolarContext();
        }
    }
}
