using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Kur_ach;
using Newtonsoft.Json;

public class DataStorage
{
    public static List<Product> Products { get; set; } = new List<Product>();
    private static string productsPath = "products.json";
    private static string usersPath = "users.json";
    private static string tasksPath = "tasks.json";
    public static List<User> Users { get; set; } = new List<User>();
    private static string usersFile = "users.json";
    // Збереження товарів (разом із зображенням у вигляді base64)
    public static void SaveProducts(List<Product> products)
    {
        foreach (var product in products)
        {
            product.PrepareForSave();
        }

        string json = JsonConvert.SerializeObject(products, Formatting.Indented);
        File.WriteAllText(productsPath, json);
    }

    public static void LoadProducts()
    {
        if (File.Exists(productsPath))
        {
            var json = File.ReadAllText(productsPath);

            if (string.IsNullOrWhiteSpace(json))
            {
                Products = new List<Product>();
            }
            else
            {
                Products = JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
            }

            foreach (var product in Products)
            {
                product.LoadFromBase64();
            }
        }
        else
        {
            Products = new List<Product>();
        }
    }
    // Завантаження користувачів
    public static void LoadUsers()
    {
        if (File.Exists(usersFile))
        {
            var json = File.ReadAllText(usersFile);
            Users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
        }
        else
        {
            Users = new List<User>();
        }
        if (!Users.Any(u => u.Login == "admin"))
        {
            Users.Add(new User("admin", "admin", true));
            SaveUsers();
        }
    }
    public static void SaveUsers()
    {
        var json = JsonConvert.SerializeObject(Users, Formatting.Indented);
        File.WriteAllText(usersFile, json);
    }

    // Збереження завдань (ключ — логін працівника, значення — опис завдання)
    public static void SaveTasks(Dictionary<string, string> tasks)
    {
        string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
        File.WriteAllText(tasksPath, json);
    }

    // Завантаження завдань
    public static Dictionary<string, string> LoadTasks()
    {
        if (!File.Exists(tasksPath))
            return new Dictionary<string, string>();

        string json = File.ReadAllText(tasksPath);
        return JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
    }
}
