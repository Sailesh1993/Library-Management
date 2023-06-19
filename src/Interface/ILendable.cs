namespace LibraryManagement
{
    public interface ILendable
{
    bool CanBorrow {get;}
    void Borrow();
    void Return();
}
}

 