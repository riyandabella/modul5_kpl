public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] + " yang disimpan pada" +
                "waktu " + inputDates[i]);
        }
    }
}
public class PemrosesData
{
    public void DapatkanNilaiTerbesar<T>(T a, T b, T c)
    {
        dynamic nomor1;
        dynamic nomor2;
        dynamic nomor3;
        dynamic terbesar;
        nomor1 = a; nomor2 = b; nomor3 = c;

        terbesar = nomor1;

        if (nomor1 > nomor2 && nomor1 > nomor3)
        {
            terbesar = nomor1;
        }
        else if (nomor2 > nomor1 && nomor2 > nomor3)
        {
            terbesar = nomor2;
        } else if (nomor3 > nomor1 && nomor3 > nomor2)
        {
            terbesar = nomor3;
        }

        Console.WriteLine("nilai terbesar adalah : " + terbesar);
    }
}

public class Program
{
    public static void Main()
    {
    
        PemrosesData data = new PemrosesData();
        data.DapatkanNilaiTerbesar(10.0, 30.0, 22.0);
        
        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.addNewData(10.0);
        data.addNewData(30.0);
        data.addNewData(22.0);
        data.PrintAllData();
    }
}