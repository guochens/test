// vector.cpp : �������̨Ӧ�ó������ڵ㡣
//

#include "stdafx.h"
#include <vector>
#include <iostream>
using namespace std;
int main()
{
	vector<int>rating(5);
	int n = 0,i=0;
	cin >> n;
	cout << n << endl;
	vector<double> scores(n);
	rating[0] = 9;
	for (i = 0; i < n; i++)
	{
		cout << scores[i] << endl;
	}
    return 0;
}

