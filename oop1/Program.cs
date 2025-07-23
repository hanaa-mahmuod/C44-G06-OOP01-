namespace oop1
{ //what we can write inside a namespace?
    // 1. Classes
    // 2. Interfaces
    // // 3. Enums
    // 4. Structs
    // 5. Delegates
    //access modifiers allowed in a namespace?
    // 1. public
    // 2. internal(default)
    internal class Program
    {
        //what we can write inside a class?
        // 1. Fields or attributes(member variable)
        // 2. Properties(full prop,automatic prop,indexer)
        // 3. functions or methods(constructor,gettter,setter,)
        // 5. Events

        //access modifiers allowed in a class?
        // 1. public
        // 2. private(default)
        // 3. protected
        //4..internal
        // 5. protected internal
        // 6. private protected
        static void Main(string[] args)
        {

            Class1 obj = new Class1();
            // obj.name="Hello World"; cannot access private member 'name' in 'Class1'
        }
    }
}
