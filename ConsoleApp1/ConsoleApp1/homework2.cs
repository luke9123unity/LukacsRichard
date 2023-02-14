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

bool isPrime(int num){
	for(int i=2;i<Math.Sqrt(num);i++){
		if(num%i==0){
			return true;
		}
	}
	return false;
}

bool pitaNumber(int a, int b, int c){
	if(a*a+b*b==c*c||a*a+c*c==b*b||c*c+b*b==a*a){
		return true;
	}
	return false;
}
