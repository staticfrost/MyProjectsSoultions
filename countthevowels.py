#count through a sentence and count how many vowels are in it.
sentence = "The quick brown fox jumps over the lazy dog" #11 vowels

count = 0
for letter in sentence:
    if letter == 'a' or letter == 'e' or letter == 'i' or letter == 'o' or letter == 'u' :
        count = count + 1
        print (str (letter)+ ' ' + str (count))
print('The number of vowels is ' + str (count))