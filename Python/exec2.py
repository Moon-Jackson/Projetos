indice = float(input("Informe o indice de pouicão dessa empresa:"))

if indice <= 0.3:
    print("As idustrias do grupo 1 serão intimadas a suspenderem suas ativdades")
elif indice <= 0.4:
     print("As idustrias do grupo 1 e 2 serão intimadas a suspenderem suas ativdades")
else:
      print("Todas as industrias serão intimadas a suspenderem suas ativdades")