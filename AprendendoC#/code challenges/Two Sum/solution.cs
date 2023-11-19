public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        //sei um dicionario para armazenar os elementos e indices
        Dictionary<int, int> numIdenxMap = new Dictionary<int, int>();

        Console.

        for (int i = 0; i < nums.Length; i++)
        {
            //variavel para armazerar o valor que falta para atingir o target
            int complement = target - nums[i];

            if (numIdenxMap.ContainsKey(complement))
            {
                return new int[] { numIdenxMap[complement], i };
            }

            //add o elemento atual e seu indice ao dicionario.
            if (!numIdenxMap.ContainsKey(nums[i]))
            {
                numIdenxMap.Add(nums[i], i);
            }
        }

        // Caso não seja encontrada nenhuma solução
        throw new ArgumentException("No two sum solution");
    }
}