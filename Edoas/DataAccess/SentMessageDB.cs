using Edoas.DataAccess.DataEntity;
using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edoas.DataAccess
{
    public class SentMessageDB : DbContext
    {
        //定义属性，便于外部访问数据表
        public DbSet<SentMessageEntity> SentMessages { get { return Set<SentMessageEntity>(); } }

        public SentMessageDB() : base("dbConn")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            ModelConfiguration.Configure(modelBuilder);
            var init = new SqliteCreateDatabaseIfNotExists<SentMessageDB>(modelBuilder);
            Database.SetInitializer(init);
            // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }

    public class ModelConfiguration
    {
        public static void Configure(DbModelBuilder modelBuilder)
        {
            ConfigureMessageEntity(modelBuilder);
        }
        private static void ConfigureMessageEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SentMessageEntity>();
        }
    }
}
