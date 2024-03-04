public class FileWriter{

    File file;

    public FileWriter(File _file){
        file = _file;
    }

    public void WriteLine(string content){
        file.SetContents(file.GetContents() + $"\n{content}");
    }

    public void Save(){
        Console.WriteLine("A guardar o ficheiro.");
    }

    public void Load(){
        Console.WriteLine("A fazer load ao ficheiro.");
    }

}