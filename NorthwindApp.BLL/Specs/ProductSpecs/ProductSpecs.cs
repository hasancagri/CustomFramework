namespace NorthwindApp.BLL.Specs.ProductSpecs
{
    public static class ProductSpecs
    {
        public static ProductMustBeInBeverageCategory ProductMustBeInBeverageCategory
        {
            get
            {
                return new ProductMustBeInBeverageCategory();
            }
        }

        public static ProductMustBeInCondimentsCategory ProductMustBeInCondimentsCategory
        {
            get
            {
                return new ProductMustBeInCondimentsCategory();
            }
        }

        public static ProductNameMustBeUnique ProductNameMustBeUnique
        {
            get
            {
                return new ProductNameMustBeUnique();
            }
        }
    }
}
