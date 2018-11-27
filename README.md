# FlagsApp SDK

Este proyecto consta en el desarollo de un SDK en el lenguaje C#, este SDK le permitira a cualquier desarollador consultar por la 
operacion de evaluacion de Flags.

## Introduccion

Este SDK cuenta de las siguientes caracteristicas:
- La respuesta por parte del servidor de FlagsApp es almacenada en cache durante 2 minutos.
- En caso de que existan tiempos de demoras mayor a 1000 ms al evaluacion retorna falso.
- En caso de que el servidor de FlagsApp se encuentre fuera de servicio la evluacion retorna falso.

### Pre requesitios

Para poder utilizar el SDK es necesario desarollar la aplicacion en cualquier lenguaje .NET Framework

### Estructura

- **EvaluateSdk: **
Corresponde al codigo fuente del SDK desarollado por el equipo.

-  **Sdk: **
Dentro de esta carpeta se encuentran las <kbd>.dll</kbd> que pueden ser utilizadas para usar nuestro SDK en cualquier proyecto .NET

- **SdkInterface: **
Se encuentra el codigo fuente de la interfaz de escritorio desarollada por el equipo para poder probar el SDK.

- **Test Interface: **
Se encuentran los binarios correspondientes para poder ejecutar la interfaz de escritorio y probar el SDK desarollado.

## Librerias

Para el desarollo del SDK se utilizaron las siguientes librerias de .NET

- System.Net.Cache
- System.Net
- System.Threading
- System.IO

## Versionado

Nosotros utilizamos [Github](http://github.com/) para el control de version. Se opto por utilizar 2 branches principales.

- <kbd>master</kbd> - Branch que contiene el codigo en produccion.
- <kbd>develop</kbd> - Branch que se utiliza para desarollar y introducir nuevas features

- <kbd>feature/**name**</kbd> - Branch que se utiliza para el desarollo de cada feature en el sistema.

## Autores

* Matias Crizul
* Santiago Marchisio

