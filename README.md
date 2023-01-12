# PK_Megaprime
We call a number megaprime if it is prime and all its individual digits are prime. Ex: 2, 3, 5, 7, 23, 37 etc

What is a megaprime? A prime number is an integer greater than 1 that has no positive divisors other than 1 and itself. 
We call a number megaprime if it is prime and all its individual digits are prime. For example, 53 is megaprime because it is prime and all its digits (5 and 3) are prime; however, 35 is not megaprime because it is not prime (it's divisible by 5 and 7), and 13 is not megaprime because it has a non-prime digit (1 is not prime). 

Implemented it in 3 ways :

Approach 1: Using direct simple for loops, the traditional way :)
Approach 2: Using Linq, execution is quite fast, have written few testcases as well following TDD approach.
Approach 3: Using Recursion method -> It is something when method calls itself, untill the condition comes to end stage. If condition to end the loop is not written, it will end up calling itself indefinite. writting TDD for recursive case becomes difficult as it makes call to itself again and again and end up with stackoverflow exception.
