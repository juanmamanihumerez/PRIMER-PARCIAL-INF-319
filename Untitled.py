#!/usr/bin/env python
# coding: utf-8

# In[2]:


def suma(a,b):
    return a+b

def resta(a,b):
    return a-b

def multi(a,b):
    return a*b

def divide(a,b):
    return a/b

n1 = float(input("Ingrese el primer valor")) 
n2 = float(input("Ingrese el segundo valor")) 

print("1. Suma")
print("2. Resta")
print("3. Multiplicacion")
print("4. Division") 

opc = int(input("Ingrese la opcion que desee: "))

if opc == 1 :
    print(n1,"+",n2,"=", suma(n1, n2))
    
if opc == 2 :
    print(n1,"-",n2,"=", resta(n1, n2))

if opc == 3 :
    print(n1,"*",n2,"=", multi(n1, n2))

if opc == 4 :
    print(n1,"/",n2,"=", divide(n1, n2))


# In[ ]:





# In[ ]:




