#include<iostream>
#include<ctime>
using namespace std;

/*
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
Find the sum of all the primes below two million.
*/

inline bool IsPrime(long number) {
	if (number == 3)
		return true;
	else if (number % 3 == 0)
		return false;

	for (long k = 5; k*k <= number; k += 2)
	{
		if (number % k == 0)
		{
			return false;
		}
	}

	return true;
}

int main() 
{
	std::clock_t start;
	double duration;
	start = std::clock();

	long long sum = 2;
	long limit = 2000000;

	for (long check = 3; check < limit; check += 2)
	{
		if (IsPrime(check))
		{
			sum += check;
		}
	}

	cout << "answer is " << sum << endl;
	duration = (std::clock() - start) / (double)CLOCKS_PER_SEC;
	std::cout << "printf: " << duration << endl;
	cin.get();
	return 0;
}

