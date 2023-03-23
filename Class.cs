public class Iban
{
    private const string COUNTRY_CODE = "NO";
    private const string CHECKSUM = "00";
    private const string NATIONAL_CHECK = "7";
    public string bankCode;
    public string accountNumber;
    
    public string BuildIban()
    {
        string ibanCode = $"{COUNTRY_CODE}{CHECKSUM}{bankCode}{accountNumber}{NATIONAL_CHECK}";
        return ibanCode;
    }
    private bool CheckIfCorrectInput(string stringToCheck)
    {
        for (int i = 0; i < stringToCheck.Length; i++)
        {
            if (!Char.IsDigit(stringToCheck[i]))
            {
                return false;
            }
        }
        return true;
    }
    public Iban(string bankNumber, string accNumber)
    {
        if (!CheckIfCorrectInput(bankNumber)) {throw new ArgumentException("Your Bank Number contains a Letter. Please try again");}
        else if (bankNumber.Length > 4) {throw new ArgumentException("Your Bank Number is too long. Please try again!"); } 
        bankCode = bankNumber;
        if (!CheckIfCorrectInput(accNumber)) {throw new ArgumentException("Your Account Number contains a Letter. Please try again");}
        else if (accNumber.Length > 6) {throw new ArgumentException("Your Account Number is too long. Please try again!"); }
        accountNumber = accNumber;
    }
} 