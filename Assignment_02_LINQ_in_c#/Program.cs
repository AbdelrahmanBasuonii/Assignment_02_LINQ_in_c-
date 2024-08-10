
namespace Assignment_02_LINQ_in_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Get first Product out of Stock 
            //var products = ListGenerator.GenerateProducts();
            //var firstOutOfStockProduct = Product.FirstOrDefault(p => Product.UnitsInStock == 0);

            //if (firstOutOfStockProduct != null)
            //{
            //    Console.WriteLine($"The first product out of stock is: {firstOutOfStockProduct.Name}");
            //}
            //else
            //{
            //    Console.WriteLine("No product is out of stock.");
            //} 
            #endregion



            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var products = ListGenerators.GenerateProducts();

            //var expensiveProduct = products.FirstOrDefault(p => p.Price > 1000);

            //if (expensiveProduct != null)
            //{
            //    Console.WriteLine($"The first product with a price greater than 1000 is: {expensiveProduct.Name}");
            //}
            //else
            //{
            //    Console.WriteLine("There is no product with a price greater than 1000.");
            //} 
            #endregion

            #region 3. Retrieve the second number greater than 5 

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //// Retrieve the second number greater than 5
            //var secondNumberGreaterThanFive = Arr
            //    .Where(n => n > 5)  // Filter numbers greater than 5
            //    .Skip(1)            // Skip the first one
            //    .FirstOrDefault();  // Get the second one

            //if (secondNumberGreaterThanFive != 0)
            //{
            //    Console.WriteLine($"The second number greater than 5 is: {secondNumberGreaterThanFive}");
            //}
            //else
            //{
            //    Console.WriteLine("There is no second number greater than 5.");
            //} 
            #endregion

            //------------------------------------------------------------------------------------

            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int oddNumbersCount = Arr.Count(n => n % 2 != 0);

            //Console.WriteLine($"The number of odd numbers in the array is: {oddNumbersCount}"); 
            #endregion

            #region 2. Return a list of customers and how many orders each has
            // var customerOrderCounts = ListGenerators.CustomerList
            //.Select(c => new
            //{
            //    CustomerName = c.Name,
            //    Orders = c.Orders.Count
            //});


            // foreach (var customer in customerOrderCounts)
            // {
            //     Console.WriteLine($"Customer: {customer.CustomerName}, Number of Orders: {customer.OrderCount}");
            // } 
            #endregion

            #region 3. Return a list of categories and how many products each has
            // var categoryProductCounts = Product
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    CategoryName = g.Key,
            //    ProductCount = g.Count()
            //});

            // // Print the results
            // foreach (var category in categoryProductCounts)
            // {
            //     Console.WriteLine($"Category: {category.CategoryName}, Number of Products: {category.ProductCount}");
            // } 
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int totalSum = Arr.Sum();

            //Console.WriteLine($"The total sum of the numbers in the array is: {totalSum}"); 
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt 
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //int totalCharacters = words.Sum(word => word.Length);

            //Console.WriteLine($"The total number of characters in all words is: {totalCharacters}");
            #endregion




        }
    }
}
