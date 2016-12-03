﻿using CF.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

using System.Data;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        private CrowdFundingContext db = new CrowdFundingContext();
        public ActionResult Index()
        {
            var categories = db.Categories
                            .Include(p => p.Projects)
                            .Select(y => new CategoryViewModel()
                            {
                                Id = y.Id,
                                Name = y.Name,
                                NoProjects = y.Projects.Count()
                            });

            var project = db.Projects
                           .Include(p=>p.Category)
                           .Include(p => p.User)
                           .Include(p => p.BackerProjects)
                           .Include(p => p.UserProjectComments)
                           .Where(p => p.DueDate >= DateTime.Now)
                           .Select(y => new BasicProjectInfoViewModel()
                           {
                               Id = y.Id,
                               CategoryId = y.CategoryId,
                               CategoryName = y.Category.Name,
                               Title = y.Title,
                               CreatorFullName = y.User.AspNetUser.FirstName + " " + y.User.AspNetUser.FirstName,
                               Description = y.Description,
                               CurrentFund = y.CurrentFundAmount,
                               Ratio = (int)Math.Floor((y.Ratio * 100)),
                               CurrentBackerCount = y.BackerProjects.Where(x => x.ProjectId == y.Id).Count(),
                               DueDate = y.DueDate,
                               NoComments = y.UserProjectComments.Where(x => x.ProjectId == y.Id).Count(),
                           }).FirstOrDefault();

            

            var popularProject = db.Projects
                .Include(p => p.Category)
               .Include(p => p.User)
               .Include(p => p.BackerProjects)
               .Include(p => p.UserProjectComments)
               .Where(p => p.DueDate >= DateTime.Now)
               .Select(y => new BasicProjectInfoViewModel()
               {
                   Id = y.Id,
                   CategoryId = y.CategoryId,
                   CategoryName = y.Category.Name,
                   Title = y.Title,
                   CreatorFullName = y.User.AspNetUser.FirstName + " " + y.User.AspNetUser.FirstName,
                   Description = y.Description,
                   CurrentFund = y.CurrentFundAmount,
                   Ratio = (int)Math.Floor((y.Ratio * 100)),
                   CurrentBackerCount = y.BackerProjects.Where(x => x.ProjectId == y.Id).Count(),
                   DueDate = y.DueDate,
                   NoComments = y.UserProjectComments.Where(x => x.ProjectId == y.Id).Count(),
               }).Take(4);

            
            var viewModel = new HomeIndexViewModel()
            {
                Categories = categories.ToList(),
                TopProject = project,
                PopularProjects = popularProject.ToList()
            };
            return View(viewModel);
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            return View();
        }
    }
}