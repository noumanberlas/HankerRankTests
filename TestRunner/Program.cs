// See https://aka.ms/new-console-template for more information


//RunPlusMinusChallenge();

RunMiniMaxSum();

void RunPlusMinusChallenge()
{
    int n = Convert.ToInt32(Console.ReadLine().Trim());

    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

    Result.plusMinus(arr);

    Console.ReadLine();
}

void RunMiniMaxSum()
{
    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

    Result.miniMaxSum(arr);
}
