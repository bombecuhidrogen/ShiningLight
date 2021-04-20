using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShiningLight.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    UserID = table.Column<Guid>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    PaymentMethod = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Invoices_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    AppointmentID = table.Column<Guid>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClinicsServices",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ServicesID = table.Column<Guid>(nullable: false),
                    ClinicID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicsServices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClinicsServices_Clinics_ClinicID",
                        column: x => x.ClinicID,
                        principalTable: "Clinics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClinicsServices_Services_ServicesID",
                        column: x => x.ServicesID,
                        principalTable: "Services",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    ClinicID = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Qualification = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Doctors_Clinics_ClinicID",
                        column: x => x.ClinicID,
                        principalTable: "Clinics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    UserID = table.Column<Guid>(nullable: true),
                    DoctorsID = table.Column<Guid>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Prices = table.Column<decimal>(nullable: false),
                    ClinicID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Appointments_Clinics_ClinicID",
                        column: x => x.ClinicID,
                        principalTable: "Clinics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorsID",
                        column: x => x.DoctorsID,
                        principalTable: "Doctors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ClinicID",
                table: "Appointments",
                column: "ClinicID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorsID",
                table: "Appointments",
                column: "DoctorsID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserID",
                table: "Appointments",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Clinics_AppointmentID",
                table: "Clinics",
                column: "AppointmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicsServices_ClinicID",
                table: "ClinicsServices",
                column: "ClinicID");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicsServices_ServicesID",
                table: "ClinicsServices",
                column: "ServicesID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_ClinicID",
                table: "Doctors",
                column: "ClinicID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_UserID",
                table: "Invoices",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clinics_Appointments_AppointmentID",
                table: "Clinics",
                column: "AppointmentID",
                principalTable: "Appointments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Clinics_ClinicID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Clinics_ClinicID",
                table: "Doctors");

            migrationBuilder.DropTable(
                name: "ClinicsServices");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
