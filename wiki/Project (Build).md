
# 1. Environment (Setup)

PS C_Sharp\AppInicial>
```cs
dotnet new sln -o Aplicacion.App
dotnet new webapp -o FrontEnd
```

PS C_Sharp\AppInicial\Aplicacion.App>
```cs
dotnet new classlib -o Aplicacion.App.Dominio
dotnet new classlib -o Aplicacion.App.Persistencia
dotnet new webapi -o Aplicacion.App.Servicios
dotnet add package Microsoft.EntityFrameworkCore --version 5.0.0
```
<div style='width: max-content;
    padding: 2px 6px;
    border: 1px solid rgba(246, 137, 249);
    border-radius: 4px;
    color: rgba(246, 137, 249);'>
&lt;falta el comando de Aplicacion.App.PresentacionC&gt;
</div>

PS C_Sharp\AppInicial\Aplicacion.App\Aplicacion.App.Persistencia>
```cs
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.0
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.0
dotnet tool install --global dotnet-ef
```

PS C_Sharp\AppInicial\Aplicacion.App\Aplicacion.App.PresentacionC>
```cs
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.0.0
```

# 2. Check Errors (Compile)

PS C_Sharp\AppInicial\Aplicacion.App\Aplicacion.App.Persistencia>
```cs
dotnet build

// Output:

Microsoft (R) Build Engine version 16.7.2+b60ddb6f4 pour .NET
Copyright (C) Microsoft Corporation. Tous droits réservés.

Identification des projets à restaurer...
Tous les projets sont à jour pour la restauration.
Aplicacion.App.Dominio -> C:\..\C_Sharp\AppInicial\Aplicacion.App\Aplicacion.App.Dominio\bin\Debug\netstandard2.1\Aplicacion.App.Dominio.dll
Aplicacion.App.Persistencia -> C:\..\C_Sharp\AppInicial\Aplicacion.App\Aplicacion.App.Persistencia\bin\Debug\netstandard2.1\Aplicacion.App.Persistencia.dll

La génération a réussi.
      0 Avertissement(s)
      0 Erreur(s)

Temps écoulé 00:00:02.49
```

> (opcional)
> 
> PS C_Sharp\AppInicial\Aplicacion.App>


# 3. CRUD (Build)

PS C_Sharp\AppInicial\Aplicacion.App\Aplicacion.App.Persistencia>
```cs
dotnet ef migrations add Inicial --startup-project ..\Aplicacion.App.PresentacionC\
dotnet ef database update --startup-project ..\Aplicacion.App.PresentacionC\
```

# 4. Front-End
## Create Page
PS C_Sharp\AppInicial\FrontEnd\Pages>
```cs
dotnet new page -n TecnMant -na FrontEnd.Pages -o ..\Pages\DatosTecnMant\
```
## Publish
PS C_Sharp\AppInicial\FrontEnd>
```cs
dotnet build


dotnet run

// Output:

info: Microsoft.Hosting.Lifetime[0]
      Now listening on: https://localhost:5001
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: http://localhost:5000 
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Users\mshec\OneDrive\Escritorio\Projects\C_Sharp\AppInicial\FrontEnd
```
# 5. Back-End
## Ejecutar
PS C_Sharp\AppInicial\Aplicacion.App\Aplicacion.App.PresentacionC>

```cs
dotnet build

// Subir datos a DB
dotnet run
```

--------------


> Front End
> 
> Testing:<br>
> Conexion a DB<br>
> Tablas en base a entidades

