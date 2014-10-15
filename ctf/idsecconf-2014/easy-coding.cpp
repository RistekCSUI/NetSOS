#include <algorithm>
#include <bitset>
#include <cstring>
#include <cstdlib>
#include <cstdio>
#include <cmath>
#include <cstring>
#include <iostream>

#define FOR(i,n) for(int i=0;i<n;++i)
#define FORA(i,a,b) for (int i=a;i<=b;++i)
#define DEC(i,n) for (int i=n-1;i>=0;--i)
#define DECA(i,a,b) for (int i=a;i>=b;--i)
#define isi(a, b) memset(a, b, sizeof(a))

const double PI = 2*asin(1);
typedef long long ll;

using namespace std;

long long i,n,tmp;
long long s[3],x,y,z;

int main (){        
	long long find= 89361673409;
	x = 1;
	y = 1;
	z = 1;
	i = 3;
	while(true){
		tmp = (x + y + z)%100000000000;
		x = y; y = z; z = tmp;
		if (tmp == find)
			cout << i <<" "<< tmp<<endl;
		i++;
	}

	//755314025

}
