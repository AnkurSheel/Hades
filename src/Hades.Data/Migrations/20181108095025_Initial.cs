using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hades.Core.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobApplications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobApplicationStatusHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<int>(nullable: false),
                    JobApplicationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobApplicationStatusHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobApplicationStatusHistory_JobApplications_JobApplicationId",
                        column: x => x.JobApplicationId,
                        principalTable: "JobApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "JobApplications",
                columns: new[] { "Id", "CompanyName", "Date", "Description" },
                values: new object[,]
                {
                    { 1, "Company 1", "20/09/2018 Thursday", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum." },
                    { 2, "Company 2", "20/09/2018 Thursday", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum." },
                    { 3, "Company 3", "20/09/2018 Thursday", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum." },
                    { 4, "Company 4", "20/09/2018 Thursday", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incIdIdunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupIdatat non proIdent, sunt in culpa qui officia deserunt mollit anim Id est laborum." }
                });

            migrationBuilder.InsertData(
                table: "JobApplicationStatusHistory",
                columns: new[] { "Id", "JobApplicationId", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 4 },
                    { 4, 4, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobApplicationStatusHistory_JobApplicationId",
                table: "JobApplicationStatusHistory",
                column: "JobApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobApplicationStatusHistory");

            migrationBuilder.DropTable(
                name: "JobApplications");
        }
    }
}
