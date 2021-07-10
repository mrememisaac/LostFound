using LostFound.Core.ProjectAggregate;
using System.Collections.Generic;

namespace LostFound.Web.Endpoints.ProjectEndpoints
{
    public class ProjectListResponse
    {
        public List<ProjectRecord> Projects { get; set; } = new();
    }
}
