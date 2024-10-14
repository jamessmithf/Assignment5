namespace Assignment5
{
    public partial class MainPage : ContentPage
    {
        private List<Product> products = new List<Product>();

        public MainPage()
        {
            InitializeComponent();
            ProductsGrid.ItemsSource = products;
        }

        private async void OnAddProductClicked(object sender, EventArgs e)
        {
            // Відкриваємо вікно для вибору товару
            string result = await DisplayActionSheet("Оберіть товар:", "Скасувати", null, "Хліб", "Книга", "Штани");

            switch (result)
            {
                case "Хліб":
                    products.Add(new FoodProduct
                    {
                        Name = "Хліб",
                        Price = 15.99M,
                        Currency = "₴",
                        OriginCountry = "Україна",
                        PackagingDate = DateTime.Now,
                        Description = "Хліб відмовився коментувати цей опис, але він виглядає дуже смачним",
                        ExpiryTerm = 7,
                        Quantity = 1,
                        Unit = "шт",
                        FrameColor = Colors.LightGreen
                    });
                    break;

                case "Книга":
                    products.Add(new BookProduct
                    {
                        Name = "Книга\n\"Степан Шкільняк і камінь логіки\"",
                        Price = 148.89M,
                        Currency = "₴",
                        OriginCountry = "Україна",
                        PackagingDate = DateTime.Now,
                        Description = "Захоплива книга, з ісорією про одного хлопчика, який з дитинства отримав дар розуміння математичної логіки",
                        PageCount = 300,
                        Publisher = "Видавництво \"КубікКнига\"",
                        Authors = new List<string> { "Юрій Коваль", "Апостол", "Пророк", "Філософ"},
                        FrameColor = Colors.Moccasin
                    });
                    break;

                case "Штани":
                    products.Add(new ClothesProduct
                    {
                        Name = "Штани",
                        Price = 40.00M,
                        Currency = "₴",
                        OriginCountry = "Україна",
                        PackagingDate = DateTime.Now,
                        Description = "Зручні штани, але трішки вимащені олією після одного невдалого випадку",
                        Color = "Синій",
                        Brand = "SecondHand",
                        Size = "M",
                        FrameColor = Colors.LightBlue
                    });
                    break;
            }

            ProductsGrid.ItemsSource = null; // Оновлюємо список
            ProductsGrid.ItemsSource = products;
        }

        private void OnRemoveProductClicked(object sender, EventArgs e)
        {
            if (products.Count > 0)
            {
                products.RemoveAt(products.Count - 1);
                ProductsGrid.ItemsSource = null;
                ProductsGrid.ItemsSource = products;
            }
        }

        // Обробник події для показу інформаційного вікна
        private async void OnProductTapped(object sender, EventArgs e)
        {
            var tappedEventArgs = (TappedEventArgs)e;
            var selectedProduct = tappedEventArgs.Parameter as Product;

            if (selectedProduct != null)
            {
                string productInfo = selectedProduct.ShowInfo();
                await DisplayAlert("Інформація про товар", productInfo, "ОК");
            }
        }
    }
}
