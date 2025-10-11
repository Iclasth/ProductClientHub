namespace ProductClientHub.Communication.Responses
{
    public class ResponseClientJSON
    {
        // Cria uma propriedade que retorna o Id do cliente
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
