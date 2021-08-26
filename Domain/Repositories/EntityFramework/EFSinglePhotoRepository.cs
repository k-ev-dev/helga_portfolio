using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Helga_portfolio.Domain.Entities;
using Helga_portfolio.Domain.Repositories.Abstract;

namespace Helga_portfolio.Domain.Repositories.EntityFramework
{
    public class EFSinglePhotoRepository : ISinglePhotoRepository {
        
            private readonly AppDbContext context;
            public EFSinglePhotoRepository(AppDbContext context) {
                this.context = context;
            }

            public IQueryable<SinglePhoto> GetSinglePhoto() {
                return context.SinglePhotos;
            }

            public SinglePhoto GetSinglePhotoById(Guid id) {
                return context.SinglePhotos.FirstOrDefault(x => x.Id == id);
            }

            public void SaveSinglePhoto(SinglePhoto entity) {
                if (entity.Id == default)
                    context.Entry(entity).State = EntityState.Added;
                else
                    context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }

            public void DeleteSinglePhotoById(Guid id) {
                context.SinglePhotos.Remove(new SinglePhoto() { Id = id });
                context.SaveChanges();
            }
    }
}
