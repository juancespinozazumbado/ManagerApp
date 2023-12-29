using Domain.Entity.Agregates.Projects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interfaces
{
    public interface IProjectService
    {
        public Task<bool> CreateProject(Project project);
    }
}
