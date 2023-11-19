using InnoGotchi.DAL.Entities.Base;

namespace InnoGotchi.DAL.Entities
{
    public sealed class User : BaseEntity
    {
        public string? Nickname { get; set; }
    }
}
