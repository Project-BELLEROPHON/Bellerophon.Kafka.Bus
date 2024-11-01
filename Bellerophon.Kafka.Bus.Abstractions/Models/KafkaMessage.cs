namespace Bellerophon.Kafka.Bus.Abstractions.Models;

public class KafkaMessage
{
    public Guid Id { get; set; }
    public string Value { get; set; }
    public Dictionary<string,string> Headers { get; set; }
    public DateTime InsertedAt { get; set; }
    public DateTime ExpiresAt { get; set; }
}