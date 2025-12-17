class Fibonacci {
    public int fib(int n) {
        return fibo(n);
    }
    int sum = 0;
    private int fibo(int num){
        if(num == 0 || num == 1){
            return num;
        }
        sum = fibo(num-1) + fibo(num-2);
        return sum;
    
    }
}