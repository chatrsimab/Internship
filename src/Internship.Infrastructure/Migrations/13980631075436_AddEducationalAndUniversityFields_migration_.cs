using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Internship.Infrastructure.Migrations
{
    public partial class AddEducationalAndUniversityFields_migration_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankEducationalGrade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankEducationalGrade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankUniversityType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankUniversityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankEducationalField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BankEducationalGradeId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankEducationalField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankEducationalField_BankEducationalGrade_BankEducationalGradeId",
                        column: x => x.BankEducationalGradeId,
                        principalTable: "BankEducationalGrade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankUniversityName",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    BankUniversityTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankUniversityName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankUniversityName_BankUniversityType_BankUniversityTypeId",
                        column: x => x.BankUniversityTypeId,
                        principalTable: "BankUniversityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankEducationalOrientation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    BankEducationalFieldId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankEducationalOrientation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankEducationalOrientation_BankEducationalField_BankEducationalFieldId",
                        column: x => x.BankEducationalFieldId,
                        principalTable: "BankEducationalField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankTraineeMaster",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    BankUniversityNameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankTraineeMaster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankTraineeMaster_BankUniversityName_BankUniversityNameId",
                        column: x => x.BankUniversityNameId,
                        principalTable: "BankUniversityName",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankEducationalField_BankEducationalGradeId",
                table: "BankEducationalField",
                column: "BankEducationalGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_BankEducationalOrientation_BankEducationalFieldId",
                table: "BankEducationalOrientation",
                column: "BankEducationalFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_BankTraineeMaster_BankUniversityNameId",
                table: "BankTraineeMaster",
                column: "BankUniversityNameId");

            migrationBuilder.CreateIndex(
                name: "IX_BankUniversityName_BankUniversityTypeId",
                table: "BankUniversityName",
                column: "BankUniversityTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankEducationalOrientation");

            migrationBuilder.DropTable(
                name: "BankTraineeMaster");

            migrationBuilder.DropTable(
                name: "BankEducationalField");

            migrationBuilder.DropTable(
                name: "BankUniversityName");

            migrationBuilder.DropTable(
                name: "BankEducationalGrade");

            migrationBuilder.DropTable(
                name: "BankUniversityType");
        }
    }
}
