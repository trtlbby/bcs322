namespace PracticeProblem02;

class Card
{
    private int label;
    private bool face_up;

    public Card(int label)
    {
        this.label = label;
        this.face_up = false;
    }

    public int get_label()
    {
        return label;
    }

    public bool is_face_up()
    {
        return face_up;
    }

    public void flip_up()
    {
        face_up = true;
    }

    public void flip_down()
    {
        face_up = false;
    }
}
