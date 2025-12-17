# semana04-simulador-cita-medica
# Sistema de Gestión de Turnos Médicos 

Este proyecto es una aplicación de consola desarrollada en **C#** como parte del curso de **Estructura de Datos**. El sistema modela la relación entre pacientes, médicos y la asignación de turnos médicos utilizando conceptos de Programación Orientada a Objetos (POO).

## Características

El código implementa tres entidades principales con validaciones de inicialización:
* **Paciente:** Almacena información personal y de contacto del usuario.
* **Medico:** Define la identidad y especialidad del profesional de salud.
* **Turno:** Gestiona la relación entre un paciente y un médico en una fecha y hora específica, incluyendo el estado de la cita.

## Tecnologías Utilizadas

* **Lenguaje:** C# 11.0 o superior
* **Framework:** .NET 7.0 / 8.0 (SDK)
* **Herramientas:** .NET CLI

## Estructura del Código

El proyecto utiliza propiedades de tipo `required` para garantizar la integridad de los datos desde la instanciación:



### Clases Principales

1.  **Paciente**: Posee propiedades como `Nombre`, `Apellido`, `Telefono` y `Email`.
2.  **Medico**: Posee `Nombre` y `Especialidad`.
3.  **Turno**: Funciona como la entidad central que vincula los IDs de los objetos anteriores y contiene las referencias de objeto completas.

##  Instalación y Ejecución

Para ejecutar este proyecto de forma local, sigue estos pasos:

1. **Clonar el repositorio:**
   ```bash
   git clone [https://github.com/tu-usuario/nombre-del-repo.git](https://github.com/tu-usuario/nombre-del-repo.git)
