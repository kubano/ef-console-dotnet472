using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 128, nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 128, nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    DeActivatedBy = table.Column<string>(maxLength: 128, nullable: true),
                    DeActivatedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(maxLength: 128, nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DisplayOrder = table.Column<short>(nullable: true),
                    Description = table.Column<string>(maxLength: 512, nullable: true),
                    FirstName = table.Column<string>(maxLength: 256, nullable: true),
                    LastName = table.Column<string>(maxLength: 128, nullable: true),
                    ProfilePhoto = table.Column<string>(maxLength: 512, nullable: true),
                    PersonType = table.Column<int>(maxLength: 48, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 128, nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 128, nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    DeActivatedBy = table.Column<string>(maxLength: 128, nullable: true),
                    DeActivatedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(maxLength: 128, nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DisplayOrder = table.Column<short>(nullable: true),
                    Description = table.Column<string>(maxLength: 512, nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    Address1 = table.Column<string>(maxLength: 512, nullable: false),
                    Address2 = table.Column<string>(maxLength: 128, nullable: true),
                    City = table.Column<string>(maxLength: 128, nullable: false),
                    ZipCode4 = table.Column<string>(maxLength: 5, nullable: true),
                    ZipCode5 = table.Column<string>(maxLength: 5, nullable: false),
                    State = table.Column<string>(nullable: true),
                    Coordinates = table.Column<string>(maxLength: 256, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    AddressType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailAddress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 128, nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 128, nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    DeActivatedBy = table.Column<string>(maxLength: 128, nullable: true),
                    DeActivatedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(maxLength: 128, nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DisplayOrder = table.Column<short>(nullable: true),
                    Description = table.Column<string>(maxLength: 512, nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(unicode: false, maxLength: 256, nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailAddress_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 128, nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 128, nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    DeActivatedBy = table.Column<string>(maxLength: 128, nullable: true),
                    DeActivatedOn = table.Column<DateTime>(nullable: true),
                    DeletedBy = table.Column<string>(maxLength: 128, nullable: true),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    DisplayOrder = table.Column<short>(nullable: true),
                    Description = table.Column<string>(maxLength: 512, nullable: true),
                    PersonId = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 128, nullable: false),
                    PhoneExtension = table.Column<string>(maxLength: 12, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    PhoneType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phone_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonId",
                table: "Address",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddress_PersonId",
                table: "EmailAddress",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_PersonId",
                table: "Phone",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "EmailAddress");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
