using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.Dynamics.Commerce.RetailProxy;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Contoso.Commerce.RetailProxy.Extension;

var retailServerUrl = "https://mongol:8083/RetailServer/Commerce"; // insert your server name here

// feel free to replace this with your own way of getting a clientId + secret
Console.WriteLine("Getting client secret from KeyVault...");
var client = new SecretClient(new System.Uri("https://msecommonkvint.vault.azure.net"), new AzureCliCredential());
var json = client.GetSecret("MSE-D365-Secrets").Value.Value;
var secrets = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
var clientId = client.GetSecret("DevHarnessClientId")?.Value?.Value;
var clientSecret = client.GetSecret("DevHarnessClientSecret")?.Value?.Value;
Console.WriteLine($"Authorizing {clientId} with AAD for {retailServerUrl}...");
var token = ConfidentialClientApplicationBuilder.Create(clientId).WithClientSecret(clientSecret)
    .WithAuthority("https://login.microsoftonline.com/72f988bf-86f1-41af-91ab-2d7cd011db47").Build().AcquireTokenForClient(new[] { "https://commerce.dynamics.com/.default" }).ExecuteAsync().Result.AccessToken;


var retailCtx = Microsoft.Dynamics.Commerce.RetailProxy.RetailServerContext.Create(
    new System.Uri(retailServerUrl),
    "OS00001",
    token
);
var mgrFactory = Microsoft.Dynamics.Commerce.RetailProxy.ManagerFactory.Create(retailCtx);
var q = new QueryResultSettings { Paging = new PagingInfo { Top = 100, Skip = 0 } };
var kitLineItemManager = mgrFactory.GetManager<IKitLineItemManager>();
var result = await (
                kitLineItemManager.GetDynamicKitByAnyOfPSA(
                    new[] { "8V9DP4LNKNSZ" },
                    new QueryResultSettings
                    {
                        Paging = new PagingInfo { Skip = 0, Top = 100 }
                    }
                )
            );
Console.WriteLine($"Result: {result})");
// Unhandled exception. System.ArgumentOutOfRangeException: Length cannot be less than zero. (Parameter 'length')
// at System.String.Substring(Int32 startIndex, Int32 length)
//   at Microsoft.OData.TypeUtils.ParseQualifiedTypeName(String qualifiedTypeName, String& namespaceName, String& typeName, Boolean& isCollection)