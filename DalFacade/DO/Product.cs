
namespace DO;
/// <summary>
/// הגדרת המוצרים    
/// </summary>
/// <param name="Id">ברקוד</param>
/// <param name="Name">שם של המוצר</param>
/// <param name="Category">קטגוריה של המוצר</param>
/// <param name="Price">מחיר של המוצר</param>
/// <param name="Quantity">כמות במלאי</param>
public record Product(int Id, string Name, Category Category, double Price, int Quantity)
{
    public Product(): this(0, string.Empty, Category.HotDrinks, 0.0, 0) { } 
}
     