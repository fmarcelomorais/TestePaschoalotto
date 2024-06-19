namespace TestePaschoalotto.Domain.Model;

public class User : Entity
{
    public string Title { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Gender { get; private set; }
    public DateTime Date { get; private set; }
    public int Age { get; private set; }
    public Guid ContactId { get; private set; }
    public Guid LocationId { get; private set; }
    public Guid LoginId { get; private set; }
    public Guid NaturalizationId { get; private set; }
    public Guid PictureId { get; private set; }



    // Agregacao
    public Contact Contacts { get; set; }
    public Location Location { get; set; }
    public Login Login { get; set; }
    public Naturalization Naturalization { get; set; }
    public Picture Picture { get; set; }

    public User(string title, string firstName, string lastName, string gender, DateTime date, int age, Guid contactId, Guid locationId, Guid loginId, Guid naturalizationId, Guid pictureId)
    {
        Title = title;
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Date = date;
        Age = age;
        ContactId = contactId;
        LocationId = locationId;
        LoginId = loginId;
        NaturalizationId = naturalizationId;
        PictureId = pictureId;
    }
}
