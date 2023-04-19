using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nttdata.Migrations
{
    /// <inheritdoc />
    public partial class PopulateProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into tb_products(name, description, price, stock) values('Pizza', 'Pizza sabor a definir pesando 1kg', 35.00, 10)");
            mb.Sql("insert into tb_products(name, description, price, stock) values('Coxinha', 'Coxinha sabor a definir pesando 300g', 8.00, 10)");
            mb.Sql("insert into tb_products(name, description, price, stock) values('Hamburguer', 'Hamburguer sabor a definir pesando 500g', 20.00, 10)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from tb_products");
        }
    }
}
