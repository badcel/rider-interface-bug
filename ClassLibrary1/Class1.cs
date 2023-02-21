namespace ClassLibrary1;

public interface IMyInterface
{
    string Value { get; }
}

public abstract class BaseClass<T>
{
    public T Value { get; }

    protected BaseClass(T value)
    {
        Value = value;
    }
}

//No warning with "dotnet build". Rider reports for "IMyInterface":
//Nullablility of return type does not match implicitly implemented member
//'string ClassLibrary1.IMyInterface.Vlaue.get' (possibly because of
//nullability attributes)
public class MyClass : BaseClass<string>, IMyInterface
{
    public MyClass(string value) : base(value)
    {
    }
}