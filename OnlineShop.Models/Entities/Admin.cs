using SqlSugar;

namespace OnlineShop.Models.Entities
{

    [SugarTable("os_admin")]
    public record Admin:BaseEntity
    {

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
