# Inicializa el contador de números positivos a cero
contador_positivos = 0


# Le damos un valor inicial no negativo para que el ciclo 'while' comience.
numero = 0

print("Contador de Números Positivos ")
print("Ingresa números. El programa terminará cuando ingreses un número negativo.")

# Utiliza un ciclo While para repetir la solicitud de números
while numero >= 0:
    #  Ingrese un número
    try:
        entrada = input("Ingresa un número: ")
        numero = int(entrada)
    except ValueError:
        # Error si el usuario ingresa algo que no es un número entero
        print("--> Error: Por favor, ingresa un número entero válido. <--")
        # Continuar para volver a pedir el número
        continue

    # Verifica si el número es positivo (mayor que 0)
    if numero > 0:
        # Si es positivo, incrementa el contador
        contador_positivos = contador_positivos + 1


# El ciclo termina y se muestra la cantidad final.


print("Número negativo detectado. Programa finalizado.")
print(f"Total de números positivos ingresados: --> {contador_positivos} <--")
print("Gracias por participar")

