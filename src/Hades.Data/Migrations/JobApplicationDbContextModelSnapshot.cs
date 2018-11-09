﻿// <auto-generated />
using Hades.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hades.Core.Migrations
{
    [DbContext(typeof(JobApplicationDbContext))]
    partial class JobApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hades.Core.Data.JobApplication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<string>("Date");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("JobApplications");

                    b.HasData(
                        new { Id = 1, CompanyName = "Company 1", Date = "20/09/2018 Thursday", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum." },
                        new { Id = 2, CompanyName = "Company 2", Date = "20/09/2018 Thursday", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum." },
                        new { Id = 3, CompanyName = "Company 3", Date = "20/09/2018 Thursday", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum." },
                        new { Id = 4, CompanyName = "Company 4", Date = "20/09/2018 Thursday", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum." }
                    );
                });

            modelBuilder.Entity("Hades.Core.Data.JobApplicationStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("JobApplicationId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("JobApplicationId");

                    b.ToTable("JobApplicationStatusHistory");

                    b.HasData(
                        new { Id = 1, JobApplicationId = 1, Status = 1 },
                        new { Id = 2, JobApplicationId = 2, Status = 2 },
                        new { Id = 3, JobApplicationId = 3, Status = 4 },
                        new { Id = 4, JobApplicationId = 4, Status = 3 }
                    );
                });

            modelBuilder.Entity("Hades.Core.Data.JobApplicationStatus", b =>
                {
                    b.HasOne("Hades.Core.Data.JobApplication")
                        .WithMany("StatusHistory")
                        .HasForeignKey("JobApplicationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
