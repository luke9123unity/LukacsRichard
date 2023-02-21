//1.feladat
float Clamp(float num, float min, float max){
	if(num<min){
		return min;
	}
	else if(max<num){
		return max;
	}
	else{
		return num;
	}
}
float Clamp01(float num){
	if(num<0){
		return 0;
	}
	else if(1<num){
		return 1;
	}
	else{
		return num;
	}
}

float mynum = 21.5f;
Console.WriteLine(Round(mynum));
float Floor(float number){
	int slicedNumber = (int)number;
	return (float)slicedNumber;
}

float Ceiling(float number){
	int slicedNumber = (int)number;
	if(number-slicedNumber>0){
		return (float)slicedNumber+1;
	}
	else{
		return (float)slicedNumber;
	}
}

float Round(float number){
	int slicedNumber = (int)number;
	if(number-slicedNumber<0.5){
		return (float)slicedNumber;
	}
	else{
		return (float)slicedNumber+1;
	}
}

int findNum = 21;
Console.WriteLine(isPrime(findNum));
bool isPrime(int num){
	for(int i=2;i<=num/2;i++){
		if(num%i==0){
			return false;
		}
	}
	return true;
}

Console.WriteLine(pitaNumber(5, 12, 13));
bool pitaNumber(int a, int b, int c){
	if(a*a+b*b==c*c||a*a+c*c==b*b||c*c+b*b==a*a){
		return true;
	}
	return false;
}

int SumOfNum(int n)
{
	string numString = n.ToString();
	int result = 0;
	for(int i = 0; i < numString.Length; i++)
	{
		result+= int.Parse(numString[i].ToString());
	}
	return result;
}

void nPrime(int n)
{
	int i = 2;
	while(n > 0)
	{
		if (isPrime(i))
		{
			Console.WriteLine(i);
			n--;
		}
		i++;
	}
}

nPrime(100);