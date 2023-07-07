# @FinalTask2
# Терминал оплаты. Реализуйте программу-терминал, в которой можно будет оплачивать различного рода услуги в формате меню. Требования:
# 	- Наличие средств. У пользователя не бесконечные деньги и он не может всё всегда оплачивать;
# 	- Выбор услуги (коммунальные услуги, телефонный оператор, оплата за обучение и т.п);
# 	- После выбора услуги пользователь вводит свои данные (номер телефона или почту, например) и указывает сумму которую хочет внести;
# 	- После оплаты спросите пользователя, хочет ли он чек. И если да, то распечатайте его (не в прямом смысле) в красивом виде. Чек будет хранить данные об оплате услуги;
# 	- Наличие истории. Все сделанные пользователем оплаты должны сохраняться. Пользователь в любое время может посмотреть историю;
# 	- Выход из программы.
#______________________________________________________Functions________________________________________________________
def a1_2():
    a1_2 = (choise, f'{choise_price}AZN', kak_pay)
    for i in a1_2:
        histori_list1.append(i)
    histori_list1.append("--" * 10)
#_________________________________________________check_karta_komunal___________________________________________________
histori_list1 = []
def check_karta_komunal():
    global  balans
    balans -= choise_price
    check = int(input("\n"  
                      "\n"
                      "\nХотите чек?"
                      "\nЕсли \"да\" введите -\"1\" "
                      "\nЕсли \"нет\" введите -\"2\" "
                      "\n--->>> "))
    if check == 1:
        print("\n"
              "\n"
              "\nВаш чек:" 
              "\n"
              f'\nУслуга :                                      {choise}'
              f'\nСколько денег у Вас было на балансе :         {balans + choise_price}AZN'
              f'\nСколько денег Вы потратели :                  {choise_price}AZN'
              f'\nСколько денег у Вас осталось на балансе :     {balans}AZN'
              f'\nКак было оплачено :                           {kak_pay}'
              "")
    elif check == 2:
        pass
    else:
        print("\n"
              "\nError!!! Enter 1 or 2!!!")
    a1_2()

#_________________________________________________check_nalichka_komunal________________________________________________
def check_nalichka_komunal():
    check = int(input("\n"
                      "\n"
                      "\nХотите чек?"
                      "\nЕсли \"да\" введите -\"1\" "
                      "\nЕсли \"нет\" введите -\"2\" "
                      "\n--->>> "))
    print('\n' * 3)
    if check == 1:
        print("Ваш чек:"
              "\n"
              f'\nУслуга :                                      {choise}'
              f'\nСколько денег Вы оплатили :                   {choise_price}AZN'
              f'\nКак было оплачено :                           {kak_pay}'
              "")
    elif check == 2:
        pass
    else:
        print("\n"
              "\nError!!! Enter 1 or 2!!!")
    a1_2()
#__________________________________________________tel_operat___________________________________________________________
def tel_operat():
    global balans
    choise_price = float(input("\n"
                               "\nВыберите сумму которую хотите оплатить --->>> "))
    phone_number = input("Введите номер телефона : ")
    kak_pay = int(input("\n"
                        "\nВыбрать оплачивать наличными или карточкой ?"
                        "\nЕсли карточкой введите : \"1\""
                        "\nЕсли наличными введите : \"2\""
                        "\n--->>> "))
    if kak_pay == 1:
        number_of_kart = int(input("\nВведите номер карты --->>> "))
        if number_of_kart == 1234:
            if choise_price <= balans:
                kak_pay = "Карточкой"
                balans -= choise_price
                check = int(input("\n"  
                                  "\nХотите чек?"
                                  "\nЕсли \"да\" введите - \"1\" "
                                  "\nЕсли \"нет\" введите - \"2\" "
                                  "\n--->>>"))
                print('\n' * 3)
                if check == 1:
                    print("Ваш чек:"  
                          "\n"
                          f'\nУслуга :                                      {choise}'
                          f'\nНомер телефона                                {phone_number}'
                          f'\nТелефонный оператор:                          {a}'
                          f'\nСколько денег у Вас было на балансе:          {balans + choise_price} AZN'
                          f'\nСколько денег Вы потратели :                  {choise_price} AZN'
                          f'\nСколько денег у Вас осталось на балансе:      {balans} AZN'
                          f'\nКак было оплачено :                           {kak_pay}'
                          "")
                elif check == 2:
                    pass
                else:
                    print("\n"
                          "\nError!!! Enter 1 or 2 !!!")
            else:
                print("Недостаточно средств на балансе!!! ")
        else:
            print("Неверно введён номер карточки !")
        def a3_4():
            a3_4 = (choise, phone_number, a, f'{choise_price}AZN', kak_pay)
            for i in a3_4:
                histori_list1.append(i)
            histori_list1.append("--" * 10)
        a3_4()
    elif kak_pay == 2:
        print(f"\nОплатите {choise_price} AZN в терминал")
        kak_pay = "Наличными"
        check = int(input("\n"
                          "\nХотите чек?"
                          "\nЕсли \"да\" введите - \"1\" "
                          "\nЕсли \"нет\" введите - \"2\" "
                          "\n--->>>"))
        print('\n' * 3)
        if check == 1:
            print("Ваш чек:"  
                  "\n"
                  f'\nУслуга :                                      {choise}'
                  f'\nНомер телефона                                {phone_number}'
                  f'\nТелефонный оператор:                          {a}'
                  f'\nСколько денег Вы оплатили :                   {choise_price} AZN'
                  f'\nКак было оплачено :                           {kak_pay}'
                  "")
            a3_4 = (choise, phone_number, a, f'{choise_price}AZN', kak_pay)
            for i in a3_4:
                histori_list1.append(i)
            histori_list1.append("--" * 10)

        elif check == 2:
            pass
        else:
            print("\n"
                  "\nError!!! Enter 1 or 2 !!!")
        a3_4 = (choise, phone_number, a, f'{choise_price}AZN', kak_pay)
        for i in a3_4:
            histori_list1.append(i)
        histori_list1.append("--" * 10)

    else:
        print("\n"
              "\nОшибка!!! Введите 1 или 2 !!!")
#_______________________________________________________chek_unik_______________________________________________________
def chek_unik():
    global balans
    name = input("\nВведите имя : ")
    lastname = input("\nВведите Фамилию : ")
    E_mail = input("\nВведите свой e-mail адрес : ")
    choise_price = float(input("\n"
                               "\nВыберите сумму которую хотите оплатить --->>> "))

    kak_pay = int(input("\n"
                        "\nВыбрать оплачивать наличными или карточкой ?"
                        "\nЕсли карточкой введите : \"1\""
                        "\nЕсли наличными введите : \"2\""
                        "\n--->>> "))
    if kak_pay == 1:
        number_of_kart = int(input("\nВведите номер карты --->>> "))
        if number_of_kart == 1234:
            if choise_price <= balans:
                kak_pay = "Карточкой"
                balans -= choise_price
                check = int(input("\n"
                                  "\nХотите чек?"
                                  "\nЕсли \"да\" введите -\'1\' "
                                  "\nЕсли \"нет\" введите -\'2\' "
                                  "\n--->>>"))
                print('\n' * 3)
                if check == 1:
                    print("Ваш чек:"
                          "\n"
                          f'\nУслуга :                                      {choise}'
                          f'\nИмя:                                          {name}'
                          f'\nФамилие:                                      {lastname}'
                          f'\nE-mail адрес:                                 {E_mail}'
                          f'\nНазвание обучительного центра:                {a1}'
                          f'\nСколько денег у Вас было на балансе:          {balans + choise_price} AZN'
                          f'\nСколько денег Вы потратели :                  {choise_price} AZN'
                          f'\nСколько денег у Вас осталось на балансе:      {balans} AZN'
                          f'\nКак было оплачено :                           {kak_pay}'
                          "")
                elif check == 2:
                    pass
                else:
                    print("\n"
                          "\nError!!! Enter 1 or 2 !")

                a5_6 = (choise, name, lastname, E_mail, a1, f'{choise_price}AZN', kak_pay)
                for i in a5_6:
                    histori_list1.append(i)
                histori_list1.append("--" * 10)

            else:
                print("Недостаточно средств на балансе!!! ")
        else:
            print("Неверно указан номер карты !")
    elif kak_pay == 2:
        print(f"\nОплатите {choise_price} AZN в терминал ")
        kak_pay = "Наличными"
        check = int(input("\n"
                          "\nХотите чек?"
                          "\nЕсли \"да\" введите -\'1\' "
                          "\nЕсли \"нет\" введите -\'2\' "
                          "\n--->>>"))
        print('\n' * 3)
        if check == 1:
            print("Ваш чек:"
                  "\n"
                  f'\nУслуга :                                      {choise}'
                  f'\nИмя:                                          {name}'
                  f'\nФамилие:                                      {lastname}'
                  f'\nE-mail адрес:                                 {E_mail}'
                  f'\nНазвание обучительного центра:                {a1}'
                  f'\nСколько денег Вы оплатили :                   {choise_price} AZN'
                  f'\nКак было оплачено :                           {kak_pay}'
                  "")
        elif check == 2:
            pass
        else:
            print("\n"
                  "\nError!!! Enter 1 or 2 !")
        a5_6 = (choise, name, lastname, E_mail, a1, f'{choise_price}AZN', kak_pay)
        for i in a5_6:
            histori_list1.append(i)
        histori_list1.append("--" * 10)

    else:
        print("\n"
              "\nОшибка!!! Введите 1 или 2 !!!")
########################################################################################################################
balans = 1000
while True:
    try:
        choise = int(input("\n_________________________________________________________________________________________"     
                  "\n"f"                          Сколько денег у Вас на карте :    {balans} AZN"       
                  "\n1.Коммунальные услуги"
                  "\n2.Телефонный оператор"
                  "\n3.Оплата за обучение"
                  "\n4.История платежей"
                  "\n5.Выйти"
                  "\n"
                  "\nВыберите услугу --->>> "))
    #____________________________________________ 1. Коммунальные услуги________________________________________________
        if choise == 1:
            choise = "Коммунальные услуги"
            choise_price = float(input("\n"
                                       "\nВыберите сумму которую хотите оплатить --->>> "))
            kak_pay = int(input("\n"
                                "\nВыбрать оплачивать наличными или карточкой ?"
                                "\nЕсли карточкой введите : \"1\""
                                "\nЕсли наличными введите : \"2\""
                                "\n--->>> "))
            if kak_pay == 1:
                number_of_kart = int(input("\nВведите номер карты --->>>"))
                if number_of_kart == 1234:
                    if balans >= choise_price:
                        kak_pay = "Карточкой"
                        check_karta_komunal()
                    else:
                        print("Недостаточно средств на балансе!!! ")
                else:
                    print("Неверно указан номер карты !")
            elif kak_pay == 2:
                print(f"\nОплатите {choise_price} AZN в терминал")
                kak_pay = "Наличными"
                check_nalichka_komunal()
            else:
                print("\n"
                      "\nОшибка! Введите 1 или 2 !!!")
    # _____________________________________________2. Телефонный оператор______________________________________________
        elif choise == 2:
            choise = "Телефонный оператор"
            choise_operator = int(input("Выберите оператор :"                                                   
                                        "\nbakcell - \"1\" "
                                        "\nNar - \"2\" "
                                        "\nAzercell - \"3\" "
                                        "\n --->>> "))
            if choise_operator == 1:
                a = "bakcell"
                tel_operat()
            elif choise_operator == 2:
                a = "Nar"
                tel_operat()
            elif choise_operator == 3:
                a = "Azercell"
                tel_operat()
            else:
                print("\n"
                      "\nОшибка! Введите 1,2 или 3 !!! ")
    #_______________________________________________ 3.Оплата за обучение_______________________________________________
        elif choise == 3:
            choise = "Оплата за обучение"
            choise_operator = int(input("Выберите университет/колледж/курсы :"                                 
                                        "\nUNEC             --->>> \"1\" "
                                        "\nADNSU            --->>> \"2\" "
                                        "\nADA              --->>> \"3\" "
                                        "\nMGU              --->>> \"4\" "
                                        "\nStep IT          --->>> \"5\" "
                                        "\nEnglish course   --->>> \"6\" "
                                        "\nFrench course    --->>> \"7\" "
                                        "\n --->>> "))
            if choise_operator == 1:
                a1 = "UNEC"
                chek_unik()
            elif choise_operator == 2:
                a1 = "ADNSU"
                chek_unik()
            elif choise_operator == 3:
                a1 = "ADA"
                chek_unik()
            elif choise_operator == 4:
                a1 = "MGU"
                chek_unik()
            elif choise_operator == 5:
                a1 = "Step IT"
                chek_unik()
            elif choise_operator == 6:
                a1 = "English course"
                chek_unik()
            elif choise_operator == 7:
                a1 = "French course"
                chek_unik()
            else:
                print("\n"
                      "\nОшибка!!! Введите 1,2,3,4,5,6 или 7 !!! ")
    #_____________________________________________________ 4. History___________________________________________________
        elif choise == 4:
            print("\n"
                  "----------------------->>>История платежей<<<-----------------------")
            if histori_list1 == []:
                print("Платежей не осуществлялось")
            else:
                for i in histori_list1:
                    print(i)
    #______________________________________________________ 5. Выйти____________________________________________________
        elif choise == 5:
            print("Exit !!!")
            break
        else:
            print("Error !!! Choose 1 to 4 !!!")
    except ValueError as message:
        print("Введите численное значение !!! ",message)