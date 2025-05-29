using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hospital_System.Migrations
{
    /// <inheritdoc />
    public partial class FixPaymentPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_doctors_DoctorId",
                schema: "public",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_hospitals_HospitalId",
                schema: "public",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_appointments_patients_PatientId",
                schema: "public",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_hospitals_HospitalId",
                schema: "public",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_doctors_users_Id",
                schema: "public",
                table: "doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_patients_hospitals_HospitalId",
                schema: "public",
                table: "patients");

            migrationBuilder.DropForeignKey(
                name: "FK_patients_users_Id",
                schema: "public",
                table: "patients");

            migrationBuilder.DropForeignKey(
                name: "FK_payments_patients_PatientId",
                schema: "public",
                table: "payments");

            migrationBuilder.DropForeignKey(
                name: "FK_users_roles_RoleId",
                schema: "public",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                schema: "public",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_roles",
                schema: "public",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_payments",
                schema: "public",
                table: "payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_patients",
                schema: "public",
                table: "patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_hospitals",
                schema: "public",
                table: "hospitals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_doctors",
                schema: "public",
                table: "doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_appointments",
                schema: "public",
                table: "appointments");

            migrationBuilder.RenameTable(
                name: "users",
                schema: "public",
                newName: "Users",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "roles",
                schema: "public",
                newName: "Roles",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "payments",
                schema: "public",
                newName: "Payments",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "patients",
                schema: "public",
                newName: "Patients",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "hospitals",
                schema: "public",
                newName: "Hospitals",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "doctors",
                schema: "public",
                newName: "Doctors",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "appointments",
                schema: "public",
                newName: "Appointments",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_users_RoleId",
                schema: "public",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.RenameColumn(
                name: "roleName",
                schema: "public",
                table: "Roles",
                newName: "RoleName");

            migrationBuilder.RenameIndex(
                name: "IX_payments_PatientId",
                schema: "public",
                table: "Payments",
                newName: "IX_Payments_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_patients_HospitalId",
                schema: "public",
                table: "Patients",
                newName: "IX_Patients_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_doctors_HospitalId",
                schema: "public",
                table: "Doctors",
                newName: "IX_Doctors_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_PatientId",
                schema: "public",
                table: "Appointments",
                newName: "IX_Appointments_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_HospitalId",
                schema: "public",
                table: "Appointments",
                newName: "IX_Appointments_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_appointments_DoctorId",
                schema: "public",
                table: "Appointments",
                newName: "IX_Appointments_DoctorId");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                schema: "public",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "public",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "public",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "public",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                schema: "public",
                table: "Roles",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "BillingId",
                schema: "public",
                table: "Payments",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                schema: "public",
                table: "Payments",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceInfo",
                schema: "public",
                table: "Patients",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "public",
                table: "Patients",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "public",
                table: "Hospitals",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "HospitalDescription",
                schema: "public",
                table: "Hospitals",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "public",
                table: "Hospitals",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                schema: "public",
                table: "Hospitals",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Specialization",
                schema: "public",
                table: "Doctors",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<List<int>>(
                name: "Schedules",
                schema: "public",
                table: "Doctors",
                type: "integer[]",
                nullable: true,
                oldClrType: typeof(int[]),
                oldType: "integer[]");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                schema: "public",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                schema: "public",
                table: "Roles",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                schema: "public",
                table: "Payments",
                column: "PaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                schema: "public",
                table: "Patients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hospitals",
                schema: "public",
                table: "Hospitals",
                column: "HospitalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                schema: "public",
                table: "Doctors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                schema: "public",
                table: "Appointments",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                schema: "public",
                table: "Appointments",
                column: "DoctorId",
                principalSchema: "public",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Hospitals_HospitalId",
                schema: "public",
                table: "Appointments",
                column: "HospitalId",
                principalSchema: "public",
                principalTable: "Hospitals",
                principalColumn: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                schema: "public",
                table: "Appointments",
                column: "PatientId",
                principalSchema: "public",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Hospitals_HospitalId",
                schema: "public",
                table: "Doctors",
                column: "HospitalId",
                principalSchema: "public",
                principalTable: "Hospitals",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Users_Id",
                schema: "public",
                table: "Doctors",
                column: "Id",
                principalSchema: "public",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Hospitals_HospitalId",
                schema: "public",
                table: "Patients",
                column: "HospitalId",
                principalSchema: "public",
                principalTable: "Hospitals",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Users_Id",
                schema: "public",
                table: "Patients",
                column: "Id",
                principalSchema: "public",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Patients_PatientId",
                schema: "public",
                table: "Payments",
                column: "PatientId",
                principalSchema: "public",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                schema: "public",
                table: "Users",
                column: "RoleId",
                principalSchema: "public",
                principalTable: "Roles",
                principalColumn: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                schema: "public",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Hospitals_HospitalId",
                schema: "public",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                schema: "public",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Hospitals_HospitalId",
                schema: "public",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Users_Id",
                schema: "public",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Hospitals_HospitalId",
                schema: "public",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Users_Id",
                schema: "public",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Patients_PatientId",
                schema: "public",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                schema: "public",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                schema: "public",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                schema: "public",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                schema: "public",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                schema: "public",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hospitals",
                schema: "public",
                table: "Hospitals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                schema: "public",
                table: "Doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                schema: "public",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                schema: "public",
                table: "Payments");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "public",
                newName: "users",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "public",
                newName: "roles",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Payments",
                schema: "public",
                newName: "payments",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Patients",
                schema: "public",
                newName: "patients",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Hospitals",
                schema: "public",
                newName: "hospitals",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Doctors",
                schema: "public",
                newName: "doctors",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Appointments",
                schema: "public",
                newName: "appointments",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                schema: "public",
                table: "users",
                newName: "IX_users_RoleId");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                schema: "public",
                table: "roles",
                newName: "roleName");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_PatientId",
                schema: "public",
                table: "payments",
                newName: "IX_payments_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_HospitalId",
                schema: "public",
                table: "patients",
                newName: "IX_patients_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_HospitalId",
                schema: "public",
                table: "doctors",
                newName: "IX_doctors_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_PatientId",
                schema: "public",
                table: "appointments",
                newName: "IX_appointments_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_HospitalId",
                schema: "public",
                table: "appointments",
                newName: "IX_appointments_HospitalId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_DoctorId",
                schema: "public",
                table: "appointments",
                newName: "IX_appointments_DoctorId");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                schema: "public",
                table: "users",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "public",
                table: "users",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "public",
                table: "users",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "public",
                table: "users",
                type: "character varying(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "roleName",
                schema: "public",
                table: "roles",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BillingId",
                schema: "public",
                table: "payments",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "InsuranceInfo",
                schema: "public",
                table: "patients",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                schema: "public",
                table: "patients",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "public",
                table: "hospitals",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HospitalDescription",
                schema: "public",
                table: "hospitals",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                schema: "public",
                table: "hospitals",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                schema: "public",
                table: "hospitals",
                type: "character varying(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Specialization",
                schema: "public",
                table: "doctors",
                type: "character varying(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int[]>(
                name: "Schedules",
                schema: "public",
                table: "doctors",
                type: "integer[]",
                nullable: false,
                defaultValue: new int[0],
                oldClrType: typeof(List<int>),
                oldType: "integer[]",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                schema: "public",
                table: "users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_roles",
                schema: "public",
                table: "roles",
                column: "RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_payments",
                schema: "public",
                table: "payments",
                column: "BillingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_patients",
                schema: "public",
                table: "patients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_hospitals",
                schema: "public",
                table: "hospitals",
                column: "HospitalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_doctors",
                schema: "public",
                table: "doctors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_appointments",
                schema: "public",
                table: "appointments",
                column: "AppointmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_doctors_DoctorId",
                schema: "public",
                table: "appointments",
                column: "DoctorId",
                principalSchema: "public",
                principalTable: "doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_hospitals_HospitalId",
                schema: "public",
                table: "appointments",
                column: "HospitalId",
                principalSchema: "public",
                principalTable: "hospitals",
                principalColumn: "HospitalId");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_patients_PatientId",
                schema: "public",
                table: "appointments",
                column: "PatientId",
                principalSchema: "public",
                principalTable: "patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_hospitals_HospitalId",
                schema: "public",
                table: "doctors",
                column: "HospitalId",
                principalSchema: "public",
                principalTable: "hospitals",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctors_users_Id",
                schema: "public",
                table: "doctors",
                column: "Id",
                principalSchema: "public",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patients_hospitals_HospitalId",
                schema: "public",
                table: "patients",
                column: "HospitalId",
                principalSchema: "public",
                principalTable: "hospitals",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_patients_users_Id",
                schema: "public",
                table: "patients",
                column: "Id",
                principalSchema: "public",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_payments_patients_PatientId",
                schema: "public",
                table: "payments",
                column: "PatientId",
                principalSchema: "public",
                principalTable: "patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_users_roles_RoleId",
                schema: "public",
                table: "users",
                column: "RoleId",
                principalSchema: "public",
                principalTable: "roles",
                principalColumn: "RoleId");
        }
    }
}
