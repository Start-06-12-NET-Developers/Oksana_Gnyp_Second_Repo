namespace Lesson10
{
    public class MyClass
    {
        public static T FactoryMethod<T>(T parameter)
        {
            object instance = parameter;
            return (T)instance; 
        }
    }
}
