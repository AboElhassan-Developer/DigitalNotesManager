using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DigitalNotesManager.Migrations
{
    /// <inheritdoc />
    public partial class AddIsReminderDismissedToNotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReminderDismissed",
                table: "Notes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReminderDismissed",
                table: "Notes");
        }
    }
}
