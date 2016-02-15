'''
problem 6
'''

def sumOfSquares(number):
    sum = 0
    for num in range(1, number + 1):
        sum += num * num
    
    return sum
    
def squareOfSums(number):
    sum = 0
    for num in range(1, number + 1):
        sum += num
    
    square = sum * sum
    return square
    
def main():
    numNaturals = 100
    diff = squareOfSums(numNaturals) - sumOfSquares(numNaturals)
    print diff
    raw_input()
    
main()