using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task.Migrations
{
    public partial class ewewe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CirtficatNum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CertificationUser",
                columns: table => new
                {
                    CertificationsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificationUser", x => new { x.CertificationsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_CertificationUser_Certifications_CertificationsId",
                        column: x => x.CertificationsId,
                        principalTable: "Certifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CertificationUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Certifications",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Html" },
                    { 2, "C#" },
                    { 3, "JQ" },
                    { 4, "JS" },
                    { 5, "Core" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CirtficatNum", "Name" },
                values: new object[,]
                {
                    { 1, 8, "Malaak" },
                    { 2, 9, "Ahmed" },
                    { 3, 3, "Ali" },
                    { 4, 2, "Mazen" },
                    { 5, 12, "James" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CertificationUser_UsersId",
                table: "CertificationUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificationUser");

            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
