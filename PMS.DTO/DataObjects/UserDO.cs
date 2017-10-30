using System;
using System.Collections.Generic;
using System.Text;

namespace PMS.DTO.DataObjects
{
    public class UserDO
    {
        public UserDO()
        {
            CommentDOList = new List<CommentDO>();
            FileDOList = new List<FileDO>();
            IssueDOList = new List<IssueDO>();
            MessageGetUserDOList = new List<MessageDO>();
            MessagePostUserDOList = new List<MessageDO>();
            NotificationDOList = new List<NotificationDO>();
            ProjectDOList = new List<ProjectDO>();
            ProjectEmployeDOList = new List<ProjectEmployeDO>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
        public int RoleId { get; set; }
        public string PicturePath { get; set; }

        public RoleDO RoleDO { get; set; }
        public List<CommentDO> CommentDOList { get; set; }
        public List<FileDO> FileDOList { get; set; }
        public List<IssueDO> IssueDOList { get; set; }
        public List<MessageDO> MessageGetUserDOList { get; set; }
        public List<MessageDO> MessagePostUserDOList { get; set; }
        public List<NotificationDO> NotificationDOList { get; set; }
        public List<ProjectDO> ProjectDOList { get; set; }
        public List<ProjectEmployeDO> ProjectEmployeDOList { get; set; }
    }
}
