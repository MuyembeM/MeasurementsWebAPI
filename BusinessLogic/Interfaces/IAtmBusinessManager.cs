﻿using MeasurementsWebAPI.BusinessLogic.Models;
using System.Linq.Expressions;

namespace MeasurementsWebAPI.BusinessLogic.Interfaces
{
    public interface IAtmBusinessManager
    {
        Task<IEnumerable<Atm>> GetAll();
        Task<Atm?> Get(int id);
        void Insert(Atm atm);
        void Update(Atm atm);
        void Delete(int id);
    }
}
