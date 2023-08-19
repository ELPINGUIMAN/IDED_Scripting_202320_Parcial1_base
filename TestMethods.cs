using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            Stack<int> result = new Stack<int>();
            Stack<int> tempStack = new Stack<int>();

            foreach (int current in sourceStack)
            {
                int nextGreater = -1;

                // While tempStack is not empty and the top element is smaller or equal
                // to the current element, pop elements from tempStack.
                while (tempStack.Count > 0 && tempStack.Peek() <= current)
                {
                    tempStack.Pop();
                }

                // If there's a larger element in tempStack, assign it to nextGreater.
                if (tempStack.Count > 0)
                {
                    nextGreater = tempStack.Peek();
                }

                // Push nextGreater onto the result stack.
                result.Push(nextGreater);

                // Push the current element onto tempStack.
                tempStack.Push(current);
            }

            // Reverse the result stack to match the original order.
            Stack<int> reversedResult = new Stack<int>();
            while (result.Count > 0)
            {
                reversedResult.Push(result.Pop());
            }

            return reversedResult;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();

            foreach (int num in sourceArr)
            {
                EValueType value = EValueType.Prime;

                if (num % 2 == 0)
                {
                    value = EValueType.Two;
                }
                else if (num % 3 == 0)
                {
                    value = EValueType.Three;
                }
                else if (num % 5 == 0)
                {
                    value = EValueType.Five;
                }
                else if (num % 7 == 0)
                {
                    value = EValueType.Seven;
                }

                result[num] = value;
            }

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            int count = 0;

            foreach (var kvp in sourceDict)
            {
                if (kvp.Value == type)
                {
                    count++;
                }
            }

            return count;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }        
    }
}