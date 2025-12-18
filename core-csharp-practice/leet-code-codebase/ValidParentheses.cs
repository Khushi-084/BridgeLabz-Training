class ValidParentheses
{
    public static bool IsValid(string str)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in str)
        {
            // Push opening brackets
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            // Handle closing brackets
            else
            {
                if (stack.Count == 0)
                    return false;
                char top = stack.Pop();
                if ((ch == ')' && top != '(') ||
                    (ch == '}' && top != '{') ||
                    (ch == ']' && top != '['))
                {
                    return false;
                }
            }
        }
    
        return stack.Count == 0;
    }
}

   