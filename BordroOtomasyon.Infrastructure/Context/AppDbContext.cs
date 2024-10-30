﻿using BordroOtomasyon.Domain.Core.BaseEntites;
using BordroOtomasyon.Domain.Enums;
using BordroOtomasyon.Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BordroOtomasyon.Infrastructure.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //Db setler:


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(IEntityConfiguration).Assembly);
            base.OnModelCreating(builder);
        }
        public override int SaveChanges()
        {
            SetBaseProperties();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            SetBaseProperties();
            return base.SaveChangesAsync(cancellationToken);
        }



        private void SetBaseProperties()
        {
            var entries = ChangeTracker.Entries<BaseEntity>();
            var userId = "UserNotFound";

            foreach (var entry in entries)
            {
                SetIfAdded(entry, userId);
                SetIfModified(entry, userId);
                SetIfDeleted(entry, userId);

            }
        }

        private void SetIfDeleted(EntityEntry<BaseEntity> entry, string userId)
        {
            if (entry.State != EntityState.Deleted)
            {
                return;
            }
            if (entry.Entity is not AuditableEntity entity)
            {
                return;
            }
            entry.State = EntityState.Modified;
            entry.Entity.Status = Status.Deleted;
            entity.DeletedDate = DateTime.Now;
            entity.DeletedBy = userId;
        }

        private void SetIfModified(EntityEntry<BaseEntity> entry, string userId)
        {
            if (entry.State == EntityState.Modified)
            {
                entry.Entity.Status = Status.Modified;
                entry.Entity.ModifiedBy = userId;
                entry.Entity.ModifiedDate = DateTime.Now;
            }
        }

        private void SetIfAdded(EntityEntry<BaseEntity> entry, string userId)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.Status = Status.Added;
                entry.Entity.CreatedBy = userId;
                entry.Entity.CreatedDate = DateTime.Now;
            }
        }


    }
}