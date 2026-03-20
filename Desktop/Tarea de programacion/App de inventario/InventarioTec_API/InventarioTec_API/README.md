# InventarioTec_API - CRUD Web API

Este proyecto consiste en una **Web API** desarrollada en **ASP.NET Core 8**, diseñada para gestionar el inventario de una tienda tecnológica. Implementa las operaciones básicas de un CRUD (Create, Read, Update, Delete) utilizando una arquitectura basada en controladores.

Características
- Arquitectura: Web API con Controllers.
- Persistencia de datos: Entity Framework Core (LocalDB).
- Manejo de datos: Implementación de DTOs para la creación de registros.
- Documentación: Swagger UI habilitado para pruebas de endpoints.

Estructura del Proyecto
Cumpliendo con los requerimientos de la asignatura, el proyecto se organiza de la siguiente manera:

- /Controllers: Gestión de endpoints para la entidad Producto.
- /Data: Contexto de la base de datos 
- /DTOs: Objetos de transferencia de datos 
- /Models: Entidad principal 
- appsettings.json: Configuración de la cadena de conexión.

Cómo ejecutar el proyecto
1. Clonar el repositorio.
2. Ejecutar `Update-Database` en la Consola del Administrador de Paquetes para crear la base de datos local.
3. Presionar F5 o el botón de ejecución en Visual Studio para abrir Swagger.
