﻿using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetTrainingBatch2.ConsoleApp.Models;

namespace DotNetTrainingBatch2.ConsoleApp.EFCoreExamples
{
    public class EFCoreExample
    {
        private readonly AppDbContext _dbContext = new AppDbContext();

        public void Run()
        {
            Read();
            Edit(1);
            Edit(100);
            Create("Test Title", "Test Author", "Test Content");
            Update(1, "Test Title", "Test Author", "Test Content");
            Delete(13);
        }

        #region Read
        public void Read()
        {
            var lst = _dbContext.Blogs.AsNoTracking().ToList();
            foreach (BlogDataModel item in lst)
            {
                Console.WriteLine(item.Blog_Id);
                Console.WriteLine(item.Blog_Title);
                Console.WriteLine(item.Blog_Author);
                Console.WriteLine(item.Blog_Content);
            }
        }
        #endregion

        #region Edit
        private void Edit(int id)
        {
            BlogDataModel? item = _dbContext.Blogs.FirstOrDefault(x => x.Blog_Id == id);
            if (item is null)
            {
                Console.WriteLine("No data found.");
                return;
            }
            Console.WriteLine(item.Blog_Id);
            Console.WriteLine(item.Blog_Title);
            Console.WriteLine(item.Blog_Author);
            Console.WriteLine(item.Blog_Content);
        }
        #endregion

        #region Create
        private void Create(string title, string author, string content)
        {
            BlogDataModel blog = new BlogDataModel()
            {
                Blog_Title = title,
                Blog_Author = author,
                Blog_Content = content
            };

            _dbContext.Blogs.Add(blog);
            int result = _dbContext.SaveChanges();

            string message = result > 0 ? "Saving Successful." : "Saving Failed.";
            Console.WriteLine(message);
        }
        #endregion

        #region Update
        private void Update(int id, string title, string author, string content)
        {
            BlogDataModel? item = _dbContext.Blogs.FirstOrDefault(x => x.Blog_Id == id);
            if (item is null)
            {
                Console.WriteLine("No data found.");
                return;
            }

            item.Blog_Title = title;
            item.Blog_Author = author;
            item.Blog_Content = content;

            int result = _dbContext.SaveChanges();

            string message = result > 0 ? "Updating Successful." : "Updating Failed.";
            Console.WriteLine(message);
        }
        #endregion

        #region Delete
        private void Delete(int id)
        {
            BlogDataModel? item = _dbContext.Blogs.FirstOrDefault(x => x.Blog_Id == id);
            if (item is null)
            {
                Console.WriteLine("No data found.");
                return;
            }

            _dbContext.Blogs.Remove(item);
            int result = _dbContext.SaveChanges();

            string message = result > 0 ? "Deleting Successful." : "Deleting Failed.";
            Console.WriteLine(message);
        }
        #endregion
    }
}
