using PracticeLINQ.Models;
using System.Collections;
List<Product> products = new List<Product>()
{
    new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
    new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
    new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
    new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
    new Product(5, "Huawei P30", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
    new Product(6, "MacBook Pro", "MacBook Pro 2021 with mini-LED display may launch between September, November", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
    new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
    new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
    new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
    new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
    new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
    new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
    new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
    new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
    new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
    new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
    new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
    new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
    new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
    new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
    new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
    new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
    new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries)
};
static void PrintProductsProduction(IEnumerable<Product> products)
{
    int i = 0;
    foreach (var product in products)
    {
        i++;

        Console.WriteLine($"{i}:Title: {product.Title}, Category: {product.Category}, Price: {product.Price}");
    }
    Console.WriteLine("===================");

}
static void PrintProductsStrings(IEnumerable<string> items)
{
    int i = 0;
    foreach (var item in items)
    {
        i++;

        Console.WriteLine($"{i}: {item}");
    }
    Console.WriteLine("===================");
}

Console.WriteLine("All products with a price greater than $500: ");
List<Product> productMoreThan1000 = products.Where(product => product.Price > 500).ToList();
PrintProductsProduction(productMoreThan1000);

Console.WriteLine("All products with a price greater than $500: ");
List<Product> skincareProducts = products.Where(product => product.Category == ProductCategory.Skincare).ToList();
PrintProductsProduction(skincareProducts);

Console.WriteLine("All products Titles: ");
List<string> titleProduct = products.Select(product => product.Title).ToList();
PrintProductsStrings(titleProduct);

Console.WriteLine("All products Titles in the Laptop category: ");
List<string> laptopTitleProduct = products.Where(product => product.Category == ProductCategory.Laptops).Select(product => product.Title).ToList();
PrintProductsStrings(laptopTitleProduct);

Console.WriteLine("All products desciption with less stock than 50:");
List<string> stockLessThan50 = products.Where(product => product.Stock < 50).Select(product => product.Description).ToList();
PrintProductsStrings(stockLessThan50);

Console.WriteLine("All products with rating above 4.5:");
List<string> higherRating = products.Where(product => product.Rating > 4.5).Select(product => product.Title).ToList();
PrintProductsStrings(higherRating);

Console.WriteLine("All products with price between 100$ and 200%:");
List<string> pricesBetween = products.Where(product => product.Price > 100 && product.Price < 200).Select(product => product.Title).ToList();
PrintProductsStrings(pricesBetween);

Console.WriteLine("All Fragrances products with rating above 4.5:");
List<string> fragrancesAboveRating = products.Where(product => product.Category == ProductCategory.Fragrances && product.Rating > 4.6).Select(product => product.Title).ToList();
PrintProductsStrings(fragrancesAboveRating);

Console.WriteLine("All Brands with price above 1000$:");
List<string> brandsAbove1000 = products.Where(product => product.Price > 1000).Select(product => product.Brand).ToList();
PrintProductsStrings(brandsAbove1000);

Console.WriteLine("All Products with word Perfume in the title:");
List<string> productsWithPerfume = products.Where(product => product.Title.ToLower().Contains("perfume")).Select(product => product.Title).ToList();
PrintProductsStrings(productsWithPerfume);

Console.WriteLine("Last product in Groceries category:");
Product lastProduct = products.LastOrDefault(product => product.Category == ProductCategory.Groceries);
if (lastProduct != null)
{
    Console.WriteLine($"Title:{lastProduct.Title}");
    Console.WriteLine("===================");
}
else
{
    Console.WriteLine("No groceries found!");
    Console.WriteLine("===================");
}

Console.WriteLine("First product with price above 1000$ is:");
Product firstProductAbove1000 = products.FirstOrDefault(product => product.Price > 1000);
if (firstProductAbove1000 != null)
{
    Console.WriteLine($"Title:{firstProductAbove1000.Title}");
    Console.WriteLine("===================");
}
else
{
    Console.WriteLine("No product above 1000$ is found!");
    Console.WriteLine("===================");
}

Console.WriteLine("All products in Groceries category with stock above 150:");
List<string> groceriesAbove150Stock = products.Where(product => product.Category == ProductCategory.Groceries && product.Stock > 150).Select(product => product.Title).ToList();
PrintProductsStrings(groceriesAbove150Stock);

Console.WriteLine("First product in Hemani Tea brand:");
Product firstProductByBrand = products.FirstOrDefault(product => product.Brand.ToLower() == "hemani tea");
if (firstProductByBrand != null)
{
    Console.WriteLine($"Title:{firstProductByBrand.Title}");
    Console.WriteLine("===================");
}
else
{
    Console.WriteLine("No product in Hemani Tea is found!");
    Console.WriteLine("===================");
}

Console.WriteLine("All rating for products with stock between 30 and 50:");
List<double> ratingForProductsWithStock = products.Where(product => product.Stock > 30 && product.Stock < 50).Select(product => product.Rating).ToList();

foreach (double rating in ratingForProductsWithStock)
{
    Console.WriteLine(rating);
}

double totalPrice = 0;
foreach (var product in products)
{
    totalPrice += product.Price;
}
double averagePrice = totalPrice / products.Count;
Console.WriteLine("===================");
Console.WriteLine($"The average price for all products is: {averagePrice}");

int totalStock = 0;
foreach (var product in products)
{
    totalStock += product.Stock;
}
Console.WriteLine("===================");
Console.WriteLine($"The total stock of the products is {totalStock}");

Console.WriteLine("===================");
List<Product> checkAbove2000 = products.Where(product => product.Price > 2000).ToList();
Console.WriteLine("All products with prize above 2000$:");
if (checkAbove2000.Count != 0)
{
    PrintProductsProduction(checkAbove2000);
}
else
{
    Console.WriteLine("There is no product with price above 2000$");
}
Product mostExpensiveLaptop = null;
double highestPrice = 0;
foreach (var product in products)
{
    if (product.Price > highestPrice)
    {
        highestPrice = product.Price;
        mostExpensiveLaptop = product;
    }
}

Console.WriteLine("===================");
Console.WriteLine("Most expensive laptop:");
Console.WriteLine($"{mostExpensiveLaptop.Title} with price of {highestPrice}");

Console.WriteLine("===================");
Console.WriteLine("Titles and description for the skincare products:");
List<string> descriptionAndTitle = products.Where(product => product.Category == ProductCategory.Skincare).Select(product => $"{product.Title} {product.Description}").ToList();
PrintProductsStrings(descriptionAndTitle);