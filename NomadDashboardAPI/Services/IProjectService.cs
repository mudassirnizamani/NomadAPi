﻿using NomadDashboardAPI.Contexts;
using NomadDashboardAPI.Interfaces;
using NomadDashboardAPI.Models;
using NomadDashboardAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NomadDashboardAPI.Services
{
    public class IProjectService : IProject
    {
        private readonly APIContext _context;

        public IProjectService(APIContext context)
        {
            _context = context;
        }

        public void CreateProject(ProjectModel model)
        {
            if (model != null)
            {
                Project project = new Project
                {
                    ClientId = model.ClientId,
                    DeadLine = model.DeadLine,
                    Description = model.Description,
                    Name = model.Name,
                    Progress = model.Progress,
                    Rate = model.Rate,
                    StartDate = model.StartDate,
                    Status = model.Status
                };

                _context.Add(project);
            }
            else throw new ArgumentNullException(nameof(model));
        }

        public void DeleteProjcet(Project model)
        {
            if (model != null)
            {
                _context.Remove(model);
            }
            else throw new ArgumentNullException(nameof(model));
        }

        public IEnumerable<Project> GetAllProject()
        {
            return _context.Projects.ToList();
        }

        public Project GetProjectById(string id)
        {
            return _context.Projects.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

    }
}