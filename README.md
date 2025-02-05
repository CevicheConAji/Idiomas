# Proyecto de Evaluación de Niveles de Idiomas en .NET MAUI

## Descripción
Esta aplicación ha sido desarrollada en .NET MAUI para evaluar los niveles de idiomas en tres lenguas diferentes. Permite la interacción del usuario con una interfaz gráfica intuitiva y el uso de triggers para gestionar la activación de botones y cambios visuales dinámicos.

## Características
- **Evaluación de Idiomas:** Permite ingresar niveles en tres idiomas.
- **Uso de Property Triggers:** Cambia los colores de los `Entry` según el valor introducido.
- **Data Triggers:** Habilita botones en función del número de idiomas con nivel avanzado.
- **Interfaz Adaptable:** Uso de `Grid` y `StackLayout` para una distribución eficiente de la UI.
- **Mensajes Dinámicos:** Muestra información basada en la entrada del usuario.

## Instalación
Para ejecutar el proyecto, sigue estos pasos:

1. Clona este repositorio:
   ```bash
   git clone https://github.com/CevicheConAji/Idiomas.git
   ```
2. Abre el proyecto en Visual Studio 2022 con soporte para .NET MAUI.
3. Compila y ejecuta la aplicación en un emulador o dispositivo físico.

## Uso
1. Ingresa los niveles de idioma en las casillas respectivas.
2. Presiona "Comprobar" para evaluar el nivel avanzado.
3. Según la cantidad de idiomas avanzados, se activará uno de los botones.
4. Usa el botón "Ver Créditos" para ver información del desarrollador.

## Estructura del Proyecto
```
📂 Idiomas-Master
 ├── 📁 Platforms/          # Código específico de cada plataforma
 ├── 📁 Views/              # Páginas principales de la app
 ├── 📁 Components/         # Componentes reutilizables
 ├── 📁 Models/             # Modelos de datos
 ├── 📄 MainPage.xaml       # Interfaz principal de la app
 ├── 📄 MainPage.xaml.cs    # Lógica de interacción
 ├── 📄 App.xaml            # Configuración global
 ├── 📄 AppShell.xaml       # Estructura de navegación
 ├── 📄 README.md           # Documentación del proyecto
```

## Tecnologías Utilizadas
- .NET MAUI
- C#
- XAML

## Autor
Desarrollado por **Piero Zavala Chira**.

## Licencia
Este proyecto se distribuye bajo la licencia MIT. Puedes usarlo y modificarlo libremente.

