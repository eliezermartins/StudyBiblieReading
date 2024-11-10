using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudyBibleReading.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Migrate_10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Key = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReadingPlan",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Tradition = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingPlan", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Acronym = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Tradition = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReadingPlanDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    ReadingPlanId = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    IsRead = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingPlanDay", x => new { x.Id, x.ReadingPlanId });
                    table.ForeignKey(
                        name: "FK_ReadingPlanDay_ReadingPlan_ReadingPlanId",
                        column: x => x.ReadingPlanId,
                        principalTable: "ReadingPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bibles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    PublisherId = table.Column<string>(type: "TEXT", nullable: false),
                    TranslationId = table.Column<string>(type: "TEXT", nullable: false),
                    Pages = table.Column<int>(type: "INTEGER", nullable: false),
                    Study = table.Column<bool>(type: "INTEGER", nullable: false),
                    ReadingQuantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bibles_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bibles_Translations_TranslationId",
                        column: x => x.TranslationId,
                        principalTable: "Translations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    BibleId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Classification = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    SequenceInTheBible = table.Column<int>(type: "INTEGER", nullable: false),
                    IsRead = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => new { x.Id, x.BibleId });
                    table.ForeignKey(
                        name: "FK_Articles_Bibles_BibleId",
                        column: x => x.BibleId,
                        principalTable: "Bibles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    BibleId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true),
                    Testament = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Classification = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    SequenceInTheBible = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => new { x.Id, x.BibleId });
                    table.ForeignKey(
                        name: "FK_Books_Bibles_BibleId",
                        column: x => x.BibleId,
                        principalTable: "Bibles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Readings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Completed = table.Column<bool>(type: "INTEGER", nullable: false),
                    ReadingType = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    BibleId = table.Column<string>(type: "TEXT", nullable: true),
                    ReadingPlanId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Readings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Readings_Bibles_BibleId",
                        column: x => x.BibleId,
                        principalTable: "Bibles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Readings_ReadingPlan_ReadingPlanId",
                        column: x => x.ReadingPlanId,
                        principalTable: "ReadingPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    BookId = table.Column<string>(type: "TEXT", nullable: false),
                    BibleId = table.Column<string>(type: "TEXT", nullable: false),
                    IsRead = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => new { x.Id, x.BookId, x.BibleId });
                    table.ForeignKey(
                        name: "FK_Chapters_Bibles_BibleId",
                        column: x => x.BibleId,
                        principalTable: "Bibles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chapters_Books_BookId_BibleId",
                        columns: x => new { x.BookId, x.BibleId },
                        principalTable: "Books",
                        principalColumns: new[] { "Id", "BibleId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReadingsBooks",
                columns: table => new
                {
                    PartialReadingId = table.Column<string>(type: "TEXT", nullable: false),
                    BookId = table.Column<string>(type: "TEXT", nullable: false),
                    BibleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadingsBooks", x => new { x.PartialReadingId, x.BookId, x.BibleId });
                    table.ForeignKey(
                        name: "FK_ReadingsBooks_Books_BookId_BibleId",
                        columns: x => new { x.BookId, x.BibleId },
                        principalTable: "Books",
                        principalColumns: new[] { "Id", "BibleId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReadingsBooks_Readings_PartialReadingId",
                        column: x => x.PartialReadingId,
                        principalTable: "Readings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_BibleId",
                table: "Articles",
                column: "BibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Bibles_PublisherId",
                table: "Bibles",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Bibles_TranslationId",
                table: "Bibles",
                column: "TranslationId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BibleId",
                table: "Books",
                column: "BibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Name",
                table: "Books",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_BibleId",
                table: "Chapters",
                column: "BibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_BookId_BibleId",
                table: "Chapters",
                columns: new[] { "BookId", "BibleId" });

            migrationBuilder.CreateIndex(
                name: "IX_ReadingPlanDay_ReadingPlanId",
                table: "ReadingPlanDay",
                column: "ReadingPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Readings_BibleId",
                table: "Readings",
                column: "BibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Readings_ReadingPlanId",
                table: "Readings",
                column: "ReadingPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadingsBooks_BookId_BibleId",
                table: "ReadingsBooks",
                columns: new[] { "BookId", "BibleId" });

            migrationBuilder.CreateIndex(
                name: "IX_Translations_Acronym",
                table: "Translations",
                column: "Acronym",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationSettings");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "ReadingPlanDay");

            migrationBuilder.DropTable(
                name: "ReadingsBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Readings");

            migrationBuilder.DropTable(
                name: "Bibles");

            migrationBuilder.DropTable(
                name: "ReadingPlan");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Translations");
        }
    }
}
