using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepairCostApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstimateItems_Estimates_EstimateId",
                table: "EstimateItems");

            migrationBuilder.DropColumn(
                name: "WorkName",
                table: "EstimateItems");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Rooms",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Rooms",
                newName: "area");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Rooms",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "RepairWorks",
                newName: "roomid");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "RepairWorks",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "RepairWorks",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "RepairWorks",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "CostArticleId",
                table: "RepairWorks",
                newName: "costarticleid");

            migrationBuilder.RenameColumn(
                name: "ContractorId",
                table: "RepairWorks",
                newName: "contractorid");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "RepairWorks",
                newName: "category");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Estimates",
                newName: "totalamount");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Estimates",
                newName: "roomid");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Estimates",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "RepairWorkId",
                table: "EstimateItems",
                newName: "repairworkid");

            migrationBuilder.RenameColumn(
                name: "EstimateId",
                table: "EstimateItems",
                newName: "estimateid");

            migrationBuilder.RenameIndex(
                name: "IX_EstimateItems_EstimateId",
                table: "EstimateItems",
                newName: "IX_EstimateItems_estimateid");

            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "CostArticles",
                newName: "unit");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "CostArticles",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Contractors",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contractors",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "INN",
                table: "Contractors",
                newName: "inn");

            migrationBuilder.CreateIndex(
                name: "IX_RepairWorks_contractorid",
                table: "RepairWorks",
                column: "contractorid");

            migrationBuilder.CreateIndex(
                name: "IX_RepairWorks_costarticleid",
                table: "RepairWorks",
                column: "costarticleid");

            migrationBuilder.CreateIndex(
                name: "IX_RepairWorks_roomid",
                table: "RepairWorks",
                column: "roomid");

            migrationBuilder.CreateIndex(
                name: "IX_Estimates_roomid",
                table: "Estimates",
                column: "roomid");

            migrationBuilder.AddForeignKey(
                name: "FK_EstimateItems_Estimates_estimateid",
                table: "EstimateItems",
                column: "estimateid",
                principalTable: "Estimates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstimateItems_Estimates_estimateid",
                table: "EstimateItems");

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

            migrationBuilder.DropIndex(
                name: "IX_RepairWorks_contractorid",
                table: "RepairWorks");

            migrationBuilder.DropIndex(
                name: "IX_RepairWorks_costarticleid",
                table: "RepairWorks");

            migrationBuilder.DropIndex(
                name: "IX_RepairWorks_roomid",
                table: "RepairWorks");

            migrationBuilder.DropIndex(
                name: "IX_Estimates_roomid",
                table: "Estimates");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Rooms",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "area",
                table: "Rooms",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Rooms",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "roomid",
                table: "RepairWorks",
                newName: "RoomId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "RepairWorks",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "RepairWorks",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "RepairWorks",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "costarticleid",
                table: "RepairWorks",
                newName: "CostArticleId");

            migrationBuilder.RenameColumn(
                name: "contractorid",
                table: "RepairWorks",
                newName: "ContractorId");

            migrationBuilder.RenameColumn(
                name: "category",
                table: "RepairWorks",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "totalamount",
                table: "Estimates",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "roomid",
                table: "Estimates",
                newName: "RoomId");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Estimates",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "repairworkid",
                table: "EstimateItems",
                newName: "RepairWorkId");

            migrationBuilder.RenameColumn(
                name: "estimateid",
                table: "EstimateItems",
                newName: "EstimateId");

            migrationBuilder.RenameIndex(
                name: "IX_EstimateItems_estimateid",
                table: "EstimateItems",
                newName: "IX_EstimateItems_EstimateId");

            migrationBuilder.RenameColumn(
                name: "unit",
                table: "CostArticles",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "CostArticles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "Contractors",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Contractors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "inn",
                table: "Contractors",
                newName: "INN");

            migrationBuilder.AddColumn<string>(
                name: "WorkName",
                table: "EstimateItems",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_EstimateItems_Estimates_EstimateId",
                table: "EstimateItems",
                column: "EstimateId",
                principalTable: "Estimates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
