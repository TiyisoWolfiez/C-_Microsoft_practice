string msg = "Find what is (inside the parentheses)";

int openingPosition = msg.IndexOf('(');
int closingPosition = msg.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(msg.Substring(openingPosition, length));
