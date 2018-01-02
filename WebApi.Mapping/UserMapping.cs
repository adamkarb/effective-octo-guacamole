using System;
using AutoMapper;
using WebApi.Application.Dto;
using WebApi.Domain.Model;
using WebApi.Infrastructure.Model;

namespace WebApi.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // User --> UserSqlModel
            CreateMap<User, UserSqlModel>()
                .ForMember(userSql => userSql.UserId, config => config.MapFrom(user => user.UserId))
                .ForMember(userSql => userSql.Firstname, config => config.MapFrom(user => user.Firstname))
                .ForMember(userSql => userSql.Lastname, config => config.MapFrom(user => user.Lastname))
                .ForMember(userSql => userSql.Password, config => config.MapFrom(user => user.Password))
                .ForMember(userSql => userSql.Email, config => config.MapFrom(user => user.Email));

            // UserSqlModel --> User
            CreateMap<UserSqlModel, User>()
                .ForMember(user => user.UserId, config => config.MapFrom(userSql => userSql.UserId))
                .ForMember(user => user.Firstname, config => config.MapFrom(userSql => userSql.Firstname))
                .ForMember(user => user.Lastname, config => config.MapFrom(userSql => userSql.Lastname))
                .ForMember(user => user.Email, config => config.MapFrom(userSql => userSql.Email));

            // User --> UserDto
            CreateMap<User, UserDto>()
                .ForMember(userDto => userDto.UserId, config => config.MapFrom(user => user.UserId))
                .ForMember(userDto => userDto.Firstname, config => config.MapFrom(user => user.Firstname))
                .ForMember(userDto => userDto.Lastname, config => config.MapFrom(user => user.Lastname))
                .ForMember(userDto => userDto.Email, config => config.MapFrom(user => user.Email));

            // UserDto --> User
            CreateMap<UserDto, User>()
                .ForMember(user => user.UserId, config => config.MapFrom(userDto => userDto.UserId))
                .ForMember(user => user.Firstname, config => config.MapFrom(userDto => userDto.Firstname))
                .ForMember(user => user.Lastname, config => config.MapFrom(userDto => userDto.Lastname))
                .ForMember(user => user.Password, config => config.MapFrom(userDto => userDto.Password))
                .ForMember(user => user.Email, config => config.MapFrom(userDto => userDto.Email));
        }
    }
}
