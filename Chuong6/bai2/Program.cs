using System;
public interface IThietBiDienTu
{
    void TurnOn();
    void TurnOff();
}
public class Quat : IThietBiDienTu
{
    
    public void TurnOn()
    {
        Console.WriteLine("quat dang mo.");
    }
    public void TurnOff()
    {
        Console.WriteLine("quat dang tat.");
    }
}
public class DieuHoa : IThietBiDienTu
{

    public void TurnOn()
    {
        Console.WriteLine("dieu hoa dang mo.");
    }

    public void TurnOff()
    {
        Console.WriteLine("dieu hoa dang tat.");
    }
}
public class TiVi : IThietBiDienTu
{
    public void TurnOn()
    {
        Console.WriteLine("TiVi dang mo.");
    }
    public void TurnOff()
    {
        Console.WriteLine("TiVi dang tat.");
    }

}
class Program
{
    static void Main()
    {
        Quat quat = new Quat();
        quat.TurnOn();
    
        DieuHoa dh = new DieuHoa();
        dh.TurnOff();

        TiVi tv = new TiVi();
        tv.TurnOn();
    }
}
