Algoritmo Sum_Rest_Multi_Div
	Definir num1, num2, opc Como Enteros
	Escribir "==== Calculadora Básica ===="
	
	Escribir Sin Saltar "Digite el primer número entero: "
	Leer num1
	Escribir Sin Saltar "Digite el segundo número entero: "
	Leer num2
	
	Escribir "********************"
	Escribir "* MENÚ DE OPCIONES *"
	Escribir "********************"
	Escribir "Suma - 1"
	Escribir "Resta - 2"
	Escribir "Multiplicación - 3"
	Escribir "División - 4"
	
	Escribir Sin Saltar "Digite la opción: "
	Leer opc
	
	Segun opc Hacer
		1:
			Escribir "La suma es: ",(num1 + num2)
		2:
			Escribir "La resta es: ",(num1 - num2)
		3:
			Escribir "La multiplicación es: ",(num1 * num2)
		4:
			Escribir "La división es: ",(num1 / num2)
		De Otro Modo:
			Escribir "ERROR AL OPERAR LOS NÚMEROS"
	Fin Segun
FinAlgoritmo
