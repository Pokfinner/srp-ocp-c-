using System.Collections;

public class SheetFile : File{

    public List<char> rows = new List<char>();
    public List<int> columns = new List<int>();

    public SheetFile(string _contents): base(_contents){}

    public override string GetContents(){
        // Getting Tables
        return "";
    }

    public override void SetContents(string _contents){
        // Setar as Tables
    }

}
