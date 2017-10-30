using System;
using System.Collections.Generic;

namespace PMS.Data.Models
{
    public partial class User
    {
        public User()
        {
            Comment = new HashSet<Comment>();
            File = new HashSet<File>();
            Issue = new HashSet<Issue>();
            MessageGetUser = new HashSet<Message>();
            MessagePostUser = new HashSet<Message>();
            Notification = new HashSet<Notification>();
            Project = new HashSet<Project>();
            ProjectEmploye = new HashSet<ProjectEmploye>();
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

        public Role Role { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public ICollection<File> File { get; set; }
        public ICollection<Issue> Issue { get; set; }
        public ICollection<Message> MessageGetUser { get; set; }
        public ICollection<Message> MessagePostUser { get; set; }
        public ICollection<Notification> Notification { get; set; }
        public ICollection<Project> Project { get; set; }
        public ICollection<ProjectEmploye> ProjectEmploye { get; set; }
    }
}
