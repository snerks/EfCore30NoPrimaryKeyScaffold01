# EfCore30NoPrimaryKeyScaffold01
EF Core 3.0 Scaffolding with no Primary Key

dotnet tool install --global dotnet-ef

dotnet ef dbcontext scaffold "Data Source=(localdb)\ProjectsV13;Initial Catalog=NoPrimaryKeyDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False" Microsoft.EntityFrameworkCore.SqlServer -o Models

