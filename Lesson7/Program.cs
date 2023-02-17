// string NumberRec(int a, int b)
// {
//     if (a<=b) return NumberRec(a + 1, b) + $"{a} ";
//     else return String.Empty;
// }

// Console.WriteLine(NumberRec(1, 10));

// string NumbesrRec(int a, int b)
// {
//     if (a <= b) return $"{a}" +  NumbesrRec(a + 1, b);
//     else return String.Empty;
// }

// Console.WriteLine( NumbesrRec(1, 10));
// void Towers(string with ="1", string on ="3",string some="2",int count =3)
// {
//     if (count>1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count>1) Towers(some, on, with, count - 1);
// }
// Towers();

// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };

// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(right);
//     }
// }
// InOrderTraversal();

void WordSearch()
{
    string[] a_s={ "1","2","3","4","5","6","7","8","9","0"};
      int m = 4, n = 3;
    int count = 1;
    for(int i = 0; i < Math.Pow(m, n); i++)
      {
        string s = "";
        int ii = i;
        for (int j = 0; j < n; j++)
        {
          s = a_s[ii % m]+s;
          ii /= m;
        }

        Console.WriteLine(count + "\t"+s.Replace("1", "a").Replace("2","и").Replace("3","c").Replace("4","в"));
        count++;
    }
      Console.ReadKey();
    }
WordSearch();