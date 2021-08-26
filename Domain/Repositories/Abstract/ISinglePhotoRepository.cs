using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helga_portfolio.Domain.Entities;

namespace Helga_portfolio.Domain.Repositories.Abstract
{
    public interface ISinglePhotoRepository
    {

        IQueryable<SinglePhoto> GetSinglePhoto();
        SinglePhoto GetSinglePhotoById(Guid id);
        void SaveSinglePhoto(SinglePhoto entity);
        void DeleteSinglePhotoById(Guid id);
    }
}
