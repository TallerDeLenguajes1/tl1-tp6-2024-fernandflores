# Respuestas punto 4
## a
- los string son un tipo referenciado
## b
- \'	Comilla simple
- \"	Comilla doble
- \	Barra diagonal inversa
- \0	Null
- \a	Alerta
- \b	Retroceso
- \f	Avance de página
- \n	Nueva línea
- \r	Retorno de carro
-  \t	Tabulación horizontal
- \v	Tabulación vertical
- \u	Secuencia de escape Unicode (UTF-16)
- \U	Secuencia de escape Unicode (UTF-32)
- \x	Secuencia de escape Unicode similar a "\u" excepto con longitud variable
## c
- al usar @ antes de una cadena de texto, le decimos a c# que vamos a ignorar cualquier secuencia de escape en esa linea de texto ej:
    console.writeline("hola "don pepito\" ") escribiria por terminal: hola "don pepito\" 
- al usar $ sirve para mezclar variables y texto de una manera mas legible y ordenada por ej:
    int num=10
    console.writeline($"el numero es {num} saludos");