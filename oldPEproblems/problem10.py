
#The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
#Find the sum of all the primes below two million.
import time

# this function will check if a number is prime
def IsPrime(number):
    if number == 3:
        return True
    elif number % 3 == 0:
        return False
    
    for subNumber in xrange(5, int(number**0.5) + 1, 2):    
        if number % subNumber == 0:
            return False
    '''
    subNumber = 5    
    while subNumber*subNumber <= number:
        if number % subNumber == 0:
            return False
        subNumber += 2
    '''

    return True
# function is over

sum = 2
limit = 2000000

start = time.time()
for numberToCheck in range(3, limit, 2):
    if IsPrime(numberToCheck):
        sum = sum + numberToCheck
    

print "Answer is %s" % sum
print time.time() - start