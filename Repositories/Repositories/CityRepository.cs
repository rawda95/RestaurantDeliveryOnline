using AutoMapper;
using Core.DTO;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Repositories.Repositories
{
    public class CityRepository : BaseRepository, ICityRepository
    {
        public CityRepository(DbContext context, IMapper mapper) : base(context, mapper)
        {

        }



        public List<CityDTO> GetCities()
        {
            var CityList = context.Set<City>().ToList();

            return mapper.Map<List<City>, List<CityDTO>>(CityList);

        }
    }

}
