# Descripción del Proyecto

Este proyecto implementa el Principio de Responsabilidad Única (SRP) en una aplicación de consola en C#. La aplicación se centra en la gestión y visualización de información de usuarios.

## Estructura del Proyecto

El proyecto está organizado en los siguientes componentes:

- **SRP.Entidades**: Contiene la clase `Usuario`, que es responsable de almacenar los datos del usuario.
- **SRP.Presentacion**: Contiene la clase `UsuarioConsola`, que es responsable de mostrar información del usuario en la consola.

## Clases Principales

### Usuario

La clase `Usuario` tiene la responsabilidad de almacenar los datos del usuario. Sus propiedades incluyen:

- `Id`: Identificador único del usuario.
- `Nombre`: Nombre del usuario.
- `Email`: Correo electrónico del usuario.
- `Contrasena`: Contraseña del usuario.

### UsuarioConsola

La clase `UsuarioConsola` tiene la responsabilidad de mostrar información del usuario en la consola. Sus métodos incluyen:

- `MostrarUsuario(Usuario usuario)`: Muestra la información del usuario en la consola.
- `MostrarMensajeError(string mensaje)`: Muestra un mensaje de error en la consola.
- `MostrarMensajeExito(string mensaje)`: Muestra un mensaje de éxito en la consola.

## Requisitos

- **C#**: Versión 7.3
- **.NET Framework**: 4.8

## Ejecución

Para ejecutar la aplicación, compile el proyecto y ejecute el archivo ejecutable generado. La aplicación mostrará información del usuario y mensajes en la consola según las acciones realizadas.

## Principio de Responsabilidad Única (SRP)

Este proyecto sigue el Principio de Responsabilidad Única, asegurando que cada clase tiene una única responsabilidad bien definida. Esto mejora la mantenibilidad y la claridad del código.

