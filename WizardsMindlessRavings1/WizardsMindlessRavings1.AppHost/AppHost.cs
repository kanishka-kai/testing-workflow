var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WizardsMindlessRavings1>("wizardsmindlessravings1");

builder.Build().Run();
