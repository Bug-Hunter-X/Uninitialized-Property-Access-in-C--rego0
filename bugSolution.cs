public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize MyProperty before accessing it
        MyProperty = 10; 
        int value = MyProperty; // Now MyProperty is initialized
    }
}