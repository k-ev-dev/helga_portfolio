﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Helga_portfolio.Domain.Entities;
using Helga_portfolio.Domain.Repositories.Abstract;


namespace Helga_portfolio.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldsRepository {

            private readonly AppDbContext context;
            public EFTextFieldsRepository(AppDbContext context) {
                this.context = context;
            }

            public IQueryable<TextField> GetTextField() {
                return context.TextFields;
            }

            public TextField GetTextFieldById(Guid id) {
                return context.TextFields.FirstOrDefault(x => x.Id == id);
            }

            public TextField GetTextFieldByCodeWord(string codeWord) {
                return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
            }

            public void SaveTextField(TextField entity) {
                if (entity.Id == default)
                    context.Entry(entity).State = EntityState.Added;
                else
                    context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }

            public void DeleteTextField(Guid id) {
                context.TextFields.Remove(new TextField() { Id = id });
                context.SaveChanges();
            }
    }
}
