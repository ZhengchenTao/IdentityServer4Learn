﻿// <auto-generated />
using System;
using IdentityServer.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IdentityServer.Infrastructure.Migrations
{
    [DbContext(typeof(IdentityContext))]
    [Migration("20190925030035_addProvider")]
    partial class addProvider
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityServer.Infrastructure.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<string>("Summary")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("IdentityServer.Infrastructure.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Email")
                        .HasMaxLength(50);

                    b.Property<string>("Identity");

                    b.Property<string>("Password")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasMaxLength(11);

                    b.Property<string>("Provider");

                    b.Property<string>("UserName")
                        .HasMaxLength(50);

                    b.Property<Guid?>("UserProfileId");

                    b.HasKey("Id");

                    b.HasIndex("UserProfileId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("IdentityServer.Infrastructure.Entities.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("Brithday");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int?>("Sex");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("IdentityServer.Infrastructure.Entities.UserRole", b =>
                {
                    b.Property<Guid>("UserId");

                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("Id");

                    b.HasKey("UserId", "RoleId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("IdentityServer.Infrastructure.Entities.User", b =>
                {
                    b.HasOne("IdentityServer.Infrastructure.Entities.UserProfile", "UserProfile")
                        .WithMany()
                        .HasForeignKey("UserProfileId");
                });

            modelBuilder.Entity("IdentityServer.Infrastructure.Entities.UserRole", b =>
                {
                    b.HasOne("IdentityServer.Infrastructure.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IdentityServer.Infrastructure.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}