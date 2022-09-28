namespace AvansToGoodToGo.Models
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        // TODO: TypeOfUser is not needed for login but
        // this model is beeing reused for registration. Make
        // separate vm for reg / login
        public string TypeOfUser { get; set; }
    }
}
