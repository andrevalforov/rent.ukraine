using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCourse.Data.EFContext
{
    public class SeederDb
    {
        //public static void SeedRegions(EFDbContext context)
        //{
        //    if (context.Regions.Count() == 0)
        //    {
        //        var regions = new List<Region>();
        //        regions.Add(new Region { Name = "Київ" });
        //        regions.Add(new Region { Name = "Вінниця" });
        //        regions.Add(new Region { Name = "Дніпро" });
        //        regions.Add(new Region { Name = "Донецьк" });
        //        regions.Add(new Region { Name = "Житомир" });
        //        regions.Add(new Region { Name = "Запоріжжя" });
        //        regions.Add(new Region { Name = "Івано-Франківськ" });
        //        regions.Add(new Region { Name = "Кропивницький" });
        //        regions.Add(new Region { Name = "Луганськ" });
        //        regions.Add(new Region { Name = "Луцьк" });
        //        regions.Add(new Region { Name = "Львів" });
        //        regions.Add(new Region { Name = "Миколаїв" });
        //        regions.Add(new Region { Name = "Одеса" });
        //        regions.Add(new Region { Name = "Полтава" });
        //        regions.Add(new Region { Name = "Рівне" });
        //        regions.Add(new Region { Name = "Суми" });
        //        regions.Add(new Region { Name = "Тернопіль" });
        //        regions.Add(new Region { Name = "Ужгород" });
        //        regions.Add(new Region { Name = "Харків" });
        //        regions.Add(new Region { Name = "Херсон" });
        //        regions.Add(new Region { Name = "Хмельницький" });
        //        regions.Add(new Region { Name = "Черкаси" });
        //        regions.Add(new Region { Name = "Чернівці" });
        //        regions.Add(new Region { Name = "Чернігів" });
                
        //        context.AddRange(regions);
        //        context.SaveChanges();
                
        //    }
        //}
        public static void SeedData(IServiceProvider services, IHostingEnvironment env, IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var manager = scope.ServiceProvider.GetRequiredService<UserManager<DbUser>>();
                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<DbRole>>();
                var context = scope.ServiceProvider.GetRequiredService<EFDbContext>();
                //var emailSender = scope.ServiceProvider.GetRequiredService<IEmailSender>();

                //SeederDb.SeedRegions(context);
            }
        }
    }
}
