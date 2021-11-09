using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastucture.Data;

namespace SocialMedia.Infrastucture.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly SocialMediaContext socialMediaContext;

        public PostRepository(SocialMediaContext socialMediaContext)
        {
            this.socialMediaContext = socialMediaContext;
        }



        public async Task<IEnumerable<Publicacion>> GetPosts()
        {
            var post = await socialMediaContext.Publicacions.ToListAsync();
            return post;
        }
    }
}