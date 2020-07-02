namespace IEIMobile.Models.Dtos
{
    public class AuthDataDto
    {
        public string Pin { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public int ExpirationTime { get; set; }
    }
}