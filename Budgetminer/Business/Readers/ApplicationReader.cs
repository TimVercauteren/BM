using Budgetminer.Business.Readers.Base;
using Budgetminer.DataAccess;
using Budgetminer.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Budgetminer.Business.Readers
{
    public class ApplicationReader : ReaderBase<Application>, IApplicationReader
    { 
        public ApplicationReader(EntityContext context) : base(context)
        {
        }
    }
}
