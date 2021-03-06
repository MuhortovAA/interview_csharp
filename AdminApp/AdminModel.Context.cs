//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AdminEntities : DbContext
    {
        public AdminEntities()
            : base("name=AdminEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<UserRoli> UserRoli { get; set; }
        public virtual DbSet<UsersBank> UsersBank { get; set; }
        public virtual DbSet<roli> roli { get; set; }
        public virtual DbSet<Branches> Branches { get; set; }
        public virtual DbSet<vBankUserInfo> vBankUserInfo { get; set; }
    
        public virtual ObjectResult<LUserARM_Result> LUserARM(string login, string password, string keySN, Nullable<int> typeArmID, ObjectParameter errorCode)
        {
            var loginParameter = login != null ?
                new ObjectParameter("Login", login) :
                new ObjectParameter("Login", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var keySNParameter = keySN != null ?
                new ObjectParameter("KeySN", keySN) :
                new ObjectParameter("KeySN", typeof(string));
    
            var typeArmIDParameter = typeArmID.HasValue ?
                new ObjectParameter("TypeArmID", typeArmID) :
                new ObjectParameter("TypeArmID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LUserARM_Result>("LUserARM", loginParameter, passwordParameter, keySNParameter, typeArmIDParameter, errorCode);
        }
    }
}
