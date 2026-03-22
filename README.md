InventarioTec API - Sistema de Gestión

Este proyecto es una Web API desarrollada con .NET 8 y C# para la gestión de inventarios. Se enfoca en una arquitectura limpia separando la lógica de negocio de la exposición de servicios.

Estructura del Proyecto El sistema está organizado siguiendo el patrón de arquitectura en capas para facilitar el mantenimiento:

Contract: Definición de interfaces para los servicios de negocio. Service: Lógica principal de la aplicación y procesamiento de datos. Dtos: Objetos de transferencia de datos con validaciones integradas. Controllers: Endpoints de la API documentados con Swagger para pruebas. Persistence: Manejo de datos mediante Entity Framework Core y SQL Server.

Tecnologías Utilizadas Lenguaje: C# Framework: ASP.NET Core 8 ORM: Entity Framework Core Documentación: Swagger UI
