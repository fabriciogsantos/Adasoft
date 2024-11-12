![logo Adasoft](/docs/img/BITA.png "Logo Adasoft")  
# Adasoft

## Parse de fichero Contabil
El proyecto está hecho con un servicio del tipo Worker.
Para probar en entorno windows :
- Debe ejecutar los migrations para crear y llenar la base de datos: Update-database
- Hacer el publish en una carpeta
- Ejecutar en un terminal de comando el ParseContabil.Worker.exe
- Las carpetas de input de ficheros y output están pre configuradas en el fichero appsettings.json para la misma carpeta del desplegué del proyecto.

Definición:
Un Worker es un tipo de proceso o subproceso que realiza tareas en segundo plano, lo mismo que hacía windows service pero ahora en multiplataforma.

contributor:
[Fabricio Santos](https://www.linkedin.com/in/fabriciogomessantos/)