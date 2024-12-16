public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that might not be initialized
        int value = MyProperty; // This line might throw a NullReferenceException if MyProperty is not set
    }
}