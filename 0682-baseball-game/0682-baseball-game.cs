public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> record = new Stack<int>();

        for(int i = 0; i < operations.Length; i++)
        {
            if (operations[i] == "+")
            {
                int last = record.Pop();
                int previous = record.Peek();
                record.Push(last);
                record.Push(previous + last);
            }
            else if (operations[i] == "D")
            {
                int last = record.Peek();
                record.Push(2 * last);
            }
            else if (operations[i] == "C")
            {
                record.Pop();
            }
            else
            {
                record.Push(int.Parse(operations[i]));
            }
        }

        return record.Sum();
    }
}