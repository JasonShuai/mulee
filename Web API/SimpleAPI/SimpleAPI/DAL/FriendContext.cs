using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleAPI.Models;

namespace SimpleAPI.DAL
{
    public class FriendContext:DbContext
    {
        public FriendContext(): base("name=DefaultConnection")
        {

        }
        public DbSet<Friend> Friends { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}