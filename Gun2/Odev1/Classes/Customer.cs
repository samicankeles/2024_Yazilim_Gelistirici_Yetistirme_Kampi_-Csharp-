namespace Classes;

class Customer
{
    private string _firstName;
    public int Id { get; set; }
    public string FirstName {
        get
        {
            return "Sayın " + _firstName; 
        }
        set
        {
            _firstName = value;
        }
    }
    public string LastName { get; set; }
    public string City { get; set; }
}