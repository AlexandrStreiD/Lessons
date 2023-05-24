# Четырехзначное? Пользователь вводит целое число. Выведите YES, если число является четырехзначныи.
n = int(input('Введите число: '))
if (n > 999 and n < 10000) or (n < -999 and n > -10000):
    print('YES')
else:
    print('NO')

n = int(input('Введите число: '))
if n < 0:
    if len(str(n)) == 5:
        print('YES')
    else:
        print('NO')
else:
    if (n > 999 and n < 10000):
        print('YES')
    else:
        print('NO')