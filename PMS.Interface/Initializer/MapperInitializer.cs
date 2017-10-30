using AutoMapper;
using PMS.Data.Models;
using PMS.DTO.DataObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.Interface.Initializer
{
    public class MapperInitializer
    {
        public static void MapperConfiguration()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<AuthDO, Auth>()
                .ForMember(dest => dest.RoleAuthorization, opt => opt.ResolveUsing(fa => fa.RoleAuthorizationDOList))
                .ReverseMap();

                config.CreateMap<CommentDO, Comment>()
                .ForMember(dest => dest.Issue, opt => opt.ResolveUsing(fa => fa.IssueDO))
                .ForMember(dest => dest.User, opt => opt.ResolveUsing(fa => fa.UserDO))
                .ReverseMap();

                config.CreateMap<FileDO, File>()
                .ForMember(dest => dest.Issue, opt => opt.ResolveUsing(fa => fa.IssueDO))
                .ForMember(dest => dest.User, opt => opt.ResolveUsing(fa => fa.UserDO))
                .ReverseMap();

                config.CreateMap<IssueDO, Issue>()
                .ForMember(dest => dest.Comment, opt => opt.ResolveUsing(fa => fa.CommentDOList))
                .ForMember(dest => dest.Priority, opt => opt.ResolveUsing(fa => fa.PriorityDO))
                .ForMember(dest => dest.Project, opt => opt.ResolveUsing(fa => fa.ProjectDO))
                .ForMember(dest => dest.Reporter, opt => opt.ResolveUsing(fa => fa.ReporterDO))
                .ForMember(dest => dest.Status, opt => opt.ResolveUsing(fa => fa.StatusDO))
                .ForMember(dest => dest.TaskSubTaskSubTask, opt => opt.ResolveUsing(fa => fa.TaskSubTaskSubTaskDOList))
                .ForMember(dest => dest.TaskSubTaskTask, opt => opt.ResolveUsing(fa => fa.TaskSubTaskDOList))
                .ReverseMap();

                config.CreateMap<Message, MessageDO>()
                .ForMember(dest => dest.GetUserDO, opt => opt.ResolveUsing(fa => fa.GetUser))
                .ForMember(dest => dest.PostUserDO, opt => opt.ResolveUsing(fa => fa.PostUser))
                .ReverseMap();

                config.CreateMap<Notification, NotificationDO>()
                .ForMember(dest => dest.UserDO, opt => opt.ResolveUsing(fa => fa.User))
                .ReverseMap();

                config.CreateMap<Priority, PriorityDO>()
                .ForMember(dest => dest.IssueDOList, opt => opt.ResolveUsing(fa => fa.Issue))
                .ReverseMap();

                config.CreateMap<Project, ProjectDO>()
                .ForMember(dest => dest.IssueDOList, opt => opt.ResolveUsing(fa => fa.Issue))
                .ForMember(dest => dest.ProjectEmployeDOList, opt => opt.ResolveUsing(fa => fa.ProjectEmploye))
                .ForMember(dest => dest.CreatedUserDO, opt => opt.ResolveUsing(fa => fa.CreatedUser))
                .ReverseMap();

                config.CreateMap<ProjectEmploye, ProjectEmployeDO>()
                .ForMember(dest => dest.ProjectDO, opt => opt.ResolveUsing(fa => fa.Project))
                .ForMember(dest => dest.UserDO, opt => opt.ResolveUsing(fa => fa.User))
                .ReverseMap();

                config.CreateMap<RoleAuthorization, RoleAuthorizationDO>()
                .ForMember(dest => dest.AuthorizationDO, opt => opt.ResolveUsing(fa => fa.Authorization))
                .ForMember(dest => dest.RoleDO, opt => opt.ResolveUsing(fa => fa.Role))
                .ReverseMap();

                config.CreateMap<Role, RoleDO>()
                .ForMember(dest => dest.RoleAuthorizationDOList, opt => opt.ResolveUsing(fa => fa.RoleAuthorization))
                .ForMember(dest => dest.UserDOList, opt => opt.ResolveUsing(fa => fa.User))
                .ReverseMap();

                config.CreateMap<Status, StatusDO>()
                .ForMember(dest => dest.IssueDOList, opt => opt.ResolveUsing(fa => fa.Issue))
                .ReverseMap();

                config.CreateMap<TaskSubTask, TaskSubTaskDO>()
                .ForMember(dest => dest.SubTaskDO, opt => opt.ResolveUsing(fa => fa.SubTask))
                .ForMember(dest => dest.TaskDO, opt => opt.ResolveUsing(fa => fa.Task))
                .ReverseMap();

                config.CreateMap<User, UserDO>()
                .ForMember(dest => dest.CommentDOList, opt => opt.ResolveUsing(fa => fa.Comment))
                .ForMember(dest => dest.FileDOList, opt => opt.ResolveUsing(fa => fa.File))
                .ForMember(dest => dest.IssueDOList, opt => opt.ResolveUsing(fa => fa.Issue))
                .ForMember(dest => dest.MessageGetUserDOList, opt => opt.ResolveUsing(fa => fa.MessageGetUser))
                .ForMember(dest => dest.MessagePostUserDOList, opt => opt.ResolveUsing(fa => fa.MessagePostUser))
                .ForMember(dest => dest.NotificationDOList, opt => opt.ResolveUsing(fa => fa.Notification))
                .ForMember(dest => dest.ProjectDOList, opt => opt.ResolveUsing(fa => fa.Project))
                .ForMember(dest => dest.ProjectEmployeDOList, opt => opt.ResolveUsing(fa => fa.ProjectEmploye))
                .ForMember(dest => dest.RoleDO, opt => opt.ResolveUsing(fa => fa.Role))
                .ReverseMap();
            });
        }
    }
}
