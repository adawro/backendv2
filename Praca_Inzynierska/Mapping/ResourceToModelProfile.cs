﻿using System.Linq;
using AutoMapper;
using Praca_Inzynierska.DTO;
using Praca_Inzynierska.Models;
using Praca_Inzynierska.DTO.ReturnDto;

namespace Praca_Inzynierska.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<RegisterAccountDto, UserAccount>();
            CreateMap<UserAccount, AccountReturn>();
            CreateMap<ActorSaveDto, Actor>()
                .ForMember(dest => dest.ActorName, opt => opt.MapFrom(src => src.Name.ToUpper() + " " + src.Surname.ToUpper()))
                .ForMember(dest => dest.ActorSurname, opt => opt.MapFrom(src => src.Surname.ToUpper() + " " + src.Name.ToUpper()))
                .ForMember(x => x.Images, opt => opt.Ignore());
            CreateMap<Actor, ActorReturnDto>()
                .ForMember(dest => dest.Born, opt => opt.MapFrom(src => src.Born.ToString("d")))
                .ForMember(i => i.Images, opt => opt.Ignore());
            CreateMap<ActorListReturnDto, Actor>();
            CreateMap<Actor, ActorListReturnDto>();
            CreateMap<ActorEditDto, Actor>()
                .ForMember(dest => dest.ActorName, opt => opt.MapFrom(src => src.Name.ToUpper() + " " + src.Surname.ToUpper()))
                .ForMember(dest => dest.ActorSurname, opt => opt.MapFrom(src => src.Surname.ToUpper() + " " + src.Name.ToUpper()))
                .ForMember(x => x.Images, opt => opt.Ignore());
            CreateMap<MovieSaveDto, Movie>()
                .ForMember(x => x.Actors, opt => opt.Ignore())
                .ForMember(x => x.Type, opt => opt.Ignore())
                .ForMember(x => x.Images, opt => opt.Ignore());
            CreateMap<MovieEditDto, Movie>()
                .ForMember(x => x.Actors, opt => opt.Ignore())
                .ForMember(x => x.Type, opt => opt.Ignore())
                .ForMember(x => x.Images, opt => opt.Ignore());
            CreateMap<Movie, MovieReturnDto>()
                .ForMember(x=>x.Type, opt=>opt.MapFrom(src=>src.Type.Name))
                .ForMember(x => x.Actors, opt => opt.Ignore());
            CreateMap<Movie, MovieReturnForListDto>();
            CreateMap<Actor, ActorReturnDetails>()
                .ForMember(dest => dest.Born, opt => opt.MapFrom(src => src.Born.ToString("d")))
                .ForMember(i => i.Images, opt => opt.Ignore());
            CreateMap<Movie, MovieReturnForList>();
            CreateMap<CommentSaveDto, Comment>();

        }
    }
}
