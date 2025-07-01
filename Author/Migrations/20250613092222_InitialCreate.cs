using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Author.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assesements",
                columns: table => new
                {
                    AssesementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assesements", x => x.AssesementId);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    CandidateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidateName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.CandidateId);
                });

            migrationBuilder.CreateTable(
                name: "CandidateAssesements",
                columns: table => new
                {
                    AssessmentsAssesementId = table.Column<int>(type: "int", nullable: false),
                    CandidatesCandidateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateAssesements", x => new { x.AssessmentsAssesementId, x.CandidatesCandidateId });
                    table.ForeignKey(
                        name: "FK_CandidateAssesements_Assesements_AssessmentsAssesementId",
                        column: x => x.AssessmentsAssesementId,
                        principalTable: "Assesements",
                        principalColumn: "AssesementId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateAssesements_Candidates_CandidatesCandidateId",
                        column: x => x.CandidatesCandidateId,
                        principalTable: "Candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateAssesements_CandidatesCandidateId",
                table: "CandidateAssesements",
                column: "CandidatesCandidateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateAssesements");

            migrationBuilder.DropTable(
                name: "Assesements");

            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}
