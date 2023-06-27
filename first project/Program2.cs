using System;

public partial class Father
{
    public void Welcome(int _Id,string _Name)
    {
        Id = _Id;
        Name = _Name;
        Console.WriteLine("{0} : {1}",_Id,_Name);
    }

}
