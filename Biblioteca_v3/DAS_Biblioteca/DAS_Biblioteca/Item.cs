public class Item
{
    public string TextoVisible { get; set; }
    public int ValorInvisible { get; set; }

    public override string ToString()
    {
        return TextoVisible; // Mostrar solo el texto visible en el ListBox
    }
}
