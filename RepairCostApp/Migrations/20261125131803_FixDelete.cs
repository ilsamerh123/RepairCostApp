using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepairCostApp.Migrations
{
    /// <inheritdoc />
    public partial class FixDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estimates_Rooms_roomid",
                table: "Estimates");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairWorks_Contractors_contractorid",
                table: "RepairWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairWorks_CostArticles_costarticleid",
                table: "RepairWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairWorks_Rooms_roomid",
                table: "RepairWorks");

            migrationBuilder.AddForeignKey(
                name: "FK_Estimates_Rooms_roomid",
                table: "Estimates",
                column: "roomid",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairWorks_Contractors_contractorid",
                table: "RepairWorks",
                column: "contractorid",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairWorks_CostArticles_costarticleid",
                table: "RepairWorks",
                column: "costarticleid",
                principalTable: "CostArticles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairWorks_Rooms_roomid",
                table: "RepairWorks",
                column: "roomid",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estimates_Rooms_roomid",
                table: "Estimates");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairWorks_Contractors_contractorid",
                table: "RepairWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairWorks_CostArticles_costarticleid",
                table: "RepairWorks");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairWorks_Rooms_roomid",
                table: "RepairWorks");

            migrationBuilder.AddForeignKey(
                name: "FK_Estimates_Rooms_roomid",
                table: "Estimates",
                column: "roomid",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairWorks_Contractors_contractorid",
                table: "RepairWorks",
                column: "contractorid",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairWorks_CostArticles_costarticleid",
                table: "RepairWorks",
                column: "costarticleid",
                principalTable: "CostArticles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairWorks_Rooms_roomid",
                table: "RepairWorks",
                column: "roomid",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
