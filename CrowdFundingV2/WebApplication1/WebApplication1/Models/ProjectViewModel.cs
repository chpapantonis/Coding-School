﻿using CF.Models.Database;
using CF.Models.MVC.Project;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class ProjectViewModel
    {
        public List<Category> Categories { get; set; }
        public int SelectedCategoryId { get; set; }
        public int SelectedStatusId { get; set; }
        public List<ProjectStatu> Statuses { get; set; }
        public int CreatorId { get; set; }
        public string CreatorFullName { get; set; }
        public int NoProjects { get; set; }

        public Project Project { get; set; }

        public IEnumerable<BasicProjectInfoViewModel> MyProjects { get; set; }
    }
}