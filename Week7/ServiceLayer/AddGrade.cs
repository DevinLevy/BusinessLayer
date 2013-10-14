﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using AnotherOne;

namespace ServiceLayer
{
    public static class AddGrade
    {
        public static void CreateGrade(int id, int actId, int sValue)
        {
            NewDataBaseEntities db = new NewDataBaseEntities();
         

            if (sValue > 0)
            {
                Grade gr = new Grade();
                gr.Value = sValue;
                db.Grades.Add(gr);
                gr.PersonId = id;
                gr.ActivityId = actId;
                db.Grades.Add(gr); 
                db.SaveChanges();



            }

        }
    }
}
