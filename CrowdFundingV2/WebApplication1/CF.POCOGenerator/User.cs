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

    // User
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public class User
    {
        public int Id { get; set; } // Id (Primary key)
        public string AspNetUsersId { get; set; } // AspNetUsersId (length: 128)
        public string PhotoUrl { get; set; } // PhotoUrl
        public byte[] Image { get; set; } // Image

        // Reverse navigation
        public virtual System.Collections.Generic.ICollection<BackerProject> BackerProjects { get; set; } // BackerProject.FK_BackerProject_User
        public virtual System.Collections.Generic.ICollection<Project> Projects { get; set; } // Project.FK_Project_User
        public virtual System.Collections.Generic.ICollection<UserProjectComment> UserProjectComments { get; set; } // UserProjectComment.FK_UserProjectComment_User

        // Foreign keys
        public virtual AspNetUser AspNetUser { get; set; } // FK_User_AspNetUsers

        public User()
        {
            BackerProjects = new System.Collections.Generic.List<BackerProject>();
            Projects = new System.Collections.Generic.List<Project>();
            UserProjectComments = new System.Collections.Generic.List<UserProjectComment>();
        }
    }

}
// </auto-generated>
