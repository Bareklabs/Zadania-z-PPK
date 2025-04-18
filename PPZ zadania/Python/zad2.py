
wyborSkali = input("Witam w programie zmiany skali temperatury\n"
                   "Proszę podać jaką skale chczesz zamienić : C – Celsjusz na Fahrenheit, F – Fahrenheit na Celsjusz: ").upper()

temp = float(input("Proszę podać wartość temperatury : "))

if wyborSkali == "C" :
    f = temp * 1.8 + 32
    print(f"Temperatura to {f}f")
elif wyborSkali == "F" :
    c = (temp - 32) * 1.8
    print(f"Temperatura to {c}C")
else:
    print("Podano błędną skale")