﻿using ForumSystem.Data.Common.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;
using System.Threading.Tasks;
namespace ForumSystem.Data.Models
{
    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            // This will prevate UserManager.CreateAsync from causing exception
            this.CreatedOn = DateTime.Now;
        }
        
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public DateTime CreatedOn { get; set; }

        public bool PreserveCreatedOn { get; set; }
        
        public DateTime? ModifiedOn { get; set; }
        
        [Index]
        public bool IsDeleted { get; set; }
        
        public System.DateTime? DeletedOn { get; set; }
    }
}
