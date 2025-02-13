from test.felinos import felinos

def main():
    # Crear una instancia de la clase Felino
    leon = Felino(
        especie="Panthera leo",
        edad=5,
        habitat="Sabana",
        dieta="Carnívoro",
        peso=190,
        estado="Salvaje",
        tamaño="Grande",
        velocidad_maxima=80,
        color_pelaje="Amarillo",
        nombre_cientifico="Panthera leo"
    )

    # Imprimir algunos atributos para verificar que funcionan
    print(f"Especie: {leon.especie}")
    print(f"Edad: {leon.edad}")
    print(f"Hábitat: {leon.habitat}")
    print(f"Dieta: {leon.dieta}")
    print(f"Peso: {leon.peso} kg")
    print(f"Estado: {leon.estado}")
    print(f"Tamaño: {leon.tamaño}")
    print(f"Velocidad máxima: {leon.velocidad_maxima} km/h")
    print(f"Color de pelaje: {leon.color_pelaje}")
    print(f"Nombre científico: {leon.nombre_cientifico}")

if __name__ == "__main__":
    main()

