using System;
using System.Text;

namespace Csharp_String
{
    class Program
    {
        public static void Main()
        {
            // String name ="Kriti Bhaskar";
            // String doublenum="21.0987";
            // System.Console.WriteLine(name);
            // System.Console.WriteLine(doublenum);

            //char[] ch= {'C','L','I','N','I','S','Y','S'};
            //string company= new string(ch);
            //System.Console.WriteLine(ch);
            //System.Console.WriteLine(company.Length);
            //string companyoldname="sunquest";
            //company=companyoldname;
            //System.Console.WriteLine(company);

            // Methods of String

            //String Name ="CsharpDotNetGithubOOPs";
            //To_Upper
            //System.Console.WriteLine(Name.ToUpper());

            //To_Lower
            //System.Console.WriteLine(Name.ToLower());

            //Substring
            //System.Console.WriteLine(Name.Substring(3));
            //System.Console.WriteLine(Name.Substring(2,7));

            //Replace
            //foreach(char i in Name)
            //System.Console.WriteLine(Name.Replace('O','t'));
            //System.Console.WriteLine(Name.Replace("Net","Scope"));

            //Split
            //with character
            // string[] updated=Name.Split('e');
            //with word
            // string[] updated=Name.Split("Dot");
            //  foreach(string word in updated)
            //  System.Console.WriteLine(word);


            //Trim
            // string trimmed =Name.Trim();
            // System.Console.WriteLine(trimmed);

            //ToCharArray
            //char[] spaces ={'s','p','a','c','e','s'};
            // char[] characters =Name.ToCharArray();
            // System.Console.WriteLine("Characters : ");
            // foreach(char ch in Name)
            // System.Console.Write(ch+" ");

            //Join
            // string[] words= new string[]{"how","are","you"};
            // string greet=string.Join("-",words);
            // System.Console.WriteLine(greet);

            //equals
            // string userInput= Console.ReadLine();
            // string match="hello";
            // bool ans = userInput.Equals(match);
            // System.Console.WriteLine(ans);

            //Starts with
            // bool sw = Name.StartsWith("C");
            // System.Console.WriteLine(sw);

            //Ends With
            // bool ew=Name.EndsWith('s');
            // System.Console.WriteLine(ew);

            //Contains
            // bool con=Name.Contains("Net");
            // System.Console.WriteLine(con);

            //Indexof
            //char
            //int indexofg=Name.IndexOf("G");
            //System.Console.WriteLine(indexofg);
            //word
            //int indexofnet =Name.IndexOf("Net");
            //System.Console.WriteLine(indexofnet);

            //LastIndexof
            // int inx=Name.LastIndexOf("O");
            // System.Console.WriteLine(inx);

            //Check null or Spaces.
            // string user =Console.ReadLine();
            // //bool nullcheck=string.IsNullOrEmpty(user);
            // //System.Console.WriteLine(nullcheck);
            // bool whitespace=string.IsNullOrWhiteSpace(user);
            // System.Console.WriteLine(whitespace);

            //Format
            // string subject="CyberSecurity",dept="IT";
            // string message = string.Format("{0} is a subject of 7th sem in {1} ",subject,dept);
            // System.Console.WriteLine(message);

            //Insert
            // string newname =Name.Insert(6,"ASPdotnet");
            // System.Console.WriteLine(newname);

            //Remove
            // string remname = Name.Remove(1,5);
            // System.Console.WriteLine(remname);


            //-------------------------------STRINGBUILDER---------------------

                String drink1 = "Tea";
                String drink2= "boba tea";
                string drink3="coffee";
                StringBuilder drinks = new StringBuilder(25);
                drinks.Append(drink1);
                drinks.Append(" ");
                drinks.Append("and "+ drink2);
               drinks.Append(" is better than ");
                drinks.Append(drink3);
            // System.Console.WriteLine(drinks);

            // drinks.AppendFormat("{0}---{1}",drink1,drink2);
            // System.Console.WriteLine(drinks);

            // drinks.Clear();
            // System.Console.WriteLine("New string is :" + drinks);

            //System.Console.WriteLine(drinks.Capacity);

            //Methods

            //append
            // StringBuilder sb = new StringBuilder("Ram");
            // sb.Append(", Mohit");
            // sb.Append(", Sam");
            // Console.WriteLine(sb);

            //Insert,Remove,Replace
            // StringBuilder sb = new StringBuilder("Welcome Clinisys");
            // sb.Insert(8, "to ");
            // Console.WriteLine(sb);
            // sb.Remove(8, 3);
            // System.Console.WriteLine(sb);
            // sb.Replace("Clinisys", "C#");
            // Console.WriteLine(sb);

            System.Console.WriteLine(drinks.ToString());




























        }
    }

}
