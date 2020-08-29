using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tirelire_Jamal.Migrations.TirelireDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresse",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdLivraison = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    AdFacturation = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresse", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Couleur",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Couleur", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fabricant",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricant", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Nom = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Prenom = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Date_Naissance = table.Column<DateTime>(type: "date", nullable: false),
                    Telephone = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Genre = table.Column<bool>(nullable: false),
                    IDAdresse = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Client_Adresse",
                        column: x => x.IDAdresse,
                        principalTable: "Adresse",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produit",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hauteur = table.Column<double>(nullable: false),
                    Largeur = table.Column<double>(nullable: false),
                    Longueur = table.Column<double>(nullable: false),
                    Poids = table.Column<double>(nullable: false),
                    Capacite = table.Column<int>(nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IDCouleur = table.Column<int>(nullable: false),
                    IDFabricant = table.Column<int>(nullable: false),
                    Prix = table.Column<double>(nullable: false),
                    Image = table.Column<string>(unicode: false, nullable: false),
                    Frais = table.Column<double>(nullable: false),
                    Disponible = table.Column<bool>(nullable: false),
                    Reference = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produit", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Produit_Couleur",
                        column: x => x.IDCouleur,
                        principalTable: "Couleur",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produit_Fabricant",
                        column: x => x.IDFabricant,
                        principalTable: "Fabricant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    IDClient = table.Column<int>(nullable: true),
                    Commentaire = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Commande_Client",
                        column: x => x.IDClient,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Avis",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDProduit = table.Column<int>(nullable: false),
                    IDClient = table.Column<int>(nullable: false),
                    Valide = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avis", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Avis_Client",
                        column: x => x.IDClient,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Avis_Produit",
                        column: x => x.IDProduit,
                        principalTable: "Produit",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetailCommande",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantite = table.Column<int>(nullable: false),
                    IDProduit = table.Column<int>(nullable: false),
                    IDCommande = table.Column<int>(nullable: true),
                    Prix = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailCommande", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DetailCommande_Commande",
                        column: x => x.IDCommande,
                        principalTable: "Commande",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailCommande_Produit",
                        column: x => x.IDProduit,
                        principalTable: "Produit",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avis_IDClient",
                table: "Avis",
                column: "IDClient");

            migrationBuilder.CreateIndex(
                name: "IX_Avis_IDProduit",
                table: "Avis",
                column: "IDProduit");

            migrationBuilder.CreateIndex(
                name: "IX_Client_IDAdresse",
                table: "Client",
                column: "IDAdresse");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_IDClient",
                table: "Commande",
                column: "IDClient");

            migrationBuilder.CreateIndex(
                name: "IX_DetailCommande_IDCommande",
                table: "DetailCommande",
                column: "IDCommande");

            migrationBuilder.CreateIndex(
                name: "IX_DetailCommande_IDProduit",
                table: "DetailCommande",
                column: "IDProduit");

            migrationBuilder.CreateIndex(
                name: "IX_Produit_IDCouleur",
                table: "Produit",
                column: "IDCouleur");

            migrationBuilder.CreateIndex(
                name: "IX_Produit_IDFabricant",
                table: "Produit",
                column: "IDFabricant");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avis");

            migrationBuilder.DropTable(
                name: "DetailCommande");

            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.DropTable(
                name: "Produit");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Couleur");

            migrationBuilder.DropTable(
                name: "Fabricant");

            migrationBuilder.DropTable(
                name: "Adresse");
        }
    }
}
