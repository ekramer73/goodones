﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GoodOnes.DAL
{
    public class GOInitializerRecreate : DropCreateDatabaseAlways<GOContext>
    {
        protected override void Seed(GOContext context)
        {
//            base.Seed(context);
            context.Seed();
        }       
    }
}