# ✈️ TurismoAPP .NET WebApi -Blazor Web and AppHost Aspire Container

## 📋 Descripción
TurismoApp es una aplicación API en .NET que permite gestionar información relacionada con servicios de Turismo. 
Esta aplicación está construida utilizando las últimas tecnologías de .NET y sigue las mejores prácticas de desarrollo (Clean Code , Solid)



## 🚀 Características
- Gestión de vuelos
- Busqueda de Vuelos
- Reservas de boletos (proximamente)
- Seguimiento de horarios (proximamente)
- Sistema de búsqueda avanzada (proximamente)
- Servicios de Hoteles, Traslados, Excursiones, Restaurantes

## 🛠️ Tecnologías Utilizadas
- .NET 9
- C#
- Entity Framework Core (opcional) (proximamente)
- SQL Server (opcional) (proximamente)

## ⚙️ Requisitos Previos
- .NET 9.0 SDK o superior
- IDE (Visual Studio 2022 recomendado) o VSCode
- SQL Server (opcional, dependiendo de la implementación)

## 🏗️ Estructura del proyecto

Estructura propuesta y explicada para facilitar mantenimiento y escalado en .NET 10:

```
TurismoApp.ApiService/
├── Controllers/  # Controladores API (Vuelos, Hoteles, Excursiones, otros)
├── Domain/Entities              # Entidades del dominio
├── Domain/Interfaces                # Objetos de DTO de datos (proximamente)	
├── Aplication/Services             # Lógica de negocio (servicios)
├── Infraestructure/Repositories/       # Implementaciones concretas (repositorios, DB context)
├── TurismoApp.Tests/	  # Proyecto de pruebas unitarias (proximamente)
├── Program.cs            # Punto de entrada de la aplicación API (Contiene enpoints web minimalistas)
└── TurismoApp.csproj      # Archivo de proyecto .NET

TurismoAppi.AppHost/                # Proyecto de hosting Aspire
TurismoApp.ServicesDefaults/    # Proyecto de servicios compartidos (logging, métricas, etc.)

```

## 📥 Instalación
1. Clona el repositorio:
```powershell
git clone [url-del-repositorio]
```

2. Navega al directorio del proyecto:
```powershell
cd TurismoAPi
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
<img src="/assets/images/jsonvuelos.png" alt="TurismoAPi" width="480" />	

---
## USO DE ASPIRE COMO CONTENEDOR y METRICAS
 Uso AspireHost para despliegue no Docker


---
## Notas prácticas:
- Mantener `Controllers` delgados: inyectar servicios desde `Services`.
- `Infrastructure` contiene implementaciones concretas (ej. `VuelosRepository`) y su registro en DI.
- `Models` = dominio; `DTOs` = contratos públicos (evita exponer entidades internamente).
- `TurismoApp.Tests` debe cubrir servicios y controladores con dependencias mockeadas.
- Añade `docs/architecture.md` con diagramas y convenciones de naming para onboardings.


## 📄 Licencia
Este proyecto está bajo la Licencia GPL v3 - ver el archivo [LICENSE](LICENSE) para más detalles.

## ✍️ Autor
Gian Amais (Websysnet Systems) 

## 📞 Contacto

## 🆕 Nuevas features (histórico por fecha)

Sección para documentar cambios importantes por fecha. Añade una entrada por cada hito o release para mantener un historial claro.


- **23-11-2025**
	- **Proyecto `TurismoApp.ApiService`**:
		- Se añadieron 10 hoteles de ejemplo en `Infraestructure/Repositories/HotelesRepository.cs` (IDs 1..10) para poblar datos de desarrollo.
		- Se mantuvo la separación entre `Controllers` y `Aplication/Services` y se reforzaron las interfaces para facilitar pruebas unitarias.
		- Se creó una versión rápida de la documentación en `README.UPDATED.md` con instrucciones de desarrollo y preview.
	- **Proyecto `TurismoApp.Web`**:
		- Se importaron las **Bootstrap Icons** globalmente en `wwwroot/app.css` para facilitar el uso de iconos en componentes.
		- Se actualizaron iconos en `Components/Layout/NavMenu.razor` (ej.: `bi-building`, `bi-airplane`) y se ajustaron rutas de navegación.
		- Se dejó un ejemplo de listado de hoteles en `Components/HotelesList.razor` que puede conectarse posteriormente a la API.

- **23-11-2026**
	- **Proyecto `TurismoApp.ApiService`**:
		- Se agregaron nuevos servicios relacionados con Hoteles: endpoint `GET /hoteles` con X hoteles predefinidos (IDs: 1..10).
		- Refactor: se aplicaron principios **SOLID** y **Clean Code** en los servicios y repositorios principales.
		- Mejora: nuevas interfaces en `Aplication/Services` para desacoplar lógica de negocio y facilitar pruebas unitarias.
	- **Proyecto `TurismoApp.Web`**:
		- Ajuste en navegación: se actualizaron enlaces del menú (`NavMenu.razor`) para usar rutas canónicas y nuevos iconos.
		- UI: se importaron las **Bootstrap Icons** globalmente en `wwwroot/app.css` para facilitar uso de iconografía en componentes.
		- Mejora estructural: separación de componentes y estilos por carpeta `Components/` y `Layout/` para mejor mantenimiento.

Ejemplo de cómo añadir una nueva entrada:

```
- DD-MM-YYYY
	- Proyecto `TurismoApp.ApiService`:
		- Descripción breve del cambio (endpoints añadidos/actualizados, refactor, dependencias).
	- Proyecto `TurismoApp.Web`:
		- Descripción breve del cambio (UI, navegación, importaciones, componentes añadidos).
```

Mantén esta sección actualizada cada vez que introduzcas cambios visibles o features nuevas para que el equipo y usuarios conozcan la evolución del proyecto.




````````

