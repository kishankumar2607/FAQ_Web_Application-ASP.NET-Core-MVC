using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KishanKumarDas_Assignment2.Migrations
{
    /// <inheritdoc />
    public partial class AddedAnotherFaq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "FaqId", "Answer", "CategoryId", "Question", "TopicId" },
                values: new object[] { 6, "In 1995", "history", "When was JavaScript first released?", "javascript" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faqs",
                keyColumn: "FaqId",
                keyValue: 6);
        }
    }
}
