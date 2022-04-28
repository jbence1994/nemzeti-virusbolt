using Microsoft.EntityFrameworkCore.Migrations;

namespace NemzetiVirusbolt.Api.Persistence.Migrations
{
    public partial class SeedTablesWithTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Siemens');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Maszk Rt.');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Aurelia Gloves');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Profissimo');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Ansell');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Air Safety');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('CERVA');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Clean Space');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Szabó Malom');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Naturworld');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Dr. Oetker');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('BradoLine');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Aura_Antibacterial');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Clearsept');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Zewa');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Perfex');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Ooops!');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Medirex');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Celitron Medical');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('Haas');");
            migrationBuilder.Sql("INSERT INTO merchants (name) VALUES('FlóraVita');");

            migrationBuilder.Sql(
                "INSERT INTO products (name, price, unit, description, available_quantity, merchant_id) VALUES ('Lélegeztetőgép', 1000000, 'darab', '', 100, (SELECT id from merchants WHERE name = 'Siemens'));"
            );
            migrationBuilder.Sql(
                "INSERT INTO products (name, price, unit, description, available_quantity, merchant_id) VALUES ('Maszk', 300, 'csomag', 'cicabajszos szájmaszk', 0, (SELECT id from merchants WHERE name = 'CERVA'));"
            );
            migrationBuilder.Sql(
                "INSERT INTO products (name, price, unit, description, available_quantity, merchant_id) VALUES ('Gumikesztyű', 500, 'doboz', 'latex kesztyű púderezett', 0, (SELECT id from merchants WHERE name = 'Medirex'));"
            );
            migrationBuilder.Sql(
                "INSERT INTO products (name, price, unit, description, available_quantity, merchant_id) VALUES ('Kétrétegű maszk', 400, 'doboz', '', 0, (SELECT id from merchants WHERE name = 'CERVA'));"
            );
            migrationBuilder.Sql(
                "INSERT INTO products (name, price, unit, description, available_quantity, merchant_id) VALUES ('Liszt', 500, 'kilogramm', 'Búza finomliszt', 0, (SELECT id from merchants WHERE name = 'Szabó Malom'));"
            );

            migrationBuilder.Sql(
                "INSERT INTO supplies (product_id, quantity, created_date_time) VALUES ((SELECT id FROM products WHERE name = 'Lélegeztetőgép'), 100, CURRENT_TIMESTAMP());"
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM supplies;");
            migrationBuilder.Sql("DELETE FROM products;");
            migrationBuilder.Sql("DELETE FROM merchants;");
        }
    }
}
