using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePolishCount
{
	class ReversePolishCount
	{
		static public double Calculate(string input)
		{
			string output = GetExpression(input);
			double result = Counting(output);
			return result;
		}
		static private string GetExpression(string input)
		{
			string output = string.Empty;
			Stack<char> operStack = new Stack<char>();
			for (int i = 0; i < input.Length; i++)
			{
				if (IsDelimeter(input[i]))
					continue;
				if (Char.IsDigit(input[i]))
				{
					while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
					{
						output += input[i];
						i++;

						if (i == input.Length) break;
					}

					output += " ";
					i--;
				}

				if (IsOperator(input[i]))
				{
					if (input[i] == '(')
						operStack.Push(input[i]);
					else if (input[i] == ')')
					{
						char s = operStack.Pop();

						while (s != '(')
						{
							output += s.ToString() + ' ';
							s = operStack.Pop();
						}
					}
					else
					{
						if (operStack.Count > 0)
						{
							if (GetPriority(input[i]) <= GetPriority(operStack.Peek()))
							{
								output += operStack.Pop().ToString() + " ";
							}
						}
						operStack.Push(char.Parse(input[i].ToString()));

					}
				}
			}
			while (operStack.Count > 0)
			{
				output += operStack.Pop() + " ";
			}
			return output;
		}
		static private double Counting(string input)
		{
			double result = 0;
			Stack<double> tmp = new Stack<double>();
			for (int i = 0; i < input.Length; i++)
			{
				if (Char.IsDigit(input[i]))
				{
					string a = string.Empty;

					while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
					{
						a += input[i];
						i++;
						if (i == input.Length) break;
					}
					tmp.Push(double.Parse(a));
					i--;
				}
				else if (IsOperator(input[i]))
				{
					double a = tmp.Pop();
					double b = tmp.Pop();
					switch (input[i])
					{
						case '+': result = b + a; break;
						case '-': result = b - a; break;
						case '*': result = b * a; break;
						case '/': result = b / a; break;
						case '^': result = double.Parse(Math.Pow(double.Parse(b.ToString()), double.Parse(a.ToString())).ToString()); break;
					}
					tmp.Push(result);
				}
			}
			return tmp.Peek();
		}
		static private bool IsDelimeter(char c)
		{
			if ((" =".IndexOf(c) != -1))
				return true;
			return false;
		}
		static private bool IsOperator(char с)
		{
			if (("+-/*^()".IndexOf(с) != -1))
				return true;
			return false;
		}
		static private byte GetPriority(char s)
		{
			switch (s)
			{
				case '(': return 0;
				case ')': return 1;
				case '+': return 2;
				case '-': return 3;
				case '*': return 4;
				case '/': return 4;
				case '^': return 5;
				default: return 6;
			}
		}
	}
}

