
using System.ComponentModel.Design;

int[] numbers = { 1, 3, 6, 9, 23,50,61};

Console.Write(Search(numbers,10));

bool Search(int[] numbers,int x)
{
   bool result = false;
    if (numbers.Length == 0) { return result; }
    int midIndex = numbers.Length / 2;
int mid = numbers[midIndex];
    int i = 0;
    while (true)
    {
       if (x == mid)       //1//
       {
            result = true;
            break;

       }
       else if (x < mid)   //2//
       {
            int[] numbers2 = new int[midIndex];
            for (int i2 = 0; i2 < numbers2.Length; i2++)
            {
                numbers2[i2] = numbers[i2];
            }
               result = Search(numbers2, x);
                if(result == true) { return result; }
                 if(result == false) { break; }
       }
       else if (x > mid)  //3//
       {
            int v = 0;
            if (numbers.Length % 2 != 0)
            {
                v = numbers.Length - ((Convert.ToInt32(numbers.Length / 2))) - 1;
            }
            else
            {
                v = numbers.Length - ((numbers.Length / 2) + 1);
            }
            int[] numbers3 = new int[v];
            if (numbers3.Length == 0) { break; }
                for (int i3 = midIndex + 1; i3 < numbers.Length; i3++)
                {
                   numbers3[i] = numbers[i3];
                    i++;
                }
           
            result = Search(numbers3, x);
            if (result == true) { return result; }
            if (result == false) { break; }
       }
    }
    return result;
}


