using System.Collections;

public class TextFile : File{

    public List<char> rows = new List<char>();
    public List<int> columns = new List<int>();

    public TextFile(string _contents): base(_contents){}

    public override string GetContents(){
        // Getting Text
        return "";
    }

    public override void SetContents(string _contents){
        // Setar o Texto
    }

}
