﻿using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using Blog.DAL.Infrastructure;
using Blog.DAL.Model;
using Blog.DAL.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using TDD.DbTestHelpers.Core;

namespace Blog.DAL.Tests
{
    [TestClass]
    public class RepositoryTests : DbBaseTest<BlogFixtures>
    {
        [TestMethod]
        public void GetAllPost_TwoPostInDb_ReturnOnePost()
        {
            // arrange
            var context = new BlogContext();
            context.Database.CreateIfNotExists();
            //context.Posts.ToList().ForEach(x => context.Posts.Remove(x));
            //context.Posts.Add(new Post { 
            //    Author = "test",
            //    Content = "test test test.."
            //});
            context.SaveChanges();
            var repository = new BlogRepository();
            // act
            var result = repository.GetAllPosts();
            // assert
            Assert.AreEqual(2, result.Count());
        }

        //[TestMethod]
        //public void GetAllPost_TwoPostsInDb_ReturnTwoPost()
        //{
        //    // arrange
        //    var context = new BlogContext();
        //    context.Database.CreateIfNotExists();
        //    var repository = new BlogRepository();
        //    // act
        //    var result = repository.GetAllPosts();
        //    // assert
        //    Assert.AreEqual(2, result.Count());
        //}
    }
}
