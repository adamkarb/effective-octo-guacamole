using System;
using AutoMapper;
using WebApi.Domain.Model;
using WebApi.Infrastructure.Model;

namespace WebApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserSqlModel, User>()
                .ForMember(user => user.UserId, config => config.MapFrom(userSql => userSql.UserId))
                .ForMember(user => user.Firstname, config => config.MapFrom(userSql => userSql.Firstname))
                .ForMember(user => user.Lastname, config => config.MapFrom(userSql => userSql.Lastname))
                .ForMember(user => user.Email, config => config.MapFrom(userSql => userSql.Email));
        }
    }
}
