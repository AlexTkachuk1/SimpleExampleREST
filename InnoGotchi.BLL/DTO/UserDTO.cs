namespace InnoGotchi.BLL.DTO
{
    public sealed record UserDTO
    {
        public int Id { get; set; }
        public string? Nickname { get; init; }
    }
}
