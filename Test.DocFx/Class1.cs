namespace Test.DocFx;

/// <summary>
/// Class 1 description
/// </summary>
public class Class1
{
    /// <summary>
    /// A public property
    /// </summary>
    public string Prop1 { get; init; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="prop1"></param>
    public Class1(string prop1)
    {
        this.Prop1 = prop1;
    }
}