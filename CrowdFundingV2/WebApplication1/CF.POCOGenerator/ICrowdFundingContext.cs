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

    public interface ICrowdFundingContext : System.IDisposable
    {
        System.Data.Entity.DbSet<AspNetRole> AspNetRoles { get; set; } // AspNetRoles
        System.Data.Entity.DbSet<AspNetUser> AspNetUsers { get; set; } // AspNetUsers
        System.Data.Entity.DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } // AspNetUserClaims
        System.Data.Entity.DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } // AspNetUserLogins
        System.Data.Entity.DbSet<BackerProject> BackerProjects { get; set; } // BackerProject
        System.Data.Entity.DbSet<Category> Categories { get; set; } // Category
        System.Data.Entity.DbSet<Project> Projects { get; set; } // Project
        System.Data.Entity.DbSet<ProjectStatu> ProjectStatus { get; set; } // ProjectStatus
        System.Data.Entity.DbSet<ProjectUpdate> ProjectUpdates { get; set; } // ProjectUpdate
        System.Data.Entity.DbSet<Reward> Rewards { get; set; } // Reward
        System.Data.Entity.DbSet<sys_DatabaseFirewallRule> sys_DatabaseFirewallRules { get; set; } // database_firewall_rules
        System.Data.Entity.DbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        System.Data.Entity.DbSet<User> Users { get; set; } // User
        System.Data.Entity.DbSet<UserProjectComment> UserProjectComments { get; set; } // UserProjectComment

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);

        // Stored Procedures
        int SpAlterdiagram(string diagramname, int? ownerId, int? version, byte[] definition);
        // SpAlterdiagramAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int SpCreatediagram(string diagramname, int? ownerId, int? version, byte[] definition);
        // SpCreatediagramAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int SpDropdiagram(string diagramname, int? ownerId);
        // SpDropdiagramAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        System.Collections.Generic.List<SpHelpdiagramdefinitionReturnModel> SpHelpdiagramdefinition(string diagramname, int? ownerId);
        System.Collections.Generic.List<SpHelpdiagramdefinitionReturnModel> SpHelpdiagramdefinition(string diagramname, int? ownerId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<SpHelpdiagramdefinitionReturnModel>> SpHelpdiagramdefinitionAsync(string diagramname, int? ownerId);

        System.Collections.Generic.List<SpHelpdiagramsReturnModel> SpHelpdiagrams(string diagramname, int? ownerId);
        System.Collections.Generic.List<SpHelpdiagramsReturnModel> SpHelpdiagrams(string diagramname, int? ownerId, out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<SpHelpdiagramsReturnModel>> SpHelpdiagramsAsync(string diagramname, int? ownerId);

        int SpRenamediagram(string diagramname, int? ownerId, string newDiagramname);
        // SpRenamediagramAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

        int SpUpgraddiagrams();
        // SpUpgraddiagramsAsync cannot be created due to having out parameters, or is relying on the procedure result (int)

    }

}
// </auto-generated>
