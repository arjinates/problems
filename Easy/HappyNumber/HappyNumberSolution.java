import java.util.LinkedList;

class HappyNumberSolution {
    public boolean isHappy(int n) {
        if (n == 1 || n == 7) {
            return true;
        }
        else if (n < 10) {
            return false;
        }

        int sum = 0;

        while(n > 0){
            int digit = n % 10;
            sum += digit * digit;
            n = n / 10;    
        }

        return ishappy(sum);
    }
}