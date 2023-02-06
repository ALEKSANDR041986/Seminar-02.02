// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] nums = new int[8];
// FillRandomNums(nums);
// PrintNums(nums);

// void FillRandomNums(int[] arr)
// {
//  for (int i = 0; i < arr.Length; i++)
//  {
//   arr[i] = new Random().Next(0, 2);
//  }
// }

// void PrintNums(int[] arr)
// {
//  for (int i = 0; i < arr.Length; i++)
//  {
//   Console.Write(arr[i] + " ");
//  }
// }
int[] nums1 = new int[8];
int[] nums2 = new int[7];

FillRandomNums(nums1);
FillRandomNums(nums2);

int[] numsSum = SumNums(nums1, nums2);

PrintNums(nums1);
PrintNums(nums2);
PrintNums(numsSum);

void FillRandomNums(int[] arr)
{
 Random rand = new Random();

 for (int i = 0; i < arr.Length; i++)
 {
  arr[i] = rand.Next(0, 2);
 }
}
int[] SumNums(int[] nums1, int[] nums2)
{
 int[] res = new int[nums1.Length];

 for (int i = 0; i < nums1.Length; i++)
 {
  res[i] = nums1[i] + nums2[i];
 }

 return res;
}

void PrintNums(int[] arr)
{
 for (int i = 0; i < arr.Length; i++)
 {
  Console.Write(arr[i] + " ");
 }

 Console.WriteLine();
}
