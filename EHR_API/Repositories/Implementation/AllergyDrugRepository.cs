﻿using EHR_API.Entities;
using EHR_API.Entities.Models;
using EHR_API.Repositories.Contracts;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace EHR_API.Repositories.Implementation
{
    public class AllergyDrugRepository : RepositoryBase<AllergyDrug>, IAllergyDrugRepository
    {
        private readonly ApplicationDbContext _db;
        public AllergyDrugRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task CreateRangeAsync(List<AllergyDrug> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _db.SaveChangesAsync();
        }
    }
}
