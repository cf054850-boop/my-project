
namespace DO;
/// <summary>
/// מבצעים של המוצרים
/// </summary>
/// <param name="Id">מזהה ייחודי של המבצע</param>
/// <param name="ProductId">מזהה המוצר שבמבצע</param>
/// <param name="RequiredQuantity">כמות נדרשת לקבלת המבצע</param>
/// <param name="TotalPrice">מחיר כולל במבצע</param>
/// <param name="ClubOnly">האם המבצע רק ללקוחות מועדון</param>
/// <param name="StartDate">תאריך תחילת המבצע</param>
/// <param name="EndDate">תאריך סיום המבצע</param>
public record Sale(int Id, int ProductId, int RequiredQuantity, double TotalPrice, bool ClubOnly, DateTime StartDate, DateTime EndDate)
{
    public Sale() : this(0, 0, 0, 0.0, false, DateTime.Now, DateTime.Now) { }
}