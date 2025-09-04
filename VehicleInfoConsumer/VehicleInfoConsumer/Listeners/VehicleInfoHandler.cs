using Confluent.Kafka;
using System.Text.Json;
using VehicleInfoConsumer.DTOs;

namespace VehicleInfoConsumer.Listeners
{
    public class VehicleInfoHandler : IMessageHandler
    {
        public Task<bool> HandleAsync(string topic, string key, string value, Headers headers, CancellationToken ct)
        {
            // Example: deserialize and do something
            try
            {
                var vehicle = JsonSerializer.Deserialize<VehicleReadDTO>(value) ?? null;
                Console.WriteLine($"[VehicleInfoHandler] topic={topic} key={key} id={vehicle.RegNo} model={vehicle.model} dor={vehicle.dor}");
                // todo: call your domain logic / DB, etc.
                return Task.FromResult(true); // commit
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[VehicleInfoHandler] Deserialize/handle failed: {ex.Message}");
                // return false to avoid committing (will retry). Be careful with poison pills.
                return Task.FromResult(true); // demo: commit anyway to avoid infinite retries
            }
        }
    }
}
