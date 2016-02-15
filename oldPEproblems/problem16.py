'''
problem 16
2^15 = 32768 and the sum of its digits is 26.
What is the sum of the digits of the number 2^1000?
'''


    
def main():
    
    exponent = 1000
    powerSum = 1
    for exp in range(exponent):
        powerSum = powerSum * 2
        
    print powerSum
    
    numDigits = len(str(powerSum))
    digits = [None]*numDigits
    for n in range(numDigits - 1, -1, -1):
        digits[n] = powerSum % 10
        powerSum = (powerSum - digits[n]) / 10
        
    answer = 0
    for dig in xrange(len(digits)):
        answer += digits[dig]
    
    print answer
    
    raw_input()
    
main()