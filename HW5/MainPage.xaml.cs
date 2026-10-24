
using HW5;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HW5
{
    public partial class MainPage : ContentPage
    {
        private List<Product> products = new List<Product>();

        public MainPage()
        {
            InitializeComponent();
        }

    
        private async void OnAddClicked(object sender, EventArgs e)
        {
            try
            {
                string type = await DisplayActionSheetAsync(
                    "Choose product type",
                    "Cancel",
                    null,
                    "Food",
                    "Book"
                );

                switch (type)
                {
                    case "Food":
                    case "Book":
                        break;

                    default:
                        return;
                }

              
                string name = await ReadText("Enter name:");

                double price = double.Parse(
                    await ReadText("Enter price (e.g. 45.50):"),
                    CultureInfo.InvariantCulture
                );

                string country = await ReadText("Enter country:");

                DateTime packagingDate = DateTime.ParseExact(
                    await ReadText("Packaging date (yyyy-MM-dd):"),
                    "yyyy-MM-dd",
                    CultureInfo.InvariantCulture
                );

                string description = await ReadText(
                    "Enter description:"
                );

                Product product;

                switch (type)
                {
                    case "Food":
                        {
                            Food food = new Food();

                            food.ExpirationDate = DateTime.ParseExact(
                                await ReadText("Expiration date (yyyy-MM-dd):"),
                                "yyyy-MM-dd",
                                CultureInfo.InvariantCulture
                            );

                            food.Quantity = double.Parse(
                                await ReadText("Enter quantity:"),
                                CultureInfo.InvariantCulture
                            );

                            food.Unit = await ReadText("Enter unit:");

                            product = food;
                            break;
                        }

                    case "Book":
                        {
                            Book book = new Book();

                            book.PageCount = int.Parse(
                                await ReadText("Enter page count:")
                            );

                            book.Publisher = await ReadText(
                                "Enter publisher:"
                            );

                            string authors = await ReadText(
                                "Enter authors (separated by commas):"
                            );

                            foreach (string author in authors.Split(','))
                            {
                                book.Authors.Add(author.Trim());
                            }

                            product = book;
                            break;
                        }

                    default:
                        return;
                }

                product.Name = name;
                product.Price = price;
                product.CountryOfOrigin = country;
                product.PackagingDate = packagingDate;
                product.Description = description;

                products.Add(product);

                RefreshGrid();

                await DisplayAlertAsync(
                    "Success",
                    "Product added!",
                    "OK"
                );
            }
            catch (OperationCanceledException)
            {
                
            }
            catch (FormatException)
            {
                await DisplayAlertAsync(
                    "Error",
                    "Invalid number or date format!",
                    "OK"
                );
            }
            catch (OverflowException)
            {
                await DisplayAlertAsync(
                    "Error",
                    "The entered number is too large!",
                    "OK"
                );
            }
            catch (ArgumentException ex)
            {
                await DisplayAlertAsync("Error", ex.Message, "OK");
            }
        }

     
        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            try
            {
                switch (products.Count)
                {
                    case 0:
                        await DisplayAlertAsync(
                            "Error",
                            "No products available!",
                            "OK"
                        );
                        return;
                }

                string input = await ReadText(
                    "Enter product number to delete:"
                );

                int number = int.Parse(input);

                products.RemoveAt(number - 1);

                RefreshGrid();

                await DisplayAlertAsync(
                    "Success",
                    "Product deleted!",
                    "OK"
                );
            }
            catch (OperationCanceledException)
            {
               
            }
            catch (FormatException)
            {
                await DisplayAlertAsync(
                    "Error",
                    "Please enter a valid number!",
                    "OK"
                );
            }
            catch (OverflowException)
            {
                await DisplayAlertAsync(
                    "Error",
                    "The number is too large!",
                    "OK"
                );
            }
            catch (ArgumentOutOfRangeException)
            {
                await DisplayAlertAsync(
                    "Error",
                    "Invalid product number!",
                    "OK"
                );
            }
            catch (ArgumentException ex)
            {
                await DisplayAlertAsync("Error", ex.Message, "OK");
            }
        }


        private async Task<string> ReadText(string message)
        {
            string? answer = await DisplayPromptAsync(
                "Product",
                message
            );

            string text = answer?.Trim()
                ?? throw new OperationCanceledException();

            switch (text)
            {
                case "":
                    throw new ArgumentException(
                        "Value cannot be empty!"
                    );
            }

            return text;
        }


        private void RefreshGrid()
        {
            ProductsGrid.Children.Clear();
            ProductsGrid.RowDefinitions.Clear();

            for (int i = 0; i < products.Count; i++)
            {
                Product product = products[i];

                ProductsGrid.RowDefinitions.Add(
                    new RowDefinition { Height = GridLength.Auto }
                );

                AddCell((i + 1).ToString(), i, 0);
                AddCell(product.Name, i, 1);
                AddCell(product.GetType().Name, i, 2);

                AddCell(
                    product.Price.ToString("F2", CultureInfo.InvariantCulture),
                    i,
                    3
                );
            }
        }

       
        private void AddCell(string text, int row, int column)
        {
            Label label = new Label
            {
                Text = text,
                Padding = new Thickness(5),
                VerticalTextAlignment = TextAlignment.Center
            };

            Grid.SetRow(label, row);
            Grid.SetColumn(label, column);

            ProductsGrid.Children.Add(label);
        }
    }
}

