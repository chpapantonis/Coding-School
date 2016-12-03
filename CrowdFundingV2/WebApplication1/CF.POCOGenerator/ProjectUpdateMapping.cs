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

    // ProjectUpdate
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class ProjectUpdateMapping : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ProjectUpdate>
    {
        public ProjectUpdateMapping()
            : this("dbo")
        {
        }

        public ProjectUpdateMapping(string schema)
        {
            ToTable("ProjectUpdate", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProjectId).HasColumnName(@"ProjectId").IsRequired().HasColumnType("int");
            Property(x => x.Text).HasColumnName(@"Text").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.DateInserted).HasColumnName(@"DateInserted").IsRequired().HasColumnType("datetime");

            // Foreign keys
            HasRequired(a => a.Project).WithMany(b => b.ProjectUpdates).HasForeignKey(c => c.ProjectId).WillCascadeOnDelete(false); // FK_ProjectUpdate_Project
        }
    }

}
// </auto-generated>
