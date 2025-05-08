Genero = input("Informe seu gênero M/F: ")
Tempo_de_Casa = int(input("Digite seu tempo de casa: "))
Salario = float(input("Digite seu salario: "))

if Genero == "M" and Tempo_de_Casa > 15:
    Slr_Total = Salario + (Salario * 0.25)
    print("Seu salário total é de R$", Slr_Total)
elif Genero == "F" and Tempo_de_Casa > 10:
    Slr_Total = Salario + (Salario * 0.30)
    print("Seu salário total é de R$", Slr_Total)
else:
    Slr_Total = Salario + 500
    print("Seu salário total é de R$", Slr_Total)
    
