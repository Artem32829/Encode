internal class SingleKeyPermutation
{
    private int height;
    private int width;
    private object key;
    private string text;

    public SingleKeyPermutation(int height, int width, object key, string text)
    {
        this.height = height;
        this.width = width;
        this.key = key;
        this.text = text;
    }

    internal void Encrypted()
    {
        throw new NotImplementedException();
    }
}