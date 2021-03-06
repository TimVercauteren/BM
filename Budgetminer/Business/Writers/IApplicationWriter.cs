﻿using Budgetminer.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budgetminer.Business.Writers
{
    public interface IApplicationWriter
    {
        void Insert(Application application);
        void Update(Application application, int id);
    }
}
