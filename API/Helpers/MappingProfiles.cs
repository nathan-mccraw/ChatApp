﻿using AutoMapper;
using Core.DTOs;
using Core.Entities;
using Core.InputValidationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<MessageEntity, MessageModel>()
                .ForMember(d => d.UserId, o => o.MapFrom(s => s.User.Id))
                .ForMember(d => d.Username, o => o.MapFrom(s => s.User.Username));

            CreateMap<UserEntity, UserModel>()
                .ForMember(d => d.LastActive, o => o.MapFrom(s => s.UserSession.LastActive));

            CreateMap<UserSessionEntity, UserSessionModel>();
            CreateMap<UserSessionModel, UserSessionEntity>();
        }
    }
}