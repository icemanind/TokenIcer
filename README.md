# TokenIcer
A program for creating a tokenizer in C# or VB.Net

#### Introduction
A tokenizer is a tool in which you feed input into it and your input get's "tokenized" and the tokenizer spits out 
"tokenized" output.

Here is an example. Suppose you have this input:
```
3+2 * (6 + 1)
```
Feeding this input into a tokenizer should produce output like this:
```
{Integer}{Plus}{Integer}{Whitespace}{Asterisk}{Whitespace}{LeftParen}
{Integer}{Whitespace}{Plus}{Whitespace}{Integer}{RightParen}{Newline}
```

#### So what exactly does TokenIcer do?
TokenIcer is a code generator. It generates a class file in either C# or VB.Net and this class file can be added to your 
solution. This class file will take an input string and parse it down to tokens. These tokens can then be used by
your main application to pretty much do anything, from building a simple calculator to building your own compiler!

#### Using TokenIcer
After running TokenIcer, you will see four boxes, marked "Input Grammar", "Input Test", "Output", and "Output Tree". 
The first thing you'll want to do is create your input grammar. The input grammar is simply a list of rules that
TokenIcer uses to parse your test input. These rules are simply RegEx expressions, surrounded in quotes, followed by
an identifier used to identify that rule. Here is an example:

```
"[0-9]+" Integer
```

This rule will successfully parse an integer (a whole number without a decimal point). The following rules will
successfully parse an integer or a floating point number:

```
"[0-9]+\.+[0-9]+" Float
"[0-9]+" Integer
```

The order of the rules is important because TokenIcer will try to match the input to the first successful rule. So if
you want to parse `32.76`, TokenIcer will try to match `32.76` to the first rule, `Float`, in this case. Because it is
a floating-point number, TokenIcer will successfully match it and return that Token. If we swap our rules, like this:

```
"[0-9]+" Integer
"[0-9]+\.+[0-9]+" Float
```

TokenIcer will now come to the first rule, `Integer`, and it will try to match `32.76`. Because the `Integer` RegEx rule
matches `32`, TokenIcer will stop and match `32` and return that token. So it is important that the rules appear
in the correct order. More complex rules should be first. There is also a check box for whether tabs and spaces (known
as white space) should be ignored or parsed. 

In the "Input Test" box, you can put a test input in that box to test your grammar rules. Go ahead and put these rules
in the "Input Grammar" box:

```
"[0-9]+\.+[0-9]+" Float
"[0-9]+" Integer
```

and in the "Input Test" box, put `32.76`. Once you have your rules in the "Input Grammar" box and your test input
in the "Input Test" box, click the "Test Grammar" button. Clicking this button will test your input against the rules
you created. In the output box, you should see `{Float}`, indicating that TokenIcer successfully parsed your input
and created a token called `{Float}`. In the "Output Tree" box, you will see a tree view of the token and the value of
the token. Expand the tree and you will see `Float` and under that, you will see the value, `32.76`. If you click on the
"Examples" menu, you can see some more preloaded examples. Your rules can contain any valid .NET Regular Expression.

Once you have your rules created and your input test working, you can click on the "Generate Class" button. Doing this
will bring up a dialog box where you can select your desired output language (C#, VB.Net or F#) and you can choose to
include comments and/or XML comments in the final code. Once you select your options and language, click on "Generate my class"
and a window will popup with your code. You can create a class in your project and include this code.

#### Using The Generated Class
Once you include the class in your project, you can now use it to parse strings. Here is an example of how you can use
the token parser:

```
var parser = new TokenParser { InputString = "32.76 12" };
Token token = parser.GetToken();

while (token != null)
{
      Console.WriteLine($"{token.TokenName} = {token.TokenValue}");
      token = parser.GetToken();
}
```

The first thing you must do after instantiating an instance of the `TokenParser` is to set the `InputString`
property to your input string. Once you do this, you can keep calling the `GetToken()` method to keep getting a
stream of tokens. If there are no more tokens, `GetToken()` will return `null`.

Another feature of TokenIcer is the ability to peek ahead at tokens. Here is an example:
```
var parser = new TokenParser {InputString = "32.76 12 99"};
Token token = parser.GetToken();

while (token != null)
{
      Console.WriteLine($"{token.TokenName} = {token.TokenValue}");
      PeekToken peek = parser.Peek();
      if (peek != null &&
         peek.TokenPeek.TokenName == TokenParser.Tokens.Integer &&
         peek.TokenPeek.TokenValue == "99")
      {
         Console.WriteLine("99 should be next!");
      }
      token = parser.GetToken();
}
```
In this example, `99 should be next!` will be printed out *before* that token is ever pulled from the token stream.
It does this by using the `Peek()` method to peek at the next token in the stream, but does not pull that token
from the queue. If there is no token, `Peek()` returns `null`. `Peek()` has an additional overload that allows you
to call it with a `PeekToken` object. Doing this allows you to peek 2 tokens ahead. You can chain this as much as you
want so that you can peek *n* times ahead in the queue.
