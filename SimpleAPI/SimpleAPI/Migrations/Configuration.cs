namespace SimpleAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SimpleAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleAPI.DAL.FriendContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimpleAPI.DAL.FriendContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var friend = new Friend
            {
                FirstName = "三",
                LastName = "张",
                Address = "南京西路",
                City = "上海",
                Country = "中国",
                PostalCode = "200041",
                Notes = "www.zhaomu.com"
            };
            context.Friends.Add(friend);
            friend = new Friend
            {
                FirstName = "四",
                LastName = "李",
                Address = "三里屯",
                City = "北京",
                Country = "中国",
                PostalCode = "100600",
                Notes = "www.sohu.com"
            };
            context.Friends.Add(friend);
            friend = new Friend
            {
                FirstName = "五",
                LastName = "王",
                Address = "花城大道",
                City = "广州",
                Country = "中国",
                PostalCode = "510623",
                Notes = "www.163.com"
            };
            context.Friends.Add(friend);
        }
    }
}
