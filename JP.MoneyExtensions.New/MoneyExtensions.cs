namespace JP.MoneyExtensions.New;

public static class MoneyExtensions
{
  public static int ToIntValue(this decimal amount)
  {
    if (amount <= 0)
      return 0;

    string amountText = amount
      .ToString("N2")
      .Replace(".", "")
      .Replace(",", "");

    int.TryParse(amountText, out int result);

    return result;    
  }
}
