namespace IrrigationScheduler;

public class scheduleReader{
    public static void read(String filePath){
        try{
            using(StreamReader filerReader = new StreamReader(filePath)){
                /// NEEDS CODE
            }
        } catch{
            string problemReport = $"Filepath '{filePath}' does not exist!";
            Console.WriteLine(problemReport);
        }
    }

}