namespace ProductClientHub.Communication.Requests
{
    public class RequestClientJSON
    {
        // Cria uma propriedade Chamada "name" que não aceita nulos
        public string Name { get; set; } = string.Empty;

        // Cria uma propriedade Chamada "email" que não aceita nulos
        public string Email { get; set; } = string.Empty;
       
    }
}
