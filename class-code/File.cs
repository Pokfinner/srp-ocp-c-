public abstract class File{

    string contents {get; set;}

    public File(string _contents){
        contents = _contents;
    }

    public abstract string GetContents();
    public abstract void SetContents(string _contents);

}
