using Data.nHibernate;
using System;

namespace Data.NHibernate
{
    public class ClassConsumoSimples
    {
        private void consumirMetodos()
        {

            var produtoDao = DaoFactory.CreateDao<Produto>();

            // Exemplo de uso do DAO
            var produto = new Produto { Nome = "Produto 1", Preco = 9.99m };
            produtoDao.Save(produto);

            var produtoId = 1;
            var produtoRecuperado = produtoDao.GetById(produtoId);
            if (produtoRecuperado != null)
            {
                // Atualiza o nome do produto
                produtoRecuperado.Nome = "Produto Atualizado";
                produtoDao.Update(produtoRecuperado);
            }

            var produtos = produtoDao.GetAll();
            foreach (var prod in produtos)
            {
                Console.WriteLine($"Id: {prod.Id}, Nome: {prod.Nome}, Preço: {prod.Preco}");
            }

            produtoDao.Delete(produtoRecuperado);

        }
    }
}
