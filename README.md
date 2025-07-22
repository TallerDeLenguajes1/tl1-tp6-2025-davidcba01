[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

¿string es un tipo por valor o por referencia?
Es un tipo por referencia pero inmutable. Cada vez que se modifica, se crea una nueva cadena.

¿Qué secuencias de escape tiene el tipo string?
Algunas comunes:
\n → salto de línea
\t → tabulación
\\ → barra invertida
\" → comillas dobles
\' → comillas simples
\r → retorno de carro

¿Qué sucede cuando se usa @ y $ antes de una cadena?
@ → cadena verbatim: ignora los caracteres de escape (ej: rutas).
Ejemplo: @"C:\Carpeta\Archivo.txt"
$ → cadena interpolada: permite insertar variables.
Ejemplo: $"Hola {nombre}"
Se pueden combinar: $@"Hola {nombre}, estás en C:\Proyectos\"