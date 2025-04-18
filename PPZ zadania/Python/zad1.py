
operacja = input("Witam w kalkulatorze proszę "
                 "podać co chcesz zrobić, twoje opcje to (+, -, * lub /) : ")

num1 = float(input("Proszę podać pierwszą liczbę : "))
num2 = float(input("Proszę podać drugą liczbę : "))
wynik = float

if operacja == "+":
    wynik = num1 + num2

elif operacja == "-":
    wynik = num1 - num2

elif operacja == "*":
    wynik = num1 * num2

elif operacja == "/":
    if num1 == 0 or num2 == 0:
        print("Nie dzielimy przez zero")
        exit()
    else:
        wynik = num1 / num2

else:
    print("Nieznany operator !")
    exit()

print(f"Wynik to : {wynik}")