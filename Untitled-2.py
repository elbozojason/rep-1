identity = input('write your name,ocupation,age,gender1')
file = open("test.txt","x")
file.close()
file = open("test.txt","w")
file.write(identity)
file.close()
file = open("test.txt","r")
print(file.read())
file.close