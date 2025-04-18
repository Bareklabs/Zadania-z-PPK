print("Witam w obliczacu średniej\n")
liczbaOcen = int(input("Proszę podać ile ocen posiada uczeń :"))
suma = 0

for i in range(liczbaOcen):
    ocena = float(input(f"Proszę podać {i + 1} ocene :"))
    suma += ocena

srednia = suma/liczbaOcen
print(f"Średnia ocen to : {srednia}")

if srednia >= 3.0:
    print("Uczeń zdał !")
else:
    print("Uczeń nie zdał !")
