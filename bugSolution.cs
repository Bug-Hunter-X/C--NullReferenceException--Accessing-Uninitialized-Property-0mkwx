public class ExampleClass
{
    // Solution 1: Provide a default value
    public int MyProperty { get; set; } = 0; // Initialize with 0

    // Solution 2: Add null checks (if applicable)
    public void MyMethod()
    {
        // Check if MyProperty is initialized before accessing it
        int value = MyProperty; 
    }

    // Solution 3: Initialize in constructor
    public ExampleClass()
    {
        MyProperty = 10; // Initialize in the constructor
    }
}    