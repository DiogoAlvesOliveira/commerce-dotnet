using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nttdata.Migrations
{
    /// <inheritdoc />
    public partial class PopulateAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into tb_addresses(address, number, complement, neighborhood, city, state, country, zipCode, ClientId) values('Rua Joaquim de França', '171', 'Casa','Dois Unidos', 'Recife', 'Pernambuco', 'Brasil', '52140310', 1)");
            mb.Sql("insert into tb_addresses(address, number, complement, neighborhood, city, state, country, zipCode, ClientId) values('Rua José Ramos de Vasconcelos', '1088', 'Casa','Pau Amarelo', 'Paulista', 'Pernambuco', 'Brasil', '53433220', 2)");
            mb.Sql("insert into tb_addresses(address, number, complement, neighborhood, city, state, country, zipCode, ClientId) values('Rua José Ramos de Vasconcelos', '1079', 'Casa 3','Pau Amarelo', 'Paulista', 'Pernambuco', 'Brasil', '53433220', 3)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from tb_addresses");
        }
    }
}
