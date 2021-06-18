using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repositories.Repositories
{
    public abstract class BaseRepository
    {
        public readonly DbContext context;
        public readonly IMapper mapper;

        public BaseRepository(DbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (context != null)
                {
                    context.Dispose();
                }
            }
        }
    }
}
