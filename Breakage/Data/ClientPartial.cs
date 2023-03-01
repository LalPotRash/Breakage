namespace Breakage.Data
{
    public partial class Client
    {
        public override string ToString()
        {
            return $"{LastName} {FirstName} {Patronymic}";
        }
    }
}
