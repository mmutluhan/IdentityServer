using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace IdentityServer.Migrations.ConfigurationDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                "merada_auth_db");

            migrationBuilder.CreateTable(
                "ApiResources",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Enabled = table.Column<bool>("boolean", nullable: false),
                    Name = table.Column<string>("character varying(200)", maxLength: 200, nullable: false),
                    DisplayName = table.Column<string>("character varying(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>("character varying(1000)", maxLength: 1000, nullable: true),
                    AllowedAccessTokenSigningAlgorithms =
                        table.Column<string>("character varying(100)", maxLength: 100, nullable: true),
                    ShowInDiscoveryDocument = table.Column<bool>("boolean", nullable: false),
                    Created = table.Column<DateTime>("timestamp without time zone", nullable: false),
                    Updated = table.Column<DateTime>("timestamp without time zone", nullable: true),
                    LastAccessed = table.Column<DateTime>("timestamp without time zone", nullable: true),
                    NonEditable = table.Column<bool>("boolean", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_ApiResources", x => x.Id); });

            migrationBuilder.CreateTable(
                "ApiScopes",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Enabled = table.Column<bool>("boolean", nullable: false),
                    Name = table.Column<string>("character varying(200)", maxLength: 200, nullable: false),
                    DisplayName = table.Column<string>("character varying(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>("character varying(1000)", maxLength: 1000, nullable: true),
                    Required = table.Column<bool>("boolean", nullable: false),
                    Emphasize = table.Column<bool>("boolean", nullable: false),
                    ShowInDiscoveryDocument = table.Column<bool>("boolean", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_ApiScopes", x => x.Id); });

            migrationBuilder.CreateTable(
                "Clients",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Enabled = table.Column<bool>("boolean", nullable: false),
                    ClientId = table.Column<string>("character varying(200)", maxLength: 200, nullable: false),
                    ProtocolType = table.Column<string>("character varying(200)", maxLength: 200, nullable: false),
                    RequireClientSecret = table.Column<bool>("boolean", nullable: false),
                    ClientName = table.Column<string>("character varying(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>("character varying(1000)", maxLength: 1000, nullable: true),
                    ClientUri = table.Column<string>("character varying(2000)", maxLength: 2000, nullable: true),
                    LogoUri = table.Column<string>("character varying(2000)", maxLength: 2000, nullable: true),
                    RequireConsent = table.Column<bool>("boolean", nullable: false),
                    AllowRememberConsent = table.Column<bool>("boolean", nullable: false),
                    AlwaysIncludeUserClaimsInIdToken = table.Column<bool>("boolean", nullable: false),
                    RequirePkce = table.Column<bool>("boolean", nullable: false),
                    AllowPlainTextPkce = table.Column<bool>("boolean", nullable: false),
                    RequireRequestObject = table.Column<bool>("boolean", nullable: false),
                    AllowAccessTokensViaBrowser = table.Column<bool>("boolean", nullable: false),
                    FrontChannelLogoutUri =
                        table.Column<string>("character varying(2000)", maxLength: 2000, nullable: true),
                    FrontChannelLogoutSessionRequired = table.Column<bool>("boolean", nullable: false),
                    BackChannelLogoutUri =
                        table.Column<string>("character varying(2000)", maxLength: 2000, nullable: true),
                    BackChannelLogoutSessionRequired = table.Column<bool>("boolean", nullable: false),
                    AllowOfflineAccess = table.Column<bool>("boolean", nullable: false),
                    IdentityTokenLifetime = table.Column<int>("integer", nullable: false),
                    AllowedIdentityTokenSigningAlgorithms =
                        table.Column<string>("character varying(100)", maxLength: 100, nullable: true),
                    AccessTokenLifetime = table.Column<int>("integer", nullable: false),
                    AuthorizationCodeLifetime = table.Column<int>("integer", nullable: false),
                    ConsentLifetime = table.Column<int>("integer", nullable: true),
                    AbsoluteRefreshTokenLifetime = table.Column<int>("integer", nullable: false),
                    SlidingRefreshTokenLifetime = table.Column<int>("integer", nullable: false),
                    RefreshTokenUsage = table.Column<int>("integer", nullable: false),
                    UpdateAccessTokenClaimsOnRefresh = table.Column<bool>("boolean", nullable: false),
                    RefreshTokenExpiration = table.Column<int>("integer", nullable: false),
                    AccessTokenType = table.Column<int>("integer", nullable: false),
                    EnableLocalLogin = table.Column<bool>("boolean", nullable: false),
                    IncludeJwtId = table.Column<bool>("boolean", nullable: false),
                    AlwaysSendClientClaims = table.Column<bool>("boolean", nullable: false),
                    ClientClaimsPrefix = table.Column<string>("character varying(200)", maxLength: 200, nullable: true),
                    PairWiseSubjectSalt =
                        table.Column<string>("character varying(200)", maxLength: 200, nullable: true),
                    Created = table.Column<DateTime>("timestamp without time zone", nullable: false),
                    Updated = table.Column<DateTime>("timestamp without time zone", nullable: true),
                    LastAccessed = table.Column<DateTime>("timestamp without time zone", nullable: true),
                    UserSsoLifetime = table.Column<int>("integer", nullable: true),
                    UserCodeType = table.Column<string>("character varying(100)", maxLength: 100, nullable: true),
                    DeviceCodeLifetime = table.Column<int>("integer", nullable: false),
                    NonEditable = table.Column<bool>("boolean", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Clients", x => x.Id); });

            migrationBuilder.CreateTable(
                "IdentityResources",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Enabled = table.Column<bool>("boolean", nullable: false),
                    Name = table.Column<string>("character varying(200)", maxLength: 200, nullable: false),
                    DisplayName = table.Column<string>("character varying(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>("character varying(1000)", maxLength: 1000, nullable: true),
                    Required = table.Column<bool>("boolean", nullable: false),
                    Emphasize = table.Column<bool>("boolean", nullable: false),
                    ShowInDiscoveryDocument = table.Column<bool>("boolean", nullable: false),
                    Created = table.Column<DateTime>("timestamp without time zone", nullable: false),
                    Updated = table.Column<DateTime>("timestamp without time zone", nullable: true),
                    NonEditable = table.Column<bool>("boolean", nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_IdentityResources", x => x.Id); });

            migrationBuilder.CreateTable(
                "ApiResourceClaims",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApiResourceId = table.Column<int>("integer", nullable: false),
                    Type = table.Column<string>("character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiResourceClaims", x => x.Id);
                    table.ForeignKey(
                        "FK_ApiResourceClaims_ApiResources_ApiResourceId",
                        x => x.ApiResourceId,
                        principalSchema: "merada_auth_db",
                        principalTable: "ApiResources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ApiResourceProperties",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApiResourceId = table.Column<int>("integer", nullable: false),
                    Key = table.Column<string>("character varying(250)", maxLength: 250, nullable: false),
                    Value = table.Column<string>("character varying(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiResourceProperties", x => x.Id);
                    table.ForeignKey(
                        "FK_ApiResourceProperties_ApiResources_ApiResourceId",
                        x => x.ApiResourceId,
                        principalSchema: "merada_auth_db",
                        principalTable: "ApiResources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ApiResourceScopes",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Scope = table.Column<string>("character varying(200)", maxLength: 200, nullable: false),
                    ApiResourceId = table.Column<int>("integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiResourceScopes", x => x.Id);
                    table.ForeignKey(
                        "FK_ApiResourceScopes_ApiResources_ApiResourceId",
                        x => x.ApiResourceId,
                        principalSchema: "merada_auth_db",
                        principalTable: "ApiResources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ApiResourceSecrets",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApiResourceId = table.Column<int>("integer", nullable: false),
                    Description = table.Column<string>("character varying(1000)", maxLength: 1000, nullable: true),
                    Value = table.Column<string>("character varying(4000)", maxLength: 4000, nullable: false),
                    Expiration = table.Column<DateTime>("timestamp without time zone", nullable: true),
                    Type = table.Column<string>("character varying(250)", maxLength: 250, nullable: false),
                    Created = table.Column<DateTime>("timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiResourceSecrets", x => x.Id);
                    table.ForeignKey(
                        "FK_ApiResourceSecrets_ApiResources_ApiResourceId",
                        x => x.ApiResourceId,
                        principalSchema: "merada_auth_db",
                        principalTable: "ApiResources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ApiScopeClaims",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScopeId = table.Column<int>("integer", nullable: false),
                    Type = table.Column<string>("character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiScopeClaims", x => x.Id);
                    table.ForeignKey(
                        "FK_ApiScopeClaims_ApiScopes_ScopeId",
                        x => x.ScopeId,
                        principalSchema: "merada_auth_db",
                        principalTable: "ApiScopes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ApiScopeProperties",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScopeId = table.Column<int>("integer", nullable: false),
                    Key = table.Column<string>("character varying(250)", maxLength: 250, nullable: false),
                    Value = table.Column<string>("character varying(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiScopeProperties", x => x.Id);
                    table.ForeignKey(
                        "FK_ApiScopeProperties_ApiScopes_ScopeId",
                        x => x.ScopeId,
                        principalSchema: "merada_auth_db",
                        principalTable: "ApiScopes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ClientClaims",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>("character varying(250)", maxLength: 250, nullable: false),
                    Value = table.Column<string>("character varying(250)", maxLength: 250, nullable: false),
                    ClientId = table.Column<int>("integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientClaims", x => x.Id);
                    table.ForeignKey(
                        "FK_ClientClaims_Clients_ClientId",
                        x => x.ClientId,
                        principalSchema: "merada_auth_db",
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ClientCorsOrigins",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Origin = table.Column<string>("character varying(150)", maxLength: 150, nullable: false),
                    ClientId = table.Column<int>("integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCorsOrigins", x => x.Id);
                    table.ForeignKey(
                        "FK_ClientCorsOrigins_Clients_ClientId",
                        x => x.ClientId,
                        principalSchema: "merada_auth_db",
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ClientGrantTypes",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GrantType = table.Column<string>("character varying(250)", maxLength: 250, nullable: false),
                    ClientId = table.Column<int>("integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientGrantTypes", x => x.Id);
                    table.ForeignKey(
                        "FK_ClientGrantTypes_Clients_ClientId",
                        x => x.ClientId,
                        principalSchema: "merada_auth_db",
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ClientIdPRestrictions",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Provider = table.Column<string>("character varying(200)", maxLength: 200, nullable: false),
                    ClientId = table.Column<int>("integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientIdPRestrictions", x => x.Id);
                    table.ForeignKey(
                        "FK_ClientIdPRestrictions_Clients_ClientId",
                        x => x.ClientId,
                        principalSchema: "merada_auth_db",
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ClientPostLogoutRedirectUris",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostLogoutRedirectUri =
                        table.Column<string>("character varying(2000)", maxLength: 2000, nullable: false),
                    ClientId = table.Column<int>("integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientPostLogoutRedirectUris", x => x.Id);
                    table.ForeignKey(
                        "FK_ClientPostLogoutRedirectUris_Clients_ClientId",
                        x => x.ClientId,
                        principalSchema: "merada_auth_db",
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ClientProperties",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<int>("integer", nullable: false),
                    Key = table.Column<string>("character varying(250)", maxLength: 250, nullable: false),
                    Value = table.Column<string>("character varying(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientProperties", x => x.Id);
                    table.ForeignKey(
                        "FK_ClientProperties_Clients_ClientId",
                        x => x.ClientId,
                        principalSchema: "merada_auth_db",
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ClientRedirectUris",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RedirectUri = table.Column<string>("character varying(2000)", maxLength: 2000, nullable: false),
                    ClientId = table.Column<int>("integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientRedirectUris", x => x.Id);
                    table.ForeignKey(
                        "FK_ClientRedirectUris_Clients_ClientId",
                        x => x.ClientId,
                        principalSchema: "merada_auth_db",
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ClientScopes",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Scope = table.Column<string>("character varying(200)", maxLength: 200, nullable: false),
                    ClientId = table.Column<int>("integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientScopes", x => x.Id);
                    table.ForeignKey(
                        "FK_ClientScopes_Clients_ClientId",
                        x => x.ClientId,
                        principalSchema: "merada_auth_db",
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "ClientSecrets",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientId = table.Column<int>("integer", nullable: false),
                    Description = table.Column<string>("character varying(2000)", maxLength: 2000, nullable: true),
                    Value = table.Column<string>("character varying(4000)", maxLength: 4000, nullable: false),
                    Expiration = table.Column<DateTime>("timestamp without time zone", nullable: true),
                    Type = table.Column<string>("character varying(250)", maxLength: 250, nullable: false),
                    Created = table.Column<DateTime>("timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientSecrets", x => x.Id);
                    table.ForeignKey(
                        "FK_ClientSecrets_Clients_ClientId",
                        x => x.ClientId,
                        principalSchema: "merada_auth_db",
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "IdentityResourceClaims",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdentityResourceId = table.Column<int>("integer", nullable: false),
                    Type = table.Column<string>("character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityResourceClaims", x => x.Id);
                    table.ForeignKey(
                        "FK_IdentityResourceClaims_IdentityResources_IdentityResourceId",
                        x => x.IdentityResourceId,
                        principalSchema: "merada_auth_db",
                        principalTable: "IdentityResources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                "IdentityResourceProperties",
                schema: "merada_auth_db",
                columns: table => new
                {
                    Id = table.Column<int>("integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdentityResourceId = table.Column<int>("integer", nullable: false),
                    Key = table.Column<string>("character varying(250)", maxLength: 250, nullable: false),
                    Value = table.Column<string>("character varying(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityResourceProperties", x => x.Id);
                    table.ForeignKey(
                        "FK_IdentityResourceProperties_IdentityResources_IdentityResour~",
                        x => x.IdentityResourceId,
                        principalSchema: "merada_auth_db",
                        principalTable: "IdentityResources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                "IX_ApiResourceClaims_ApiResourceId",
                schema: "merada_auth_db",
                table: "ApiResourceClaims",
                column: "ApiResourceId");

            migrationBuilder.CreateIndex(
                "IX_ApiResourceProperties_ApiResourceId",
                schema: "merada_auth_db",
                table: "ApiResourceProperties",
                column: "ApiResourceId");

            migrationBuilder.CreateIndex(
                "IX_ApiResources_Name",
                schema: "merada_auth_db",
                table: "ApiResources",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_ApiResourceScopes_ApiResourceId",
                schema: "merada_auth_db",
                table: "ApiResourceScopes",
                column: "ApiResourceId");

            migrationBuilder.CreateIndex(
                "IX_ApiResourceSecrets_ApiResourceId",
                schema: "merada_auth_db",
                table: "ApiResourceSecrets",
                column: "ApiResourceId");

            migrationBuilder.CreateIndex(
                "IX_ApiScopeClaims_ScopeId",
                schema: "merada_auth_db",
                table: "ApiScopeClaims",
                column: "ScopeId");

            migrationBuilder.CreateIndex(
                "IX_ApiScopeProperties_ScopeId",
                schema: "merada_auth_db",
                table: "ApiScopeProperties",
                column: "ScopeId");

            migrationBuilder.CreateIndex(
                "IX_ApiScopes_Name",
                schema: "merada_auth_db",
                table: "ApiScopes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_ClientClaims_ClientId",
                schema: "merada_auth_db",
                table: "ClientClaims",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                "IX_ClientCorsOrigins_ClientId",
                schema: "merada_auth_db",
                table: "ClientCorsOrigins",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                "IX_ClientGrantTypes_ClientId",
                schema: "merada_auth_db",
                table: "ClientGrantTypes",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                "IX_ClientIdPRestrictions_ClientId",
                schema: "merada_auth_db",
                table: "ClientIdPRestrictions",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                "IX_ClientPostLogoutRedirectUris_ClientId",
                schema: "merada_auth_db",
                table: "ClientPostLogoutRedirectUris",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                "IX_ClientProperties_ClientId",
                schema: "merada_auth_db",
                table: "ClientProperties",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                "IX_ClientRedirectUris_ClientId",
                schema: "merada_auth_db",
                table: "ClientRedirectUris",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                "IX_Clients_ClientId",
                schema: "merada_auth_db",
                table: "Clients",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_ClientScopes_ClientId",
                schema: "merada_auth_db",
                table: "ClientScopes",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                "IX_ClientSecrets_ClientId",
                schema: "merada_auth_db",
                table: "ClientSecrets",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                "IX_IdentityResourceClaims_IdentityResourceId",
                schema: "merada_auth_db",
                table: "IdentityResourceClaims",
                column: "IdentityResourceId");

            migrationBuilder.CreateIndex(
                "IX_IdentityResourceProperties_IdentityResourceId",
                schema: "merada_auth_db",
                table: "IdentityResourceProperties",
                column: "IdentityResourceId");

            migrationBuilder.CreateIndex(
                "IX_IdentityResources_Name",
                schema: "merada_auth_db",
                table: "IdentityResources",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "ApiResourceClaims",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ApiResourceProperties",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ApiResourceScopes",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ApiResourceSecrets",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ApiScopeClaims",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ApiScopeProperties",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ClientClaims",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ClientCorsOrigins",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ClientGrantTypes",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ClientIdPRestrictions",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ClientPostLogoutRedirectUris",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ClientProperties",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ClientRedirectUris",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ClientScopes",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ClientSecrets",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "IdentityResourceClaims",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "IdentityResourceProperties",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ApiResources",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "ApiScopes",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "Clients",
                "merada_auth_db");

            migrationBuilder.DropTable(
                "IdentityResources",
                "merada_auth_db");
        }
    }
}