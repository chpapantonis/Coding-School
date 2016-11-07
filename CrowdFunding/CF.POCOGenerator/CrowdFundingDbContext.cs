// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace CF.POCOGenerator
{

    using System.Linq;

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class CrowdFundingDbContext : System.Data.Entity.DbContext, ICrowdFundingDbContext
    {
        public System.Data.Entity.DbSet<BackerProject> BackerProjects { get; set; } // BackerProject
        public System.Data.Entity.DbSet<Category> Categories { get; set; } // Category
        public System.Data.Entity.DbSet<Project> Projects { get; set; } // Project
        public System.Data.Entity.DbSet<ProjectStatu> ProjectStatus { get; set; } // ProjectStatus
        public System.Data.Entity.DbSet<ProjectUpdate> ProjectUpdates { get; set; } // ProjectUpdate
        public System.Data.Entity.DbSet<Reward> Rewards { get; set; } // Reward
        public System.Data.Entity.DbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        public System.Data.Entity.DbSet<User> Users { get; set; } // User
        public System.Data.Entity.DbSet<UserProjectComment> UserProjectComments { get; set; } // UserProjectComment

        static CrowdFundingDbContext()
        {
            System.Data.Entity.Database.SetInitializer<CrowdFundingDbContext>(null);
        }

        public CrowdFundingDbContext()
            : base("Name=CrowdFunding")
        {
        }

        public CrowdFundingDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public CrowdFundingDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public CrowdFundingDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public CrowdFundingDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BackerProjectMapping());
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new ProjectMapping());
            modelBuilder.Configurations.Add(new ProjectStatuMapping());
            modelBuilder.Configurations.Add(new ProjectUpdateMapping());
            modelBuilder.Configurations.Add(new RewardMapping());
            modelBuilder.Configurations.Add(new SysdiagramMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new UserProjectCommentMapping());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new BackerProjectMapping(schema));
            modelBuilder.Configurations.Add(new CategoryMapping(schema));
            modelBuilder.Configurations.Add(new ProjectMapping(schema));
            modelBuilder.Configurations.Add(new ProjectStatuMapping(schema));
            modelBuilder.Configurations.Add(new ProjectUpdateMapping(schema));
            modelBuilder.Configurations.Add(new RewardMapping(schema));
            modelBuilder.Configurations.Add(new SysdiagramMapping(schema));
            modelBuilder.Configurations.Add(new UserMapping(schema));
            modelBuilder.Configurations.Add(new UserProjectCommentMapping(schema));
            return modelBuilder;
        }
    }
}
// </auto-generated>