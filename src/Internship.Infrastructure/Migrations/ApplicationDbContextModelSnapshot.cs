﻿// <auto-generated />
using System;
using Internship.Infrastructure.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Internship.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.AppDataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FriendlyName");

                    b.Property<string>("XmlData");

                    b.HasKey("Id");

                    b.HasIndex("FriendlyName")
                        .IsUnique()
                        .HasFilter("[FriendlyName] IS NOT NULL");

                    b.ToTable("AppDataProtectionKeys");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.AppLogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<int>("EventId");

                    b.Property<string>("LogLevel");

                    b.Property<string>("Logger");

                    b.Property<string>("Message");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("StateJson");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("AppLogItems");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.AppSqlCache", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(449);

                    b.Property<DateTimeOffset?>("AbsoluteExpiration");

                    b.Property<DateTimeOffset>("ExpiresAtTime");

                    b.Property<long?>("SlidingExpirationInSeconds");

                    b.Property<byte[]>("Value")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ExpiresAtTime")
                        .HasName("Index_ExpiresAtTime");

                    b.ToTable("AppSqlCache","dbo");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("Description");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTimeOffset?>("BirthDate");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .HasMaxLength(450);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsEmailPublic");

                    b.Property<string>("LastName")
                        .HasMaxLength(450);

                    b.Property<DateTimeOffset?>("LastVisitDateTime");

                    b.Property<string>("Location");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PhotoFileName")
                        .HasMaxLength(450);

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.UserToken", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.UserUsedPassword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserUsedPasswords");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Notice2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<DateTime>("CreateDate");

                    b.Property<int?>("CreatorUserId");

                    b.Property<int?>("EntityId");

                    b.Property<bool>("IsRead");

                    b.Property<int?>("RoutineId");

                    b.Property<int?>("ToUserId");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("RoutineId");

                    b.HasIndex("ToUserId");

                    b.ToTable("Notice2");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PkColumnName")
                        .HasMaxLength(1024);

                    b.Property<string>("TableName")
                        .HasMaxLength(1024);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(1024);

                    b.HasKey("Id");

                    b.ToTable("Routine2");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Action", b =>
                {
                    b.Property<int>("RoutineId");

                    b.Property<int>("Step");

                    b.Property<string>("Action")
                        .HasMaxLength(32);

                    b.Property<string>("Color")
                        .HasMaxLength(64);

                    b.Property<string>("Icon")
                        .HasMaxLength(64);

                    b.Property<bool>("IsDescriptionMultiline");

                    b.Property<bool>("IsDescriptionRequired");

                    b.Property<bool>("ShouldHideDescription");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(2048);

                    b.HasKey("RoutineId", "Step", "Action");

                    b.ToTable("Routine2Action");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Autodash", b =>
                {
                    b.Property<int>("RoutineId");

                    b.Property<int>("Step");

                    b.Property<int>("ToStep");

                    b.Property<int>("TimeoutDays");

                    b.HasKey("RoutineId", "Step", "ToStep");

                    b.ToTable("Routine2Autodash");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasMaxLength(1024);

                    b.Property<DateTime>("ActionDate");

                    b.Property<int?>("CreatorUserId");

                    b.Property<string>("Description");

                    b.Property<int>("EntityId");

                    b.Property<int>("RoutineId");

                    b.Property<string>("RoutineRoleTitle")
                        .HasMaxLength(1024);

                    b.Property<int>("Step");

                    b.Property<int?>("ToStep");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.HasIndex("UserId");

                    b.ToTable("Routine2Log");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Notice", b =>
                {
                    b.Property<int>("RoutineId");

                    b.Property<int>("FromStep");

                    b.Property<int>("ToStep");

                    b.Property<string>("Key")
                        .HasMaxLength(32);

                    b.Property<string>("Body");

                    b.Property<string>("BodyEmail");

                    b.Property<string>("BodySms");

                    b.Property<string>("ModelSqlQuery");

                    b.Property<string>("Title")
                        .HasMaxLength(512);

                    b.Property<string>("UserIdsSqlQuery");

                    b.HasKey("RoutineId", "FromStep", "ToStep", "Key");

                    b.ToTable("Routine2Notice");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Reminder", b =>
                {
                    b.Property<int>("RoutineId");

                    b.Property<int>("Step");

                    b.Property<string>("Key")
                        .HasMaxLength(32);

                    b.Property<int>("TimeoutDays");

                    b.Property<string>("Body");

                    b.Property<string>("BodyEmail");

                    b.Property<string>("BodySms");

                    b.Property<string>("ModelSqlQuery");

                    b.Property<string>("UserIdsSqlQuery");

                    b.HasKey("RoutineId", "Step", "Key", "TimeoutDays");

                    b.ToTable("Routine2Reminder");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Role", b =>
                {
                    b.Property<int>("RoutineId");

                    b.Property<string>("DashboardEnum")
                        .HasMaxLength(1024);

                    b.Property<int>("SortOrder");

                    b.Property<string>("StepsJson")
                        .IsRequired()
                        .HasMaxLength(2048);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("RoutineId", "DashboardEnum");

                    b.ToTable("Routine2Role");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Step", b =>
                {
                    b.Property<int>("RoutineId");

                    b.Property<int>("Step");

                    b.Property<int?>("F1");

                    b.Property<int?>("F2");

                    b.Property<int?>("F3");

                    b.Property<int?>("F4");

                    b.Property<int?>("F5");

                    b.Property<int?>("F6");

                    b.Property<int?>("F7");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(2048);

                    b.HasKey("RoutineId", "Step");

                    b.ToTable("Routine2Step");
                });

            modelBuilder.Entity("Internship.Core.Entity.Internship.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Branchs");
                });

            modelBuilder.Entity("Internship.Core.Entity.Internship.InternshipCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("InternshipCenters");
                });

            modelBuilder.Entity("Internship.Core.Entity.Internship.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("RoutineFlownDate");

                    b.Property<bool>("RoutineIsDone");

                    b.Property<bool>("RoutineIsFlown");

                    b.Property<bool>("RoutineIsSucceeded");

                    b.Property<int>("RoutineStep");

                    b.Property<DateTime?>("RoutineStepChangeDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.RoleClaim", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Identity.Role", "Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.UserClaim", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Identity.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.UserLogin", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Identity.User", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.UserRole", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Identity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Internship.Core.DomainModels.Entity.Identity.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.UserToken", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Identity.User", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Identity.UserUsedPassword", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Identity.User", "User")
                        .WithMany("UserUsedPasswords")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Notice2", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Identity.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");

                    b.HasOne("Internship.Core.DomainModels.Entity.Routine2.Routine2", "Routine")
                        .WithMany()
                        .HasForeignKey("RoutineId");

                    b.HasOne("Internship.Core.DomainModels.Entity.Identity.User", "ToUser")
                        .WithMany()
                        .HasForeignKey("ToUserId");
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Action", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Routine2.Routine2", "Routine")
                        .WithMany("Actions")
                        .HasForeignKey("RoutineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Autodash", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Routine2.Routine2", "Routine")
                        .WithMany("Autodashes")
                        .HasForeignKey("RoutineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Log", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Identity.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");

                    b.HasOne("Internship.Core.DomainModels.Entity.Identity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Notice", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Routine2.Routine2", "Routine")
                        .WithMany("Notices")
                        .HasForeignKey("RoutineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Reminder", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Routine2.Routine2", "Routine")
                        .WithMany("Reminders")
                        .HasForeignKey("RoutineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Role", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Routine2.Routine2", "Routine")
                        .WithMany("Roles")
                        .HasForeignKey("RoutineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Internship.Core.DomainModels.Entity.Routine2.Routine2Step", b =>
                {
                    b.HasOne("Internship.Core.DomainModels.Entity.Routine2.Routine2", "Routine")
                        .WithMany("Steps")
                        .HasForeignKey("RoutineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Internship.Core.Entity.Internship.InternshipCenter", b =>
                {
                    b.HasOne("Internship.Core.Entity.Internship.Branch", "Branch")
                        .WithMany("internshipCenters")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
