public class cak {
    public static long powerMod(long a, long b, long n) {
        long result = 1;
    
        a = a % n;
    
        while (b > 0) {
            if (b % 2 == 1) {
                result = (result * a) % n;
            }
    
            b = b >> 1;
            a = (a * a) % n;
        }
    
        return result;
    }
    
    public static long phi(long n) {
        long result = n;
    
        for (long i = 2; i * i <= n; i++) {
            if (n % i == 0) {
                while (n % i == 0) {
                    n /= i;
                }
    
                result -= result / i;
            }
        }
    
        if (n > 1) {
            result -= result / n;
        }
    
        return result;
    }
    
    public static void main(String[] args) {
        long a = 949, b = 853, n = 2579;
    
        long phi = phi(n);
        long result = powerMod(a, b % phi, n);
        long cak = powerMod(1299, 1 % phi, n);
        
        System.out.println(result);
        System.out.println(cak);
    }
}
