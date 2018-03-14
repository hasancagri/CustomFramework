namespace NorthwindApp.StoredProcedures
{
    public static class Product
    {
        public static string GetAllProducts = "sp_GetAllProducts";
        public static string AddProduct = "sp_AddProduct";
        public static string GetProductName = "sp_GetProductName";
        public static string GetProductsByCategoryID = "sp_GetProductsByCategoryID";
        public static string GetProductCount = "sp_ProductCount";
        public static string GetProductbyId = "sp_GetProductById";
        public static string DeleteProduct = "sp_DeleteProduct";
        public static string UpdateProduct = "sp_UpdateProduct";
    }
}
