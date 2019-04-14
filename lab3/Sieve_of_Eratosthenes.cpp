//https://prog-cpp.ru/eratosfen/
#include <iostream>
using namespace std;
int main()
{
	long long n;
	cout << "n= ";
	cin >> n;
	long long *a = new long long[n + 1];
	for (long long i = 0; i < n + 1; i++)
		a[i] = i;
	for (long long p = 2; p < n + 1; p++)
	{
		if (a[p] != 0)
		{
			cout << a[p] << endl;
			for (long long j = p * p; j < n + 1; j += p)
				a[j] = 0;
		}
	}
	cin.get(); cin.get();
}
