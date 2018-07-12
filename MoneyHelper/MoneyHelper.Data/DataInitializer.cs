using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace MoneyHelper.Data
{
    public static class DataInitializer
    {
        public static void Initialize(DataContext context)
        {
            //creating base
            context.Database.EnsureCreated();

            //verifying if any exists via linq
            if (context.Transactions.Any())
                return;


            //BILLS
            var bills = new Bill[]
            {
                new Bill { Name = "Carteira" }, //0
                new Bill { Name = "Crédito" }, //1
                new Bill { Name = "Débito" } //2
            };

            context.Bills.AddRange(bills);

            //SUBCATEGORIAS
            var subCategories = new SubCategory[]
            {
                //food ok
                new SubCategory { Name = "Almoço" }, //0
                new SubCategory { Name = "Feira" }, //1
                new SubCategory { Name = "Supermercado" }, //2
                new SubCategory { Name = "Restaurante" }, //3
                new SubCategory { Name = "Padaria" }, //4
                new SubCategory { Name = "Petiscos" },//5

                //pet ok
                new SubCategory { Name = "Pet Shop" }, //6
                new SubCategory { Name = "Ração" }, //7
                new SubCategory { Name = "Veterinário" }, //8

                //home ok
                new SubCategory { Name = "Aluguel" }, //9
                new SubCategory { Name = "Condomínio" }, //10
                new SubCategory { Name = "Luz" }, //11
                new SubCategory { Name = "Internet" }, //12
                new SubCategory { Name = "TV a cabo" }, //13
                new SubCategory { Name = "Água" },  //14
                new SubCategory { Name = "Gás" }, //15
                new SubCategory { Name = "Manutenção" }, //16

                //education ok
                new SubCategory { Name = "Faculdade" }, //17
                new SubCategory { Name = "Escola" }, //18
                new SubCategory { Name = "Livros" }, //19
                new SubCategory { Name = "Cursos" }, //20

                //personal expenses ok
                new SubCategory { Name = "Roupas" }, //21
                new SubCategory { Name = "Dízimo" }, //22
                new SubCategory { Name = "Celular" }, //23
                new SubCategory { Name = "Academia" }, //24
                new SubCategory { Name = "Acessórios" }, //25

                //lazer ok
                new SubCategory { Name = "Bar ou Balada" }, //26
                new SubCategory { Name = "Cinema, Teatro ou Show" }, //27
                new SubCategory { Name = "Viagem" }, //28
                new SubCategory { Name = "Passeio" }, //29
                new SubCategory { Name = "Futebol" }, //30              


            };

            context.SubCategories.AddRange(subCategories);

            //CATEGORIAS
            var categories = new Category[]
            {
               new Category
               {
                   Name = "Alimentação",
                   SubCategory =
                   {
                       subCategories.ElementAt(0),
                       subCategories.ElementAt(1),
                       subCategories.ElementAt(2),
                       subCategories.ElementAt(3),
                       subCategories.ElementAt(4),
                       subCategories.ElementAt(5)
                   }
               },

               new Category
               {
                   Name = "Casa",
                   SubCategory =
                   {
                       subCategories.ElementAt(9),
                       subCategories.ElementAt(10),
                       subCategories.ElementAt(11),
                       subCategories.ElementAt(12),
                       subCategories.ElementAt(13),
                       subCategories.ElementAt(14),
                       subCategories.ElementAt(15),
                       subCategories.ElementAt(16)
                   }
               },

               new Category
               {
                   Name = "Lazer",
                   SubCategory =
                   {
                       subCategories.ElementAt(26),
                       subCategories.ElementAt(27),
                       subCategories.ElementAt(28),
                       subCategories.ElementAt(29),
                       subCategories.ElementAt(30)
                   }
               },

               new Category
               {
                   Name = "Despesas Pessoais",
                   SubCategory =
                   {
                       subCategories.ElementAt(21),
                       subCategories.ElementAt(22),
                       subCategories.ElementAt(23),
                       subCategories.ElementAt(24),
                       subCategories.ElementAt(25)
                   }
               },

               new Category
               {
                   Name = "Pet",
                   SubCategory =
                   {
                       subCategories.ElementAt(6),
                       subCategories.ElementAt(7),
                       subCategories.ElementAt(8)
                   }
               },
               new Category
               {
                   Name = "Educação",
                   SubCategory =
                   {
                       subCategories.ElementAt(17),
                       subCategories.ElementAt(18),
                       subCategories.ElementAt(19),
                       subCategories.ElementAt(20)
                   }
               },

            };

            //USER
            context.Categories.AddRange(categories);
            context.SaveChanges();

        }
    }
}
