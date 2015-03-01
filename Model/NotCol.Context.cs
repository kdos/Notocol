﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NotColEntities : DbContext
    {
        public NotColEntities()
            : base("name=NotColEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<SourceTag> SourceTags { get; set; }
    
        public virtual int SaveSource(string tags, Nullable<long> userID, string title, string link, string summary, Nullable<bool> readLater, Nullable<bool> saveOffline, Nullable<bool> privacy, Nullable<int> rating)
        {
            var tagsParameter = tags != null ?
                new ObjectParameter("tags", tags) :
                new ObjectParameter("tags", typeof(string));
    
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(long));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var linkParameter = link != null ?
                new ObjectParameter("link", link) :
                new ObjectParameter("link", typeof(string));
    
            var summaryParameter = summary != null ?
                new ObjectParameter("summary", summary) :
                new ObjectParameter("summary", typeof(string));
    
            var readLaterParameter = readLater.HasValue ?
                new ObjectParameter("readLater", readLater) :
                new ObjectParameter("readLater", typeof(bool));
    
            var saveOfflineParameter = saveOffline.HasValue ?
                new ObjectParameter("saveOffline", saveOffline) :
                new ObjectParameter("saveOffline", typeof(bool));
    
            var privacyParameter = privacy.HasValue ?
                new ObjectParameter("privacy", privacy) :
                new ObjectParameter("privacy", typeof(bool));
    
            var ratingParameter = rating.HasValue ?
                new ObjectParameter("rating", rating) :
                new ObjectParameter("rating", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SaveSource", tagsParameter, userIDParameter, titleParameter, linkParameter, summaryParameter, readLaterParameter, saveOfflineParameter, privacyParameter, ratingParameter);
        }
    
        public virtual ObjectResult<GetTags_Result> GetTags(Nullable<long> userID, string strToSearch)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(long));
    
            var strToSearchParameter = strToSearch != null ?
                new ObjectParameter("strToSearch", strToSearch) :
                new ObjectParameter("strToSearch", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetTags_Result>("GetTags", userIDParameter, strToSearchParameter);
        }
    }
}
