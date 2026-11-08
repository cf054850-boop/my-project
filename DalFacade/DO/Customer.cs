
namespace DO;
/// <summary>
/// הגדרת לקוחות
/// </summary>
/// <param name="Id">תעודת זהות</param>
/// <param name="Name">שם הלקוח</param>
/// <param name="PhoneNumber">טלפון הלקוח</param>
/// <param name="Address">כתובת הלקוח</param>
public record Customer(int Id, string Name, string PhoneNumber, string Address)
{
    public Customer() : this(0, string.Empty, string.Empty, string.Empty) { }
}
