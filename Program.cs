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

public class Program
{
    public static void Main()
    {
        SimpleDataBase<double> data = new SimpleDataBase<double>();
        data.addNewData(10.0);
        data.addNewData(30.0);
        data.addNewData(22.0);
        data.PrintAllData();
        
    }
}