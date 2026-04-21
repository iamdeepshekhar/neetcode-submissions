public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        for(int i=0;i<s.Length;i++)
        {
            if (s[i] == '(' || s[i] == '{' || s[i] == '[')
            {
                stack.Push(s[i]);
            }
            else //Whenever the closing bracket comes, we need to pop
            {
                if(stack.Count == 0)//Stack is empty
                {
                    return false;
                }
                //Check if the last item in stack is the complementary element to the current traversed element from string s
                if(stack.Peek() == '(' && s[i] == ')' ||
                   stack.Peek() == '{' && s[i] == '}' ||
                   stack.Peek() == '[' && s[i] == ']')
                {
                    char poppedItem = stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }
        return (stack.Count == 0);
    }
    }

