using DragonForums.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DragonForums.Data
{
    public interface IForum
    {
        Forum GetById(int id);
        IEnumerable<Forums> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers();

        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);




    }
}
