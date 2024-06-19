namespace TestePaschoalotto.Domain.Model;

public class User : Entity
{
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public DateTime DateUser { get; set; }
    public int Age { get; set; }
    public Guid ContactId { get; set; }
    public Guid LocationId { get; set; }
    public Guid LoginId { get; set; }
    public Guid NaturalizationId { get; set; }
    public Guid PictureId { get; set; }



    // Agregacao
    public Contact Contacts { get; set; }
    public Location Location { get; set; }
    public Login Login { get; set; }
    public Naturalization Naturalization { get; set; }
    public Picture Picture { get; set; }

    //public User(string title, string firstName, string lastName, string gender, DateTime date, int age, Guid contactId, Guid locationId, Guid loginId, Guid naturalizationId, Guid pictureId)
    //{
    //    Title = title;
    //    FirstName = firstName;
    //    LastName = lastName;
    //    Gender = gender;
    //    DateUser = date;
    //    Age = age;
    //    ContactId = contactId;
    //    LocationId = locationId;
    //    LoginId = loginId;
    //    NaturalizationId = naturalizationId;
    //    PictureId = pictureId;
    //}
}
