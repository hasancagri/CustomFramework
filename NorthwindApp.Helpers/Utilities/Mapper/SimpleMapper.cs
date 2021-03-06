﻿using AutoMapper;
using System.Collections.Generic;

namespace NorthwindApp.Helpers.Utilities.Mapper
{
    public static class SimpleMapper
    {
        public static void PropertyMap<T, TU>(T source, TU destination)
        {
            var config = new MapperConfiguration(cfg =>
              {
                  cfg.CreateMap<T, TU>();
              });
            IMapper mapper = config.CreateMapper();
            mapper.Map<T, TU>(source, destination);
        }

        public static void PropertyMap<T, TU>(List<T> source, List<TU> destination)
        {
            var config = new MapperConfiguration(cfg =>
              {
                  cfg.CreateMap<T, TU>();
              });
            IMapper mapper = config.CreateMapper();
            mapper.Map(source, destination);
        }
    }
}
