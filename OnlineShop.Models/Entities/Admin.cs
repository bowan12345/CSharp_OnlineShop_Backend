namespace OnlineShop.Models.Entities
{
    public record Admin:BaseEntity
    {
        // admin id
        public string Id { get; init; }

        // username
        public string Username { get; init; }

        // password
        public string Password { get; init; }

        // email
        public string Email { get; init; }

        // phone number
        public string Phone { get; init; }


    }
}
