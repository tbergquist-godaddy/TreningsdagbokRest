﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.DAL.Interface;
using Treningsdagbok.DataLayer.Entities;

namespace Treningsdagbok.DataLayer.DAL
{
    public class WeekRepository : BaseRepository<Week>, IWeekRepository
    {

        public override System.Data.Entity.DbSet<Week> GetDbSet(TreningsdagbokDbContext context)
        {
            return context.Week;
        }

        public IEnumerable<Week> GetAllWeeksOfProgram(int programId)
        {
            using (var dbContext = new TreningsdagbokDbContext())
            {
                return dbContext.Week.Where(x => x.ProgramId == programId).ToList();
            }
        }
    }
}
