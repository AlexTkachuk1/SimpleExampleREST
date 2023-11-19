using InnoGotchi.DAL.Entities.Base;

namespace InnoGotchi.DAL.Entities
{
    public sealed class User : BaseEntity
    {
        public int Id { get; set; }

        public string? Nickname { get; set; }
    }
}
