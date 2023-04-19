using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nttdata.Migrations
{
    /// <inheritdoc />
    public partial class PopulateClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into tb_clients(name, surname, email) values('Diogo', 'Alves', 'diogo@gmail.com')");
            mb.Sql("insert into tb_clients(name, surname, email) values('Paty', 'Venceslau', 'paty@gmail.com')");
            mb.Sql("insert into tb_clients(name, surname, email) values('Miguel', 'Alves', 'miguel@gmail.com')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from tb_clients");
        }
    }
}
