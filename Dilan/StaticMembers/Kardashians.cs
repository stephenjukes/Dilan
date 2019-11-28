using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    class Kardashian
    {
        //Static Fields
        public static string surName = "Kardashian";
        public static double netWorth = 15000000.00;
        public static string bank = "Bank of America";
        public static int familyInstagramFollowers = 142984110;
        public static int numOfKids;

        //Instance Fields
        public string name;
        public double weightKG = 4.0;
        public int numOfTVAppearances;
        public int InstagramFollowers;
        public string gender;

        //Constructors
        public Kardashian()
        {
            numOfKids++;
        }

        public Kardashian(string _name)
        {
            gender = GenderConstruct();
            InstagramFollowers = 150000;
            weightKG = 4.0;
            name =_name;
            numOfKids++;
        }

        //Static Methods
        public static string FamilyFollowerUpdate(float familyInstagamFollowers, int numOfKids)
        {
            familyInstagamFollowers = familyInstagamFollowers + (numOfKids * 1000);
            return $"WOW!! Kim kardashian Instagram Account is now up to {familyInstagamFollowers}, can you Believe it? may be due to their {numOfKids} kids";
        }

        //Instance Methods
        public string GenderConstruct()
        {
            Random num = new Random();
            
            int reveal = num.Next(1, 10);
            return reveal % 2 == 0 ? "Girl" : "Boy"; 
        }

        
        public string PublicGenderReveal(string name, int InstagramFollowers, string gender)
        {
            if (gender == null)
                throw new NullReferenceException("No Gender has been Assigned! please use GenderConstruct()");
            familyInstagramFollowers += 15000;
            InstagramFollowers += 10000;
            numOfTVAppearances++;
            return $"OHHH! the new Kardashian Baby has been revealed {name} is a {gender}";
        }
    }
}
