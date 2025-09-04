// See https://aka.ms/new-console-template for more information
using CamundaConsoleApp;
using Google.Apis.Auth.OAuth2;
using Microsoft.Extensions.Configuration;
using Zeebe.Client;
using Zeebe.Client.Api.Builder;
using Zeebe.Client.Impl.Builder;

// load appsettings.json
var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

var zeebe = config.GetSection("Zeebe").Get<ZeebeSettings>();



IZeebeClient zeebeClient = CamundaCloudClientBuilder
                  .Builder()
                  .UseClientId(zeebe?.ClientId)
                  .UseClientSecret(zeebe?.ClientSecret)
                  .UseContactPoint(zeebe?.GatewayAddress)
                  .Build();



Console.WriteLine("Connecting to Camunda Cloud...");

//var topology = await zeebeClient.TopologyRequest().Send();
Console.WriteLine("Connected to Camunda Cloud!");
//Console.WriteLine($"Cluster Size: {topology.Brokers.Count}");
var processInstanceResponse = zeebeClient
                .NewCreateProcessInstanceCommand()
                .BpmnProcessId("Inventory_Process")
                .LatestVersion()
                .Send();

Console.WriteLine("Process Instance has been started!");
//var processInstanceKey = processInstanceResponse.Result.ProcessInstanceKey;
//Console.WriteLine($"Process Instance Key: {processInstanceKey}");