﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treningsdagbok.DataLayer.Entities;

namespace Treningsdagbok.DataLayer.DAL.Interface
{
    public interface IDayExerciseRepository : IBaseRepository<DayExercise>
    {
        IEnumerable<DayExercise> GetAllByDayId(int dayId);
    }
}
