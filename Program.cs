using System;
using System.Text.Json;

namespace McpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MCP Server started");

            while (true)
            {
                string? input = Console.ReadLine();
                if (input == null) break;

                try
                {
                    using JsonDocument doc = JsonDocument.Parse(input);
                    Console.WriteLine(JsonSerializer.Serialize(new { result = "ok", received = doc.RootElement }));
                }
                catch (JsonException)
                {
                    Console.WriteLine("{\"error\":\"invalid json\"}");
                }
            }
        }
    }
}

