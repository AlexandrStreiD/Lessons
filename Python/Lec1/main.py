n = 1.89
print(n)

n = 'fdfd'
print(n)
n1 = 'fff\'fd"f"d'

n = 5
print(n)
print(n1)
print(type(n))
print(type(n1))

# print(5, 5)
# print(5, 2)
# print(5)

"""
print(5, 5)
print(5, 2)
print(5)
"""

a = 5
b = 5.3
c = 'dfdfd'

print(a,' - ',b, ' - ', c)
print(f"{a} - {b} - {c}")
print("{} - {} - {}".format(a,b,c))
print('Введите А')
a = input()
b =  input('Введите 2 число: ')
print(a)

print (a, ' + ',b, ' = ', a+b)

c=5.55
print(type(c))
c= str(c)
print(c+ '33')
print(type(c))

iter = 2
iter += 3 
iter -= 4
iter *= 5
iter /= 4
iter //= 4
iter %= 5
iter **= 5

a = 1 < 4 and 5 > 2
print(a)
a = 1 == 2
print(a)

a = 1 < 3 < 5 < 10
print(a)

a = 'qwerty'
for i in a:
    print(i)

line = ""
for i in range(5):
    line=""
    for j in range(5):
            line += "*"
    print(line)

text = 'fАВdfg fdg fdsgwer adsf arrt fdfas afg'
print(text.lower())

text = 'СЪешь что нибудь там'
print(text[0])
print(text[1])
print(text[len(text)-1])
print(text[-1])

print(text[:])
print(text[:2])
print(text[len(text)-3:])
print(text[10:])
print(text[2:9])
print(text[2:-11])
print(text[0:len(text):6])
print(text[::6])
text = text[2:9] + text[-5] + text[:2]
print(text)
