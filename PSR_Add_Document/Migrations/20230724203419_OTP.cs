using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSR_Add_Document.Migrations
{
    public partial class OTP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OTPManage_Customers_CustomerId",
                table: "OTPManage");

            migrationBuilder.DropIndex(
                name: "IX_OTPManage_CustomerId",
                table: "OTPManage");

            migrationBuilder.RenameColumn(
                name: "OtpTime",
                table: "OTPManage",
                newName: "OtpLastingTime");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "OTPManage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IPADDRESS",
                table: "OTPManage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "OtpCreateTime",
                table: "OTPManage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "OTPManage");

            migrationBuilder.DropColumn(
                name: "IPADDRESS",
                table: "OTPManage");

            migrationBuilder.DropColumn(
                name: "OtpCreateTime",
                table: "OTPManage");

            migrationBuilder.RenameColumn(
                name: "OtpLastingTime",
                table: "OTPManage",
                newName: "OtpTime");

            migrationBuilder.CreateIndex(
                name: "IX_OTPManage_CustomerId",
                table: "OTPManage",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_OTPManage_Customers_CustomerId",
                table: "OTPManage",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
