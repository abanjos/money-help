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
            if (context.Bills.Any())
                return;


            //BILLS
            var bills = new Bill[]
            {
                new Bill { Name = "Carteira" }, //0
                new Bill { Name = "Crédito" }, //1
                new Bill { Name = "Débito" } //2
            };

            context.Bills.AddRange(bills);


            //categories
            var categories = new Category[]
            {
                new Category { Name = "Alimentação" }, //0
                new Category { Name = "Casa" }, //1
                new Category { Name = "Despesas Pessoais" }, //2
                new Category { Name = "Lazer" }, //3
                new Category { Name = "Pet" }, //4
                new Category { Name = "Educação" } //5
            };

            context.Categories.AddRange(categories);

            //SUBCATEGORIES
            var subCategories = new SubCategory[]
            {
                //food
                new SubCategory {Name = "Almoço", Category=categories.ElementAt(0)},
                new SubCategory {Name = "Feira", Category=categories.ElementAt(0)},
                new SubCategory {Name = "Supermercado", Category=categories.ElementAt(0)},
                new SubCategory {Name = "Restaurante", Category=categories.ElementAt(0)},
                new SubCategory {Name = "Padaria", Category=categories.ElementAt(0)},
                new SubCategory {Name = "Petiscos", Category=categories.ElementAt(0)},

                //pet
                new SubCategory {Name = "Pet Shop", Category=categories.ElementAt(4)},
                new SubCategory {Name = "Ração", Category=categories.ElementAt(4)},
                new SubCategory {Name = "Veterinário", Category=categories.ElementAt(4)},

                //home
                new SubCategory {Name = "Aluguel", Category=categories.ElementAt(1)},
                new SubCategory {Name = "Condomínio", Category=categories.ElementAt(1)},
                new SubCategory {Name = "Luz", Category=categories.ElementAt(1)},
                new SubCategory {Name = "Internet", Category=categories.ElementAt(1)},
                new SubCategory {Name = "TV a cabo", Category=categories.ElementAt(1)},
                new SubCategory {Name = "Água", Category=categories.ElementAt(1)},
                new SubCategory {Name = "Gás", Category=categories.ElementAt(1)},
                new SubCategory {Name = "Manutenção", Category=categories.ElementAt(1)},

                //education
                new SubCategory {Name = "Faculdade", Category=categories.ElementAt(5)},
                new SubCategory {Name = "Escola", Category=categories.ElementAt(5)},
                new SubCategory {Name = "Livros", Category=categories.ElementAt(5)},
                new SubCategory {Name = "Cursos", Category=categories.ElementAt(5)},

                //personal expenses
                new SubCategory {Name = "Roupas", Category=categories.ElementAt(2)},
                new SubCategory {Name = "Dízimo", Category=categories.ElementAt(2)},
                new SubCategory {Name = "Celular", Category=categories.ElementAt(2)},
                new SubCategory {Name = "Academia", Category=categories.ElementAt(2)},
                new SubCategory {Name = "Acessórios", Category=categories.ElementAt(2)},

                //lazer
                new SubCategory {Name = "Bar / Balada", Category=categories.ElementAt(3)},
                new SubCategory {Name = "Cinema", Category=categories.ElementAt(3)},
                new SubCategory {Name = "Viagem", Category=categories.ElementAt(3)},
                new SubCategory {Name = "Passeio", Category=categories.ElementAt(3)},
                new SubCategory {Name = "Futebol", Category=categories.ElementAt(3)}


            };

            context.SubCategories.AddRange(subCategories);  
            context.SaveChanges();

        }
    }
}
