using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TDD.DbTestHelpers.Yaml;
using Blog.DAL.Infrastructure;
using Blog.DAL.Model;

namespace Blog.DAL.Tests
{
    public class BlogFixtures : YamlDbFixture<BlogContext, BlogFixturesModel>
    {
        public BlogFixtures()
        {
            SetYamlFiles("posts.yml");
        }
    }

    public class BlogFixturesModel
    {
        public FixtureTable<Post> Posts { get; set; }
    }


}
