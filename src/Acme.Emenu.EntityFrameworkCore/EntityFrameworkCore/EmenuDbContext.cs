using Acme.Emenu.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Acme.Emenu.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class EmenuDbContext :
    AbpDbContext<EmenuDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    // Project Entities
    public DbSet<Product> Products{ get; set; }
    public DbSet<ProductTranslation> ProductTranslations  { get; set; }
    public DbSet<AttributeType> AttributeTypes { get; set; }
    public DbSet<AttributeOption> AttributeOptions { get; set; }
    public DbSet<ProductAttribute> ProductAttributes { get; set; }
    public DbSet<Variant> Variants{ get; set; }
    public DbSet<VariantAttributeOption> VariantAttributeOptions { get; set; }




    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }


    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public EmenuDbContext(DbContextOptions<EmenuDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(EmenuConsts.DbTablePrefix + "YourEntities", EmenuConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});


        //Product Entity
        builder.Entity<Product>(b =>
        {
            b.ToTable(EmenuConsts.DbTablePrefix + "Products", EmenuConsts.DbSchema);
            b.ConfigureByConvention();
            // Configure other properties as needed
        });
        //ProductTranslation Entity
        builder.Entity<ProductTranslation>(b =>
        {
            b.ToTable(EmenuConsts.DbTablePrefix + "ProductTranslations", EmenuConsts.DbSchema);
            b.ConfigureByConvention();
            b.HasIndex(pt => new { pt.ProductId, pt.Language }).IsUnique();
            // Configure other properties as needed

            b.HasOne(pt => pt.Product)
                .WithMany(p => p.Translations)
                .HasForeignKey(pt => pt.ProductId)
                .OnDelete(DeleteBehavior.Cascade); // Choose the appropriate delete behavior
        });

        //Attribute
        builder.Entity<AttributeType>(b =>
        {
            b.HasIndex(pa => pa.Name).IsUnique();
        });

        //Attribute Option
        builder.Entity<AttributeOption>(b =>
        {
            b.HasIndex(pa => new { pa.AttributeTypeId, pa.Value}).IsUnique();
        });

        //Product Attribute
        builder.Entity<ProductAttribute>(b =>
            b.HasIndex(pa => new { pa.ProductId, pa.AttributeTypeId }).IsUnique()
        );

    }
}
