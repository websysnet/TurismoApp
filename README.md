# ✈️ VuelosApi .NET WebApi Aspire

## 📋 Descripción
VuelosAPI es una aplicación API en .NET que permite gestionar información relacionada con vuelos. Esta aplicación está construida utilizando las últimas tecnologías de .NET y sigue las mejores prácticas de desarrollo (Clean Code , Solid)



## 🚀 Características
- Gestión de vuelos
- Busqueda de Vuelos
- Reservas de boletos (proximamente)
- Seguimiento de horarios (proximamente)
- Sistema de búsqueda avanzada (proximamente)

## 🛠️ Tecnologías Utilizadas
- .NET 10
- C#
- Entity Framework Core (opcional) (proximamente)
- SQL Server (opcional) (proximamente)

## ⚙️ Requisitos Previos
- .NET 9.0 SDK o superior
- IDE (Visual Studio 2022 recomendado)
- SQL Server (opcional, dependiendo de la implementación)

## 🏗️ Estructura del proyecto

Estructura propuesta y explicada para facilitar mantenimiento y escalado en .NET 10:

```
VuelosApi/
├── Aplication/Controllers/  # Controladores API 
├── Domain/Entities              # Entidades del dominio
├── DTOs/                 # Objetos de transferencia de datos (proximamente)	
├── Services/             # Lógica de negocio (servicios)
├── Repositories/       # Implementaciones concretas (repositorios, DB context)
├── VuelosApi.Tests/	  # Proyecto de pruebas unitarias (proximamente)
├── Program.cs            # Punto de entrada de la aplicación API (Contiene enpoints web minimalistas)
└── VuelosApi.csproj      # Archivo de proyecto .NET

VuelosApiHost/                # Proyecto de hosting Aspire
VuelosApiServicesDefaults/    # Proyecto de servicios compartidos (logging, métricas, etc.)

```

## 📥 Instalación
1. Clona el repositorio:
```powershell
git clone [url-del-repositorio]
```

2. Navega al directorio del proyecto:
```powershell
cd VuelosApi
```

3. Restaura los paquetes NuGet:
```powershell
dotnet restore
```

4. Ejecuta la aplicación:
```powershell
dotnet run
```

---
## 💡 Uso
1. Clona el repo.
2. Instala el SDK .NET 10.
3. Ejecuta:
	```powershell
	dotnet build
	dotnet run
	```
4. Se abrirá una terminal de opciones.

---
## Probar enpoint vuelos
1. En un navegador o app de probar apis (postman por ejemplo)
2.  Usar https://localhost:7263/vuelos se mostrara un listado de vuelos cargados previamente definidos 
<img src="/assets/images/jsonvuelos.png" alt="VuelosApi" width="480" />	

---
## USO DE ASPIRE COMO CONTENEDOR y METRICAS
 Uso AspireHost para despliegue no Docker


---
## Notas prácticas:
- Mantener `Controllers` delgados: inyectar servicios desde `Services`.
- `Infrastructure` contiene implementaciones concretas (ej. `VuelosRepository`) y su registro en DI.
- `Models` = dominio; `DTOs` = contratos públicos (evita exponer entidades internamente).
- `VuelosApi.Tests` debe cubrir servicios y controladores con dependencias mockeadas.
- Añade `docs/architecture.md` con diagramas y convenciones de naming para onboardings.


## 📄 Licencia
Este proyecto está bajo la Licencia MIT - ver el archivo [LICENSE](LICENSE) para más detalles.

## ✍️ Autor
Gian Amais (Websysnet Systems) 

## 📞 Contacto
- GitHub: [@websysnet](https://github.com/websysnet)

---
⌨️ con ❤️ por Gian Amais



Ejemplo mínimo de registro DI recomendado (Program.cs):

````````

