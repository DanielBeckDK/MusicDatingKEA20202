﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicDating.Migrations
{
    public partial class X : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GenreName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    InstrumentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.InstrumentId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ensembles",
                columns: table => new
                {
                    EnsembleId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EnsembleName = table.Column<string>(nullable: true),
                    EnsembleDescription = table.Column<string>(nullable: true),
                    Id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ensembles", x => x.EnsembleId);
                    table.ForeignKey(
                        name: "FK_Ensembles_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agent",
                columns: table => new
                {
                    AgentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Level = table.Column<int>(nullable: false),
                    InstrumentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agent", x => x.AgentId);
                    table.ForeignKey(
                        name: "FK_Agent_Instruments_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instruments",
                        principalColumn: "InstrumentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInstrument",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    InstrumentId = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInstrument", x => new { x.Id, x.InstrumentId });
                    table.ForeignKey(
                        name: "FK_UserInstrument_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInstrument_Instruments_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instruments",
                        principalColumn: "InstrumentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreEnsemble",
                columns: table => new
                {
                    EnsembleId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreEnsemble", x => new { x.GenreId, x.EnsembleId });
                    table.ForeignKey(
                        name: "FK_GenreEnsemble_Ensembles_EnsembleId",
                        column: x => x.EnsembleId,
                        principalTable: "Ensembles",
                        principalColumn: "EnsembleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreEnsemble_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEnsemble",
                columns: table => new
                {
                    EnsembleId = table.Column<int>(nullable: false),
                    Id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEnsemble", x => new { x.Id, x.EnsembleId });
                    table.ForeignKey(
                        name: "FK_UserEnsemble_Ensembles_EnsembleId",
                        column: x => x.EnsembleId,
                        principalTable: "Ensembles",
                        principalColumn: "EnsembleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEnsemble_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInstrumentGenre",
                columns: table => new
                {
                    UserInstrumentGenreId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Id = table.Column<string>(nullable: false),
                    InstrumentId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInstrumentGenre", x => x.UserInstrumentGenreId);
                    table.ForeignKey(
                        name: "FK_UserInstrumentGenre_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInstrumentGenre_UserInstrument_Id_InstrumentId",
                        columns: x => new { x.Id, x.InstrumentId },
                        principalTable: "UserInstrument",
                        principalColumns: new[] { "Id", "InstrumentId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "4d59b7fb-3f9f-472d-b6c0-717778fad328", "soren.remboll@gmail.com", true, "Søren", "Rembøll", false, null, "SOREN.REMBOLL@GMAIL.COM", "SOREN.REMBOLL@GMAIL.COM", "AQAAAAEAACcQAAAAEAQRMwd9Rvjy74ilAtjF7BtFZTdAkgEH8kUpbd+i7b7R1pzbG3Tp/s2pHrhdMOiQxQ==", null, false, "B2S2KXH5MOD6SXMBIAKCLQBQE7DBJLWY", false, "soren.remboll@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2", 0, "31a9a4be-f66b-4e4f-be8a-8a2b685478d9", null, false, "Daniel", "Beck", false, null, null, null, null, null, false, "5b1243f3-1494-4cc8-96a5-f07ddf5bf889", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3", 0, "8ded9258-4bef-4e70-bf7e-81984917d204", null, false, "Christian", "1", false, null, null, null, null, null, false, "c36601ba-d0bc-432c-be46-9640c56fc740", false, null });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[] { 1, "Metal" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[] { 2, "Rock" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[] { 3, "Classical" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[] { 4, "Pop" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[] { 5, "Funk" });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "InstrumentId", "Name" },
                values: new object[] { 1, "Trumpet" });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "InstrumentId", "Name" },
                values: new object[] { 2, "Piano" });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "InstrumentId", "Name" },
                values: new object[] { 3, "Saxophone" });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "InstrumentId", "Name" },
                values: new object[] { 4, "Drums" });

            migrationBuilder.InsertData(
                table: "Instruments",
                columns: new[] { "InstrumentId", "Name" },
                values: new object[] { 5, "Bass" });

            migrationBuilder.InsertData(
                table: "Ensembles",
                columns: new[] { "EnsembleId", "EnsembleDescription", "EnsembleName", "Id" },
                values: new object[] { 1, " Vi er TV2 og vi laver dårlig musik", "TV2", "1" });

            migrationBuilder.InsertData(
                table: "Ensembles",
                columns: new[] { "EnsembleId", "EnsembleDescription", "EnsembleName", "Id" },
                values: new object[] { 2, "Vi er DR1 og vi æder licens penge til frokost", "DR1", "1" });

            migrationBuilder.InsertData(
                table: "UserInstrument",
                columns: new[] { "Id", "InstrumentId", "Level" },
                values: new object[] { "3", 1, 1 });

            migrationBuilder.InsertData(
                table: "UserInstrument",
                columns: new[] { "Id", "InstrumentId", "Level" },
                values: new object[] { "2", 1, 1 });

            migrationBuilder.InsertData(
                table: "UserInstrument",
                columns: new[] { "Id", "InstrumentId", "Level" },
                values: new object[] { "1", 2, 5 });

            migrationBuilder.InsertData(
                table: "UserInstrument",
                columns: new[] { "Id", "InstrumentId", "Level" },
                values: new object[] { "2", 2, 3 });

            migrationBuilder.InsertData(
                table: "UserInstrument",
                columns: new[] { "Id", "InstrumentId", "Level" },
                values: new object[] { "1", 3, 5 });

            migrationBuilder.InsertData(
                table: "UserInstrument",
                columns: new[] { "Id", "InstrumentId", "Level" },
                values: new object[] { "3", 4, 1 });

            migrationBuilder.InsertData(
                table: "GenreEnsemble",
                columns: new[] { "GenreId", "EnsembleId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "GenreEnsemble",
                columns: new[] { "GenreId", "EnsembleId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "UserEnsemble",
                columns: new[] { "Id", "EnsembleId" },
                values: new object[] { "1", 1 });

            migrationBuilder.InsertData(
                table: "UserEnsemble",
                columns: new[] { "Id", "EnsembleId" },
                values: new object[] { "2", 2 });

            migrationBuilder.InsertData(
                table: "UserInstrumentGenre",
                columns: new[] { "UserInstrumentGenreId", "GenreId", "Id", "InstrumentId" },
                values: new object[] { 3, 5, "3", 1 });

            migrationBuilder.InsertData(
                table: "UserInstrumentGenre",
                columns: new[] { "UserInstrumentGenreId", "GenreId", "Id", "InstrumentId" },
                values: new object[] { 5, 1, "2", 1 });

            migrationBuilder.InsertData(
                table: "UserInstrumentGenre",
                columns: new[] { "UserInstrumentGenreId", "GenreId", "Id", "InstrumentId" },
                values: new object[] { 1, 2, "1", 2 });

            migrationBuilder.InsertData(
                table: "UserInstrumentGenre",
                columns: new[] { "UserInstrumentGenreId", "GenreId", "Id", "InstrumentId" },
                values: new object[] { 6, 4, "1", 2 });

            migrationBuilder.InsertData(
                table: "UserInstrumentGenre",
                columns: new[] { "UserInstrumentGenreId", "GenreId", "Id", "InstrumentId" },
                values: new object[] { 2, 2, "2", 2 });

            migrationBuilder.InsertData(
                table: "UserInstrumentGenre",
                columns: new[] { "UserInstrumentGenreId", "GenreId", "Id", "InstrumentId" },
                values: new object[] { 7, 1, "1", 3 });

            migrationBuilder.InsertData(
                table: "UserInstrumentGenre",
                columns: new[] { "UserInstrumentGenreId", "GenreId", "Id", "InstrumentId" },
                values: new object[] { 8, 5, "1", 3 });

            migrationBuilder.InsertData(
                table: "UserInstrumentGenre",
                columns: new[] { "UserInstrumentGenreId", "GenreId", "Id", "InstrumentId" },
                values: new object[] { 4, 5, "3", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Agent_InstrumentId",
                table: "Agent",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ensembles_EnsembleName",
                table: "Ensembles",
                column: "EnsembleName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ensembles_Id",
                table: "Ensembles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_GenreEnsemble_EnsembleId",
                table: "GenreEnsemble",
                column: "EnsembleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEnsemble_EnsembleId",
                table: "UserEnsemble",
                column: "EnsembleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInstrument_InstrumentId",
                table: "UserInstrument",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInstrumentGenre_GenreId",
                table: "UserInstrumentGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInstrumentGenre_Id_InstrumentId",
                table: "UserInstrumentGenre",
                columns: new[] { "Id", "InstrumentId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agent");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GenreEnsemble");

            migrationBuilder.DropTable(
                name: "UserEnsemble");

            migrationBuilder.DropTable(
                name: "UserInstrumentGenre");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Ensembles");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "UserInstrument");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Instruments");
        }
    }
}
