public class PrimeNumberChecker
{
  public static bool isPrime(int n)
  {
    if(n == 2 || n == 3)
      return true;
    if(n % 2 == 0 || n % 3 ==0|| n == 5 || n == 1)
      return false;
    int limit = (int)System.Math.Ceiling(  System.Math.Sqrt(n));
    for(int i = 6; i < limit; i+=6)
      if(n % (i + 1) == 0|| n%(i - 1) == 0)
        return false;
    return true;
  }

  public static void Main(string[] args)
  {
    System.Console.WriteLine(isPrime(541));
  }
}

/*
Resources:
https://stackoverflow.com/questions/15743192/check-if-number-is-prime-number
https://www.youtube.com/watch?v=5liC14kBrQ4
https://mae.ufl.edu/~uhk/sixnplusone.pdf
 
*/
