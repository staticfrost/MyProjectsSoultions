#Guess a number between 1 and 10
#ask the  number until the number is correct
#print "You guessed it right
import random

number = random.randrange(0, 11)

response = -1

while(response != number):
    print ("Please guess the random number: ")
    response = int(input())
    if (response == number):
        print ("That guessed it right!")
        break
    elif (response != number):
        print ("Try again.")

    else:
        "give up"
