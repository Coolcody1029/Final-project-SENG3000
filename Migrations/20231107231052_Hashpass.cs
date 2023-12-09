using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzaStore.Migrations
{
    /// <inheritdoc />
    public partial class Hashpass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "A0A7B968A20E3FB39B1B8AA4877F29597D56FFBD907891FEEDABBF940E70633F586F67BFF07A4975CBA22A22F7F1B988F2DD1A6A4867A60AC1B25C417B3EA99C", "FE5D976E712E3122CB81BBB3B85AE2DD360020C7027E30CDC3375C7C36FF6A807C11C2D9963E28F806DA5BC9A22466F4B6C523FBE104EFCFCD05C47C609CF339" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "FA6BA0AE07E34A0916FFF2ECF20D995FE05A52D44A385566B45D580E61CEF66344466DC87573ABD76BCF26EC823E4F94A5C82CCFE57EE4ABD7A6073383280DA3", "686981512FBED86F8EE4FE8673F899332D3D0BFCEAD08F9E4DF6359E3AB5DCAC2F66583572100E7F73439768C8AF803D2B8B45D44FCF8E00F7CC15B8B15528A7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "", "" });
        }
    }
}
