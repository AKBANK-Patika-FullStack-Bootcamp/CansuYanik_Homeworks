using System;
using System.Collections.Generic;
using System.Linq;

class MainClass {

  public static List <List <int>> res = new List<List <int>>();
  public static List <int> subset = new List<int>();

  public static void subsets(List<int> A, int index)
  {
      List<int> x = new List<int>();
      for(int i = 0; i < subset.Count; i++){
        x.Add(subset[i]);
      }

      res.Add(x);
      //Console.WriteLine(subset.Count);
      for (int i = index; i < A.Count; i++) {
          subset.Add(A[i]);
          subsets(A, i + 1);
          subset.RemoveAt(subset.Count - 1);
          
      }
      return;
  }

  public static string PlusMinus(int num) {

    string ans = "";

    //split digits into array
    List <int> digits = new List<int>();

    while(num > 0){
      digits.Add(num % 10);
      num = num / 10;
    }
    digits.Reverse();
    //digits.ForEach(Console.WriteLine);
    
    double half = (digits.Sum())/2.0; 

    if(half != (digits.Sum())/2){
      return "not possible";
    }

    subsets(digits, 0);
    
    List <int> nums = new List<int>();
    int size=0;

    for(int i = 0; i < res.Count; i++){
      for(int j = 0; j < res[i].Count; j++){
        if(res[i].Sum() == half && res[i].Count >= size && res[i][0] != digits[0]){
          size = res[i].Count;
          nums = res[i];
        }
      }
    }
	
	if(nums.Count == 0){
      return "not possible";
    }
    
    int k = 0;
    for(int i=0; i<digits.Count; i++){
      if(i==0){
        continue;
      }
      else if(k<nums.Count && nums[k] == digits[i]){
          ans = ans + "-";
          k++;
      }
      else{
        ans = ans + "+";
      }

    }
    return ans;
  }

  static void Main() {  
    // keep this function call here
    Console.WriteLine(PlusMinus(Console.ReadLine()));
  } 

}