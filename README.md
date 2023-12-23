# ActualizacionDeProcesos

Actualizacion de procesos es un pequeño software desarrollado con el objetivo de simplificar el control y mantenimiento de informacion sobre procesos judiciales para un asistente administrativo en el campo juridico para un despacho de abogados, estos estan almacenados en un documento de excel y se deben revisar periodicamente teniendo en cuenta ciertos criterios.

Con el objetivo de simplificar el uso de los libros de excel para dicha tarea he desarrollado esta pequeña aplicacion que utiliza la interoperabilidad de C#/Net. Framework 4.7.2 para implementar una interfaz grafica basado en Formularios del mismo framework. 

## Cuenta con las siguientes caracteristicas:
- Cargar los archivos de excel con el formato definido por el despacho de abogados para este fin.
- Agregar nuevos procesos al documento (estos estan separados por hojas en el libro de excel).
- Agregar nuevas novedades del los procesos en un dataGrid el cual permite edicion manual.
- Visualizar todas las hojas del libro de excel y extraer informacion de las casillas relevantes.
- Agregar automaticamente la fecha del dia actual con una nueva novedad por defecto (util para disminuir la cantidad de texto y tiempo requeridos para esta tarea)
- Guardar por separado la informacion perteneciente al proceso y los datos del proceso actual seleccionado.

![screenshot](/screenshot.png)
- [Enlace al Binario](https://github.com/giovani-s/ActualizacionDeProcesos/blob/main/Actualizacion%20de%20Procesos.exe)
- [Descargar Excel de Demostración](https://github.com/giovani-s/ActualizacionDeProcesos/blob/main/Revision%20procesos%20Abogado%202023.xlsx)

## Motivación y Aprendizaje

He desarrollado esta aplicacion para facilitar dicha tarea y optimiazar el tiempo invertido en la misma asi como tambien probar mis conocimientos del lenguaje entorno y herramientas usados para su implementacion.
