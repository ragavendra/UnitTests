using Xunit; 

namespace UnitTests.Learn;

public class JumpStmtsTests
{
    public JumpStmts jumpStmts = new JumpStmts();

    [Fact]
    public void MethodReturnRef()
    {
        var reps = jumpStmts.MethodReturnRef(6, 7);
        Assert.Equal(JumpStmts.RefProp, reps);
    }

    [Fact]
    public void RetCh()
    {
        var res = jumpStmts.ReturnChoice(-1);
        Assert.Equal("Unknown", res);
    }
}
