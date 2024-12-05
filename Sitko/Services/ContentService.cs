using Sitko.Abstract;
using Sitko.Models;

namespace Sitko.Services
{
    public class ContentService
    {
        protected readonly IRepository<LineModel> repositoryLine;
        public ContentService(IRepository<LineModel> repositoryLine)
        {
            this.repositoryLine = repositoryLine;
        }
        public IRepository<LineModel> GetRepositoryLine()
        {
            return repositoryLine;
        }
    }
}
