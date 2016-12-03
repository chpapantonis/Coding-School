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
    public class CrowdFundingContext : System.Data.Entity.DbContext, ICrowdFundingContext
    {
        public System.Data.Entity.DbSet<AspNetRole> AspNetRoles { get; set; } // AspNetRoles
        public System.Data.Entity.DbSet<AspNetUser> AspNetUsers { get; set; } // AspNetUsers
        public System.Data.Entity.DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims
        public System.Data.Entity.DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins
        public System.Data.Entity.DbSet<BackerProject> BackerProjects { get; set; } // BackerProject
        public System.Data.Entity.DbSet<Category> Categories { get; set; } // Category
        public System.Data.Entity.DbSet<Project> Projects { get; set; } // Project
        public System.Data.Entity.DbSet<ProjectStatu> ProjectStatus { get; set; } // ProjectStatus
        public System.Data.Entity.DbSet<ProjectUpdate> ProjectUpdates { get; set; } // ProjectUpdate
        public System.Data.Entity.DbSet<Reward> Rewards { get; set; } // Reward
        public System.Data.Entity.DbSet<sys_DatabaseFirewallRule> sys_DatabaseFirewallRules { get; set; } // database_firewall_rules
        public System.Data.Entity.DbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        public System.Data.Entity.DbSet<User> Users { get; set; } // User
        public System.Data.Entity.DbSet<UserProjectComment> UserProjectComments { get; set; } // UserProjectComment

        static CrowdFundingContext()
        {
            System.Data.Entity.Database.SetInitializer<CrowdFundingContext>(null);
        }

        public CrowdFundingContext()
            : base("Name=CrowdFunding")
        {
        }

        public CrowdFundingContext(string connectionString)
            : base(connectionString)
        {
        }

        public CrowdFundingContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
        }

        public CrowdFundingContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public CrowdFundingContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
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

            modelBuilder.Configurations.Add(new AspNetRoleMapping());
            modelBuilder.Configurations.Add(new AspNetUserMapping());
            modelBuilder.Configurations.Add(new AspNetUserClaimMapping());
            modelBuilder.Configurations.Add(new AspNetUserLoginMapping());
            modelBuilder.Configurations.Add(new BackerProjectMapping());
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new ProjectMapping());
            modelBuilder.Configurations.Add(new ProjectStatuMapping());
            modelBuilder.Configurations.Add(new ProjectUpdateMapping());
            modelBuilder.Configurations.Add(new RewardMapping());
            modelBuilder.Configurations.Add(new sys_DatabaseFirewallRuleMapping());
            modelBuilder.Configurations.Add(new SysdiagramMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new UserProjectCommentMapping());
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AspNetRoleMapping(schema));
            modelBuilder.Configurations.Add(new AspNetUserMapping(schema));
            modelBuilder.Configurations.Add(new AspNetUserClaimMapping(schema));
            modelBuilder.Configurations.Add(new AspNetUserLoginMapping(schema));
            modelBuilder.Configurations.Add(new BackerProjectMapping(schema));
            modelBuilder.Configurations.Add(new CategoryMapping(schema));
            modelBuilder.Configurations.Add(new ProjectMapping(schema));
            modelBuilder.Configurations.Add(new ProjectStatuMapping(schema));
            modelBuilder.Configurations.Add(new ProjectUpdateMapping(schema));
            modelBuilder.Configurations.Add(new RewardMapping(schema));
            modelBuilder.Configurations.Add(new sys_DatabaseFirewallRuleMapping(schema));
            modelBuilder.Configurations.Add(new SysdiagramMapping(schema));
            modelBuilder.Configurations.Add(new UserMapping(schema));
            modelBuilder.Configurations.Add(new UserProjectCommentMapping(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
        public int SpAlterdiagram(string diagramname, int? ownerId, int? version, byte[] definition)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var versionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@version", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = version.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!version.HasValue)
                versionParam.Value = System.DBNull.Value;

            var definitionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@definition", SqlDbType = System.Data.SqlDbType.VarBinary, Direction = System.Data.ParameterDirection.Input, Value = definition, Size = -1 };
            if (definitionParam.Value == null)
                definitionParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_alterdiagram] @diagramname, @owner_id, @version, @definition", diagramnameParam, ownerIdParam, versionParam, definitionParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public int SpCreatediagram(string diagramname, int? ownerId, int? version, byte[] definition)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var versionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@version", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = version.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!version.HasValue)
                versionParam.Value = System.DBNull.Value;

            var definitionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@definition", SqlDbType = System.Data.SqlDbType.VarBinary, Direction = System.Data.ParameterDirection.Input, Value = definition, Size = -1 };
            if (definitionParam.Value == null)
                definitionParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_creatediagram] @diagramname, @owner_id, @version, @definition", diagramnameParam, ownerIdParam, versionParam, definitionParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public int SpDropdiagram(string diagramname, int? ownerId)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_dropdiagram] @diagramname, @owner_id", diagramnameParam, ownerIdParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public System.Collections.Generic.List<SpHelpdiagramdefinitionReturnModel> SpHelpdiagramdefinition(string diagramname, int? ownerId)
        {
            int procResult;
            return SpHelpdiagramdefinition(diagramname, ownerId, out procResult);
        }

        public System.Collections.Generic.List<SpHelpdiagramdefinitionReturnModel> SpHelpdiagramdefinition(string diagramname, int? ownerId, out int procResult)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<SpHelpdiagramdefinitionReturnModel>("EXEC @procResult = [dbo].[sp_helpdiagramdefinition] @diagramname, @owner_id", diagramnameParam, ownerIdParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<SpHelpdiagramdefinitionReturnModel>> SpHelpdiagramdefinitionAsync(string diagramname, int? ownerId)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<SpHelpdiagramdefinitionReturnModel>("EXEC [dbo].[sp_helpdiagramdefinition] @diagramname, @owner_id", diagramnameParam, ownerIdParam).ToListAsync();

            return procResultData;
        }

        public System.Collections.Generic.List<SpHelpdiagramsReturnModel> SpHelpdiagrams(string diagramname, int? ownerId)
        {
            int procResult;
            return SpHelpdiagrams(diagramname, ownerId, out procResult);
        }

        public System.Collections.Generic.List<SpHelpdiagramsReturnModel> SpHelpdiagrams(string diagramname, int? ownerId, out int procResult)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<SpHelpdiagramsReturnModel>("EXEC @procResult = [dbo].[sp_helpdiagrams] @diagramname, @owner_id", diagramnameParam, ownerIdParam, procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<SpHelpdiagramsReturnModel>> SpHelpdiagramsAsync(string diagramname, int? ownerId)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<SpHelpdiagramsReturnModel>("EXEC [dbo].[sp_helpdiagrams] @diagramname, @owner_id", diagramnameParam, ownerIdParam).ToListAsync();

            return procResultData;
        }

        public int SpRenamediagram(string diagramname, int? ownerId, string newDiagramname)
        {
            var diagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = diagramname, Size = 128 };
            if (diagramnameParam.Value == null)
                diagramnameParam.Value = System.DBNull.Value;

            var ownerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@owner_id", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ownerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ownerId.HasValue)
                ownerIdParam.Value = System.DBNull.Value;

            var newDiagramnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@new_diagramname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = newDiagramname, Size = 128 };
            if (newDiagramnameParam.Value == null)
                newDiagramnameParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_renamediagram] @diagramname, @owner_id, @new_diagramname", diagramnameParam, ownerIdParam, newDiagramnameParam, procResultParam);
 
            return (int) procResultParam.Value;
        }

        public int SpUpgraddiagrams()
        {
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
 
            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_upgraddiagrams] ", procResultParam);
 
            return (int) procResultParam.Value;
        }

    }
}
// </auto-generated>
