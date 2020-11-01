# Pasando de guardar en Memoria a SQL Server.

### Pre requisitios
- Tener SQL Server instalado [SQL Server](https://www.microsoft.com/en-us/download/details.aspx?id=55994)
- Recomendado: Tener instalado [Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)

en la rama master está el ejemplo que usa persistencia en Memoria
 
en la rama [SqlServerDatabase](https://github.com/centerax/ort-da1-veterinaria-con-ef/tree/SqlServerDatabase) están los cambios que hice para poder persistir Mascotas y Clientes en la base de datos SQLServer.
 
se pueden clonar el repositorio, cambiarse a la rama SqlServerDatabase correrlo y verificar en su Microsoft SQL Server Management Studio que se les crea una base datos con el nombre **veterinaria** y con las tablas Mascotas y Clientes (y otra de Migrations)
 

para ver los cambios que hice (básicamente: instalar EF mediante Package Manager Console y modificar el código para que use SqlServer) para pasar de guardar en Memoria a DB pueden entrar acá https://github.com/centerax/ort-da1-veterinaria-con-ef/compare/SqlServerDatabase y ver las modificaciones a archivos existentes y nuevos archivos.

