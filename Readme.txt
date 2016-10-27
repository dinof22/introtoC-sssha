

Classes

Let’s say that variables are boxes and functions are machines. Within this analogy, Classes are the factory that houses the machines and the boxes. A class should be named the same thing as the script that it is in.  classes are a tool in object oriented programing. The goal of object oriented programing is to dedicate different main tasks to a single script. As such a class should be dedicated to a single script and also therefore a single task. You can have multiple constructors and multiple instances of constructors within the same class. For example, if you have an ammo class, You can use a different constructor to use your gun when it is loaded with different types of bullets. This can still be within the same class. It is just generally a good idea not to group all of your code into one huge class. Classes are a useful organization tool. 


Scope and Access Modifiers

Scope is The area of code in which a variable can be used in. The use of code blocks is generally what defines a variables scope (like code within the {} of a function).  Variables are only within a certain function are said to be local to that function.
 Variables defined in a class (instead of in a function) have an access modifier attributed to them. An access modifier is a word that is placed before a variable that defines whether or not that variable can be accessed from other scripts. When an access modifier is set to the word “Public” that means it can be accessed (and also possibly modified), and “Private” if it can not. In C#, the default access modifier is set to private.


C# vs JS

C# scripts have the class declaration shown. In js the declaration is hidden. In C# you have to declare the TYPE of variable when you create it. Like a string, integer, and others. In js you just use var. JavaScript is considered a loose language, while C# is considered more strict. Functions also must start with the type of variable you will return from the function in C# while in js you just type function. Access modifiers are also handled differently. Js by default has its access modifiers set to public. And in C# an access modifier defaults to private.


conventions and syntax

Syntax means the structure in which a coding language is typed and conventions are things that you need to know in order to write effective code. One convention is the dot (.) operator. The dot operator is used to drill down deeper into a compound segment of code. Lets say America.usa is what you use to get to the usa when you’ve written code about America. You could drill down deeper by saying America.USA.Utah.Orem if you have coded America have that many sub categories. Another convention is the semicolon ; is used to terminate statements. Another thing you need to do is properly indent your code in order to make it easy to read (even though it is not technically required.  Generally you should indent after curly braces. You can also use comments with // to leave yourself notes. Or also disable code temporarily if you put it between /* and */.


