﻿using EHR_API.Entities.Models;
using EHR_API.Entities;
using EHR_API.Repositories.Contracts;

namespace EHR_API.Repositories.Implementation
{
    public class ChronicDiseaseDrugRepository : RepositoryBase<ChronicDiseaseDrug>, IChronicDiseaseDrugRepository
    {
        private readonly ApplicationDbContext _db;
        public ChronicDiseaseDrugRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task CreateRangeAsync(List<ChronicDiseaseDrug> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _db.SaveChangesAsync();
        }

    }
    
}
