﻿using Drive.Data.Entities;
using Drive.Domain.Enums;

namespace Drive.Domain.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly DumpDriveDbContext DbContext;

        protected BaseRepository(DumpDriveDbContext dbContext)
        {
            DbContext = dbContext;
        }

        protected ResponseResultType SaveChanges()
        {
            var hasChanges = DbContext.SaveChanges() > 0;
            if (hasChanges)
                return ResponseResultType.Success;

            return ResponseResultType.NoChanges;
        }
    }
}
