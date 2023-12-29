using Aplication.Interfaces;
using Domain.Entity.Agregates.Projects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IRepository<Project> _projecRepository;

        public ProjectService(IRepository<Project> projecRepository)
        {
            _projecRepository = projecRepository;
        }

        public async Task<bool>  CreateProject(Project project)
        {
            try
            {
                return await _projecRepository.Insert(project);  

            }catch (Exception ex) { 
            }
            return false;
        }
    }
}
