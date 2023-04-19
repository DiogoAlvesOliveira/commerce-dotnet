using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nttdata.Migrations
{
    /// <inheritdoc />
    public partial class PopulateOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into tb_orders(instant, ClientId) values(now(), 1)");
            mb.Sql("insert into tb_orders(instant, ClientId) values(now(), 2)");
            mb.Sql("insert into tb_orders(instant, ClientId) values(now(), 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from tb_orders");
        }
    }
}
