using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.Dynamics.Commerce.RetailProxy;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Contoso.Commerce.RetailProxy.Extension;

var retailServerUrl = "https://mongol:8084/RetailServer/Commerce"; // insert your server name here

var token =
    ConfidentialClientApplicationBuilder
        .Create(System.IO.File.ReadAllText(@"c:\inst\clientId.exe"))
        .WithClientSecret(System.IO.File.ReadAllText(@"c:\inst\client.exe"))
        .WithAuthority(
            "https://login.microsoftonline.com/72f988bf-86f1-41af-91ab-2d7cd011db47"
        )
        .Build()
        .AcquireTokenForClient(new[] { "https://commerce.dynamics.com/.default" })
        .ExecuteAsync().Result.AccessToken;
Microsoft.Dynamics.Commerce.RetailProxy.RetailServerContext.Initialize(
    new[] { new EdmModel() }
);

var retailCtx = Microsoft.Dynamics.Commerce.RetailProxy.RetailServerContext.Create(
    new System.Uri(retailServerUrl),
    "OS00001",
    token
);
var mgrFactory = Microsoft.Dynamics.Commerce.RetailProxy.ManagerFactory.Create(
    retailCtx
);

Console.WriteLine(
    mgrFactory.GetManager<IOrgUnitManager>().GetOrgUnitConfiguration().Result?.RecordId
);
Console.WriteLine("###############################################\n");