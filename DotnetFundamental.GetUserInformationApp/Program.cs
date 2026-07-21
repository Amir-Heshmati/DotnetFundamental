namespace DotnetFundamental.GetUserInformationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, User!");
            
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("What is your phone number?");
            string phoneNumber = Console.ReadLine();
            if (phoneNumber.StartsWith("+98"))
            {
                phoneNumber = "0" + phoneNumber.Substring(3);
            }
            else if (phoneNumber.StartsWith("98"))
            {
                phoneNumber = "0" + phoneNumber.Substring(2);
            }
            else if (phoneNumber.StartsWith("9"))
            {
                phoneNumber = "0" + phoneNumber;
            }

            Console.WriteLine("What is your national code?");
            string nationalCode = Console.ReadLine();
            
            Console.WriteLine("What is your card number?");
            string cardNumber = Console.ReadLine();

            string bankName = GetBankName(cardNumber.Substring(0, 6));
        }

        static string GetBankName(string prefix)
        {
            switch (prefix)
            {
                case "603799": return "Melli Bank";
                case "589210": return "Sepah Bank";
                case "627648": return "Tosee Saderat Bank";
                case "627961": return "Sanat va Madan Bank";
                case "603770": return "Keshavarzi Bank";
                case "628023": return "Maskan Bank";
                case "627760": return "Post Bank";
                case "502908": return "Tosee Taavon Bank";
                case "627412": return "Eghtesad Novin Bank";
                case "622106": return "Parsian Bank";
                case "502229": return "Pasargad Bank";
                case "627488": return "Karafarin Bank";
                case "621986": return "Saman Bank";
                case "639347": return "Pasargad Bank";
                case "639607": return "Sarmayeh Bank";
                case "627353": return "Tejarat Bank";
                case "589463": return "Refah Bank";
                case "610433": return "Mellat Bank";
                case "627381": return "Ansar Bank";
                case "636214": return "Ayandeh Bank";
                default: return "Unknown Bank";
            }
        }
    }
}
