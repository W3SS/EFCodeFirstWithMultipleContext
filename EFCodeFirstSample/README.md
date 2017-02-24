# EFCodeFirstWithMultipleContext

for single DbContext migrations step's commands:
1. Enable-Migrations. It will create a folder named Migration with the file Configuraton.cs.
2. If any context entity changed, execute the Add-Migration <your migration Name>;
3. Update-Database -Verbose

for multiple DbContexts migrations step's commands:
1.enable-migrations -ContextTypeName <DbContext-Name-with-Namespaces> MigrationsDirectory:<Migrations-Directory-Name>. Here we need to define different folders since we need multiple Configuration.

2.Add-Migration -configuration <DbContext-Migrations-Configuration-Class-withNamespaces> <Migrations-Name>

3.Update-Database -configuration <DbContext-Migrations-Configuration-Class-withNamespaces> -Verbose
