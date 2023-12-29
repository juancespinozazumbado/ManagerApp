using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity.Agregates.Projects
{
    public class Project : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ProjectItem> Items { get; set; }


    }

    public class ProjectItem : BaseEntity
    {
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }


    }
}
