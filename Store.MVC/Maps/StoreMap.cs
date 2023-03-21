using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using StoreModel = Store.MVC.Models.Store;


namespace Store.MVC.Maps
{
    public class StoreMap
    {
        public StoreMap(EntityTypeBuilder<StoreModel> entityBuilder) 
        {
            entityBuilder.HasKey(x => x.IdGuid);
                entityBuilder.ToTable("store");

            entityBuilder.Property(x => x.IdGuid).HasColumnName("idGuid").HasColumnType("Guid");
            entityBuilder.Property(x => x.Name).HasColumnName("name");  
        }   
    }
}
