using System;
using System.Collections.Generic;
class Category
{
    public string Name { get; set; }
    public int Products { get; set; }
    public List<Category> Children { get; set; }

    public Category(string name, int products, List<Category> children)
    {
        Name = name;
        Products = products;
        Children = children;
    }
}

class Program
{
    static int callCount = 0;

    static void Main()
    {
        Category catalog = new Category("Каталог", 0, new List<Category>
        {
            new Category("Одяг", 0, new List<Category>
            {
                new Category("Верхній одяг", 0, new List<Category>
                {
                    new Category("Куртки", 12, new List<Category>()),
                    new Category("Пальта", 7, new List<Category>())
                }),
                new Category("Светри", 15, new List<Category>())
            }),

            new Category("Взуття", 4, new List<Category>
            {
                new Category("Кросівки", 23, new List<Category>()),
                new Category("Чоботи", 9, new List<Category>())
            }),

            new Category("Аксесуари", 0, new List<Category>
            {
                new Category("Сумки", 18, new List<Category>()),
                new Category("Ремені", 5, new List<Category>())
            })
        });

        // Частина 1. Виведення ієрархії категорій
        Console.WriteLine("1. Ієрархія категорій:");
        callCount = 0;
        PrintTree(catalog, 0);

        Console.WriteLine();

        // Частина 2. Підрахунок товарів
        callCount = 0;
        int totalProducts = CountProducts(catalog);

        Console.WriteLine("2. Загальна кількість товарів: " + totalProducts);
        Console.WriteLine("Кількість викликів CountProducts: " + callCount);

        Console.WriteLine();

        // Частина 3. Визначення глибини дерева
        callCount = 0;
        int depth = MaxDepth(catalog);

        Console.WriteLine("3. Глибина найдовшої гілки: " + depth);
        Console.WriteLine("Кількість викликів MaxDepth: " + callCount);
    }

    // TODO 1. Виведення ієрархії
    static void PrintTree(Category node, int level)
    {
        callCount++;

        Console.WriteLine(new string(' ', level * 2) + node.Name);

        foreach (Category child in node.Children)
        {
            PrintTree(child, level + 1);
        }
    }

    // TODO 2. Підрахунок усіх товарів
    static int CountProducts(Category node)
    {
        callCount++;

        int total = node.Products;

        foreach (Category child in node.Children)
        {
            total += CountProducts(child);
        }

        return total;
    }

    // TODO 3. Визначення глибини дерева
    static int MaxDepth(Category node)
    {
        callCount++;

        if (node.Children.Count == 0)
        {
            return 1;
        }

        int maxChildDepth = 0;

        foreach (Category child in node.Children)
        {
            int childDepth = MaxDepth(child);

            if (childDepth > maxChildDepth)
            {
                maxChildDepth = childDepth;
            }
        }

        return maxChildDepth + 1;
    }
}