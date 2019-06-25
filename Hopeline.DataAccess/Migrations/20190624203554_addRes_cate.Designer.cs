﻿// <auto-generated />
using System;
using Hopeline.DataAccess.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hopeline.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190624203554_addRes_cate")]
    partial class addRes_cate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hopeline.DataAccess.Entities.Community", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dateAdded");

                    b.Property<string>("desc");

                    b.Property<int>("enabled_flg");

                    b.Property<byte[]>("image");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("url")
                        .IsRequired();

                    b.Property<string>("user_code")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("communities");
                });

            modelBuilder.Entity("Hopeline.DataAccess.Entities.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dateAdded");

                    b.Property<string>("desc");

                    b.Property<int>("enabled_flg");

                    b.Property<byte[]>("image");

                    b.Property<int?>("resource_categoryId");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("url")
                        .IsRequired();

                    b.Property<string>("user_code")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("resource_categoryId");

                    b.ToTable("resources");
                });

            modelBuilder.Entity("Hopeline.DataAccess.Entities.Resource_Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("category_decription");

                    b.Property<string>("category_name")
                        .IsRequired();

                    b.Property<string>("dateAdded");

                    b.Property<string>("user_code")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("resource_categories");
                });

            modelBuilder.Entity("Hopeline.DataAccess.Entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dateAdded");

                    b.Property<string>("desc");

                    b.Property<int>("enabled_flg");

                    b.Property<string>("topic_name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("user_code")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("topics");
                });

            modelBuilder.Entity("Hopeline.DataAccess.Entities.Resource", b =>
                {
                    b.HasOne("Hopeline.DataAccess.Entities.Resource_Category", "resource_category")
                        .WithMany("resources")
                        .HasForeignKey("resource_categoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
