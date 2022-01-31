/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE FUNCTION BLOCK

*/
using System;
using System.Linq;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
         
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();
            
            

            //Question 2:
            string[] bulls_string1 = new string[]{"Marshall", "Student","Center"};
            string[] bulls_string2 = new string[]{"MarshallStudent", "Center"};
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1,2,3 },{ 1,2,3},{ 1, 2, 3 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 3, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch ='o';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

        }

        /* 
        <summary>
        Given a string s, remove the vowels 'a', 'e', 'i', 'o', and 'u' from it, and return the new string.

        Example 1:
        Input: s = "MumaCollegeofBusiness"
        Output: "MmCllgfBsnss"

        Example 2:
        Input: s = "aeiou"
        Output: ""

        Constraints:
        •	0 <= s.length <= 10000
        s consists of uppercase and lowercase letters
        </summary>
        */

        private static string RemoveVowels(string s)
        {
            try
            {
                // write your code here
                //this if block checks the constraint that the length should be between 0 and 10000
                if(s.Length > 10000)
                {
                    throw new Exception("String length should be between 0 and 10000");
                }


                //this block checks for the constraint that the elements should be only
                // lower case or upper case
                Char[] abc = s.ToCharArray();
                for(int i=0; i<s.Length; i++)
                {
                    if(Char.IsUpper(abc[i]) || Char.IsLower(abc[i]))
                    {

                    }
                    else
                    {
                        throw new Exception("Only lower and uppercase are allowed");
                    }
                }

                //In this for loop block we traverse through the loop
                String final_string ="";
                for (int i = 0; i < s.Length; i++)
                {
                    //this if statement checks every character againt the 5 vowels
                    //if they match, we leave them and proceed to the next element
                    //and if they dont match, we add them to the final answer
                    if (s[i] == 'a' || s[i] == 'A' || s[i] == 'e' || s[i] == 'E' || s[i] == 'i' || s[i] == 'I' || s[i] == 'o' || s[i] == 'O' || s[i] == 'u' || s[i] == 'U')
                    {

                    }
                    else
                    {
                        final_string = final_string + s[i];
                    }
                }
                return final_string;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /* 
        <summary>
       Given two string arrays word1 and word2, return true if the two arrays represent the same string, and false otherwise.
       A string is represented by an array if the array elements concatenated in order forms the string.
       Example 1:
       Input: : bulls_string1 = ["Marshall", "Student",”Center”], : bulls_string2 = ["MarshallStudent ", "Center"]
       Output: true
       Explanation:
       word1 represents string "marshall" + "student" + “center” -> "MarshallStudentCenter "
       word2 represents string "MarshallStudent" + "Center" -> "MarshallStudentCenter"
       The strings are the same, so return true.
       Example 2:
       Input: word1 = ["Zimmerman", "School", ”of Advertising”, ”and Mass Communications”], word2 = ["Muma", “College”,"of”, “Business"]
       Output: false

       Example 3:
       Input: word1  = ["University", "of", "SouthFlorida"], word2 = ["UniversityofSouthFlorida"]
       Output: true
       </summary>
       */

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            try
            {
                //So the logic is to add up the string array elements
                //and create 2 strings.
                //and then we compare those 2 and if they are equal we return true
                //else we return false
                String s1 = "";
                String s2 = "";
                // write your code here.

                //in these two for loopblocks we will add the two string arrays and form
                // two strings
                for (int i = 0;i<bulls_string1.Length;i++)
                {
                    s1 = s1 + bulls_string1[i]; 

                }
                for (int i = 0; i < bulls_string2.Length; i++)
                {
                    s2 = s2 + bulls_string2[i];

                }

                //in this if block, we are comparing these arrays
                if (s1 == s2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        /*
        <summary> 
       You are given an integer array bull_bucks. The unique elements of an array are the elements that appear exactly once in the array.
       Return the sum of all the unique elements of nums.
       Example 1:
       Input: bull_bucks = [1,2,3,2]
       Output: 4
       Explanation: The unique elements are [1,3], and the sum is 4.
       Example 2:
       Input: bull_bucks = [1,1,1,1,1]
       Output: 0
       Explanation: There are no unique elements, and the sum is 0.
       Example 3:
       Input: bull_bucks = [1,2,3,4,5]
       Output: 15
       Explanation: The unique elements are [1,2,3,4,5], and the sum is 15.
       </summary>
        */

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                //in this if block we are checking that the bull bucks length should be
                //less than 100, otherwise we throw an exception
                if(bull_bucks.Length > 100)
                {
                    throw new Exception();
                    
                }

                //in this for block, we will check the unique elements and add them up for the
                //result
                int sum_uniq = 0;
                for(int i = 0;i<bull_bucks.Length;i++)
                {
                    //this if block checks that the bull bucks should have value
                    //between 0 and 100
                    if(bull_bucks[i] > 100 || bull_bucks[i] < 0) 
                    {
                        throw new Exception();
                        
                    }
                    int count = 0;

                    for(int j = 0;j<bull_bucks.Length;j++)
                    {
                           
                        if(bull_bucks[i] == bull_bucks[j] && i!=j)// this compares every element
                                                                  // of the string to other elements
                                                                  // to check if they are unique
                        {
                            count++; // if count is 0 that means the element is unique
                                     // if it matches with another element the count will increase
                        }
                    }
                    if (count == 0) 
                    {
                        sum_uniq = sum_uniq + bull_bucks[i];
                    }
                }
                return sum_uniq;

            }
            catch (Exception)
            {
                Console.WriteLine("THe length should not be greater than 100");
                throw;
            }
        }
        /*

        <summary>
       Given a square matrix bulls_grid, return the sum of the matrix diagonals.
       Only include the sum of all the elements on the primary diagonal and all the elements on the secondary diagonal that are not part of the primary diagonal.

       Example 1:
       Input: bulls_grid = [[1,2,3],[4,5,6], [7,8,9]]
       Output: 25
       Explanation: Diagonals sum: 1 + 5 + 9 + 3 + 7 = 25
       Notice that element mat[1][1] = 5 is counted only once.
       Example 2:
       Input: bulls_grid = [[1,1,1,1], [1,1,1,1],[1,1,1,1], [1,1,1,1]]
       Output: 8
       Example 3:
       Input: bulls_grid = [[5]]
       Output: 5
       </summary>

        */

        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                // write your code here.
                //this if block checks the symmetric array condition
                // which says that dimensions of the 2d array should be the same
                if(bulls_grid.GetLength(0) != bulls_grid.GetLength(1))
                {
                    throw new Exception("Array is not symmetric");
                }
                int len = bulls_grid.GetLength(0);

                int primary_diag = 0;
                int secondary_diag = 0;

                //this is to traverse the 2d array
                for(int i = 0; i < len; i++)
                {
                    for(int j = 0; j < len; j++)
                    {
                        if(i == j)//this condition goes through the main diagonal elements
                        {
                            primary_diag = primary_diag + bulls_grid[i, j]; 
                        }
                        if((i+j) == (len - 1) && i!=j)// this condition leaves out the main diagonal element
                        {
                            secondary_diag = secondary_diag + bulls_grid[i, j];
                        }

                    }

                }


                return primary_diag + secondary_diag;
            }
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            }

        }



        /*
         
        <summary>
        Given a string bulls_string  and an integer array indices of the same length.
        The string bulls_string  will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        Return the shuffled string.

        Example 3:
        Input: bulls_string  = "aiohn", indices = [3,1,4,2,0]
        Output: "nihao"

        */

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                //this if block checks that both array lengths should be the same
                if(bulls_string.Length != indices.Length)
                {
                    throw new Exception("Length of both arrays is not the same");
                }
                //indice length should be between 1 and less than 100
                if(bulls_string.Length > 100 || indices.Length == 0)
                {
                    throw new Exception("The length of string should be between 1 and 100");
                }

                
                char[] ans = bulls_string.ToCharArray();
                // write your code here.
                for(int i = 0; i < ans.Length;i++)
                {
                    //we are checking for upper case exception as we need lower case only
                    if(Char.IsUpper(ans[i]))
                    {
                        throw new Exception("PLease enter lower case only");
                    }

                    //if indice value is greater than the length of array, or it is less than 0, then we throw and exception
                    if(indices[i] >= indices.Length || indices[i] < 0)
                    {
                        throw new Exception("Indices values need to be between 0 and " + indices.Length);
                    }

                }

                //this method checks that all elements in the index should be unique
                var collectionWithDistinctElements = indices.Distinct().ToArray();
                if(indices != collectionWithDistinctElements)
                {
                    throw new Exception("Indices are not unique");
                }
                for (int i = 0; i < indices.Length; i++)
                {
                    ans[indices[i]] = bulls_string[i];
                }
                
                string ans_str = new String(ans);
                return ans_str;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        /*
         <summary>
        Given a 0-indexed string bulls_string   and a character ch, reverse the segment of word that starts at index 0 and ends at the index of the first occurrence of ch (inclusive). If the character ch does not exist in word, do nothing.
        For example, if word = "abcdefd" and ch = "d", then you should reverse the segment that starts at 0 and ends at 3 (inclusive). The resulting string will be "dcbaefd".
        Return the resulting string.

        Example 1:
        Input: bulls_string   = "mumacollegeofbusiness", ch = "c"
        Output: "camumollegeofbusiness"
        Explanation: The first occurrence of "c" is at index 4. 
        Reverse the part of word from 0 to 4 (inclusive), the resulting string is "camumollegeofbusiness".

        Example 2:
        Input: bulls_string   = "xyxzxe", ch = "z"
        Output: "zxyxxe"
        Explanation: The first and only occurrence of "z" is at index 3.
        Reverse the part of word from 0 to 3 (inclusive), the resulting string is "zxyxxe".

        Example 3:
        Input: bulls_string   = "zimmermanschoolofadvertising", ch = "x"
        Output: "zimmermanschoolofadvertising"
        Explanation: "x" does not exist in word.
        You should not do any reverse operation, the resulting string is "zimmermanschoolofadvertising".
        */

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            {
                //this is to throw an exception if length of bull_string is greater than 250
                if(bulls_string6.Length > 250)
                {
                    throw new Exception("The length of string should be less than 250");
                }
                //this is to check that every character should be a lower case
                if(Char.IsUpper(ch))
                {
                    throw new Exception("The character is upper case, please enter lower case");
                }
                Char[] abc = bulls_string6.ToCharArray();
                for(int i = 0;i < bulls_string6.Length;i++)
                {

                    if(Char.IsUpper(abc[i]))
                    {
                        throw new Exception("PLease enter lower case letters only");
                    }
                }
                int ind = 0;
                String sub1;//these two strings are gonna store the two final substrings
                String sub2;
                char[] ans = bulls_string6.ToCharArray();

                //in this loop we will find the element we want to find the position of
                for(int i = 0; i < bulls_string6.Length;i++)
                {
                    if(ans[i] == ch)
                    {
                        ind = i;//the index of ch in the array is stored in ind
                        break;
                    }
                }
                
                
                if(ind == 0)// if we dont find the ch in array, we dont do anything and just
                            //return the array
                {
                    
                    return bulls_string6;
                }
                else  // otherwise we will make a substring from 0 to the ind position and then reverse it
                {
                    sub1 = bulls_string6.Substring(0, ind+1);
                    char[] subz = sub1.ToCharArray();
                    Array.Reverse(subz); // this reverses the substring
                    sub2 = bulls_string6.Substring(ind+1);
                    return new String(subz) + sub2; //this adds the reversed substring to the rest of the
                                                    // substring and returns it
                    
                }

                
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

/* The problems in the assignment are really good for practicing basic concepts.
 * It took me 2 hours to do the problems and were moderately challenging.
 * I would like to improve and optimize these more the next time.
 * Making corner cases seems like a hastle but is very important for real life production programs.
 * In which we need to handle the user errors in a meaningful way.
 * Looking forward to more challenging and interesting assignments!

*/