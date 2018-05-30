#include <stdio.h>
#include<time.h>  

int isPrime(int number){
	for(int i = 2; i<number; i++){
		if(number % i ==0){
			return 0;
		}
	}
	return 1;
}

int main(int argc, char ** argv) {  
  clock_t start, end;  
  start=clock();
  for(int i =0; i < 10000; i++){
	  isPrime(i);
  }
  end = clock();
  float diff = ((float)(end - start) / CLOCKS_PER_SEC );
  printf("calculation time: %f\n",diff);
}

