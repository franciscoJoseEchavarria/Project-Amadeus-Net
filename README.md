# Proyecto Backend Amadeus

Este es un proyecto de backend desarrollado en C# utilizando ASP.NET Core. El proyecto incluye un controlador para gestionar usuarios, con endpoints para obtener, crear, actualizar y eliminar usuarios, así como un endpoint para autenticación de usuarios.

## Requisitos

- .NET 6 SDK o superior
- PostgreSQL

## Configuración

1. Clona el repositorio:
  
   ```sh
   git clone https://github.com/tu-usuario/proyecto-backend-amadeus.git
   cd proyecto-backend-amadeus
    ```

2. Configura la cadena de conexión a la base de datos en appsettings.json:

    ```sh
   
   {
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=YourDatabaseName;Username=YourUsername;Password=YourPassword"
    },
    "Logging": {
        "LogLevel": {
        "Default": "Information",
        Microsoft.AspNetCore: "Warning"
        "}"
    },
    "AllowedHosts": "*"
   "}" 
    

     ```

3. Aplica las migraciones de la base de    datos:
    ```
    dotnet ef migrations add InitialCreate
    dotnet ef database update

    ```

## ejecución

1. Ejecuta la aplicación:
    ```
    dotnet run
    ```