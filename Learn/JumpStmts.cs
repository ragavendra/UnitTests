namespace UnitTests.Learn;

public class JumpStmts
{
    private static int _refProp;

    public static int RefProp { get => _refProp; set => _refProp = value; }

    public ref int MethodReturnRef(int num0, int num1)
    {
        RefProp = num0 + num1;
        return ref _refProp;
    }

    public string ReturnChoice(int ch)
    {
        string str;
        switch(ch)
        {
            case 1: str = "one";
                    break;

            case 2: str = "two";
                    break;

            case 12: 
                    // goto case 1;
                    str = "onetwo";
                    break;

            case -1:
                    str = "Unknown choice!";
                    break;

            default: goto case -1; 
        }

        return str;
    }
}
