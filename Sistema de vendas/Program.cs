// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

Class1 cls = new Class1();
List<Class1> Lista = new List<Class1>();
var cont = 0;
Type tipo = typeof(Class1);
const bool conf = true;
while (conf)
{
    switch (Menu())
    {
        case 1:
            CadastraProdutos();
            break;
        case 2:
            VisualizaProdutos();
            break;
        case 3:
            EditaProdutos();
            break;
        case 4:
            ExcluiProdutos();
            break;
        case 0:
            int exitCode = 0;
            Environment.Exit(exitCode);
            break;
    }
}

return;

static int Menu()
{
    Console.WriteLine("\n*-*-* MENU *-*-*");
    Console.WriteLine("1. Cadastro ");
    Console.WriteLine("2. Visualização ");
    Console.WriteLine("3. Edição ");
    Console.WriteLine("4. Exclusão ");
    Console.WriteLine("0. Sair \n");
    var menu = System.Convert.ToInt32(Console.ReadLine());
    return menu;
}
void CadastraProdutos()
{
    var cls = new Class1();

    Console.WriteLine("\nInsira um produto a ser cadastrado: ");
    cls.Name = Console.ReadLine();
    Console.WriteLine("Insira o preço do produto: ");
    cls.Preco = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira o tipo do produto: ");
    cls.Tipo = Console.ReadLine();
    
    
    Lista.Add(cls);
}

void VisualizaProdutos()
{
    Console.WriteLine("Segue lista de produtos: ");
    for (int i = 0; i < Lista.Count; i++)
    {
        Class1 prod = Lista[i];
        Console.WriteLine("\nID: " + i);
        foreach (PropertyInfo prop in typeof(Class1).GetProperties())
        {
            string produto = prop.Name;
            object valorProp = prop.GetValue(prod);
            Console.WriteLine($"{produto}: {valorProp}");
        }
        Console.WriteLine();
    }
}
void EditaProdutos()
{
    VisualizaProdutos();

    Console.WriteLine("\nInsira o ID do produto a ser editado");
    var id = System.Convert.ToInt32(Console.ReadLine());
    Lista.RemoveAt(id);
    Console.WriteLine("Insira o novo nome do produto: ");
    cls.Name = Console.ReadLine();
    Console.WriteLine("Insira o preço do novo produto: ");
    cls.Preco = float.Parse(Console.ReadLine());
    Console.WriteLine("Insira o tipo do novo produto: ");
    cls.Tipo = Console.ReadLine();


    Lista.Insert(id, cls);

}
void ExcluiProdutos()
{
    VisualizaProdutos();
    Console.WriteLine("Insira o ID do produto para exclusão: ");
    var resp = System.Convert.ToInt32(Console.ReadLine());
    Lista.RemoveAt(resp);
    Console.WriteLine("Produto Excluido com sucesso! \n");
}