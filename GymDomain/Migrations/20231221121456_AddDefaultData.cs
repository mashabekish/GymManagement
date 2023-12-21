using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymDomain.Migrations
{
    public partial class AddDefaultData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Birthday", "Email", "FirstName", "IdCardNumber", "IsDeleted", "LastName", "RegistrationDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 21, 15, 14, 56, 440, DateTimeKind.Local).AddTicks(9790), "Maksim.Silkou@gmail.com", "Maksim", new Guid("99557fa3-8f2b-4cad-bcf3-ae9498a7a610"), false, "Silkou", new DateTime(2023, 12, 21, 15, 14, 56, 440, DateTimeKind.Local).AddTicks(9866) },
                    { 2, new DateTime(2023, 12, 21, 15, 14, 56, 440, DateTimeKind.Local).AddTicks(9869), "Maria.Bekish@gmail.com", "Maria", new Guid("13224b7c-8bb8-4653-bfb7-61b044c726e8"), false, "Bekish", new DateTime(2023, 12, 21, 15, 14, 56, 440, DateTimeKind.Local).AddTicks(9871) },
                    { 3, new DateTime(2023, 12, 21, 15, 14, 56, 440, DateTimeKind.Local).AddTicks(9872), "Alex.Khartaniuk@gmail.com", "Alex", new Guid("f655bc85-bedc-4252-8eaa-6abec46a0582"), false, "Khartaniuk", new DateTime(2023, 12, 21, 15, 14, 56, 440, DateTimeKind.Local).AddTicks(9873) }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "Code", "Desrciption", "IsDeleted", "NumberOfMonths", "TotalNumberOfSessions", "TotalPrice", "WeekFrequency" },
                values: new object[,]
                {
                    { 1, new Guid("aad4f864-0745-4d65-a27b-1f94def20691"), "Desrciption", false, 12, 8, 100, 0 },
                    { 2, new Guid("2b1734c3-d6a8-455d-833c-0635851a0169"), "Desrciption", false, 11, 12, 140, 1 },
                    { 3, new Guid("d47e4210-be82-48fd-9e7e-e6103f25946e"), "Desrciption", false, 10, 16, 180, 2 }
                });

            migrationBuilder.InsertData(
                table: "MemberSubscriptions",
                columns: new[] { "Id", "DiscountValue", "EndDate", "IsDeleted", "MemberId", "OriginalPrice", "PaidPrice", "RemainingSessions", "StartDate", "SubscriptionId" },
                values: new object[] { 1, 0, new DateTime(2024, 1, 20, 15, 14, 56, 440, DateTimeKind.Local).AddTicks(9974), false, 1, 100, 100, 8, new DateTime(2023, 12, 21, 15, 14, 56, 440, DateTimeKind.Local).AddTicks(9973), 1 });

            migrationBuilder.InsertData(
                table: "MemberSubscriptions",
                columns: new[] { "Id", "DiscountValue", "EndDate", "IsDeleted", "MemberId", "OriginalPrice", "PaidPrice", "RemainingSessions", "StartDate", "SubscriptionId" },
                values: new object[] { 2, 0, new DateTime(2024, 1, 20, 15, 14, 56, 440, DateTimeKind.Local).AddTicks(9979), false, 2, 140, 140, 12, new DateTime(2023, 12, 21, 15, 14, 56, 440, DateTimeKind.Local).AddTicks(9979), 2 });

            migrationBuilder.InsertData(
                table: "MemberSubscriptions",
                columns: new[] { "Id", "DiscountValue", "EndDate", "IsDeleted", "MemberId", "OriginalPrice", "PaidPrice", "RemainingSessions", "StartDate", "SubscriptionId" },
                values: new object[] { 3, 0, new DateTime(2024, 1, 20, 15, 14, 56, 440, DateTimeKind.Local).AddTicks(9981), false, 3, 180, 180, 16, new DateTime(2023, 12, 21, 15, 14, 56, 440, DateTimeKind.Local).AddTicks(9980), 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MemberSubscriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MemberSubscriptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MemberSubscriptions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
