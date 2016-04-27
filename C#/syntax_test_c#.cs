// SYNTAX TEST "Packages/C#/C#.sublime-syntax"

class X
// ^ storage.modifier
{

	[Usage("Foo bar")]
	// ^ meta.method.attribute
    void Run([Usage("help text")] int x, int y)
    // ^ storage.type
    //    ^ entity.name.function
    //           ^ meta.method.attribute
    //                 ^ string.quoted.double
    //                             ^ storage.type
    //                                    ^ storage.type
    {
    }
}

string verbatim = @"This is a test "" of a verbatim string literal - C:\User"
//                ^^ string.quoted.double.literal punctuation.definition.string.begin
//                                 ^^ constant.character.escape
//                                                                     ^ string.quoted.double.literal - constant
//                                                                          ^ string.quoted.double.literal punctuation.definition.string.end

class A
{
   public A(int x, int y) {}
   // ^ storage.modifier
   //     ^ entity.name.function
}
class B: A
{
   public B(int x, int y): base(x + y, x - y) {}
   //                       ^ meta.method.base-call
   //                              ^ meta.method.base-call
}


public class GenericList<T>
{
    void Add(T input) { }
}
class TestGenericList
{
    private class ExampleClass { }
    static void Main()
    {
        GenericList<int> list1 = new GenericList<int>();
        //           ^ storage.type

        GenericList<string> list2 = new GenericList<string>();

        GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
    }
}

public partial class Employee
//     ^ storage.modifier
//                   ^ entity.name.type.class
{
    public void DoWork()
    {
    }
}
