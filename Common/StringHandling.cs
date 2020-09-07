using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Common
{
    public class StringHandling
    {
        public string InertSpace(string source)
        {
            string result = string.Empty;
                       

            // Todo Dopisać logikę która obsługuje stringi składające się tylko z dużych liter
            //var regex = new Regex("[A-Z]{1}");
            //MatchCollection matchCollection = regex.Matches(source);
            //bool onlyCapitalLetter = false;

            //if (regex.IsMatch(source))
            //{
            //    onlyCapitalLetter = true;
            //}        
            

            if (source == null || source == "")
            {
                throw new ArgumentNullException("Wartośc nie może być nullem");
            }

          
            if (!string.IsNullOrWhiteSpace(source))
            {

                foreach (var letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            result = result.Trim();
                       
            return result;

        }
    }
}
