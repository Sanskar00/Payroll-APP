namespace Payroll_APP.TEST;
using ConsoleApplication1;
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Programmer_SetsProperties()
    {
        //Arrange
        int basic_salary = 45000;
        string emp_name = "Sabskar";

        //Act
   

        Programmer prog = new(emp_name, basic_salary);

        //Assert
        Assert.AreNotEqual(" ",prog.basic_salary);
        Assert.AreNotEqual(0, prog.emp_name);
    }

    [TestMethod]
    public void Manager_SetsProperties()
    {
        //Arrange
        int basic_salary = 45000;
        string emp_name = "Sabskar";

        //Act


        Manager man = new(emp_name, basic_salary);

        //Assert
        Assert.AreNotEqual(" ", man.basic_salary);
        Assert.AreNotEqual(0, man.emp_name);
    }

    [TestMethod]
    public void SalesExec_SetsProperties()
    {
        //Arrange
        int basic_salary = 45000;
        string emp_name = "Sabskar";

        //Act
        SalesExec salesexec = new(emp_name, basic_salary);


        //Assert
        Assert.AreNotEqual(" ", salesexec.basic_salary);
        Assert.AreNotEqual(0, salesexec.emp_name);
    }
}
