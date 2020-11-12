namespace NemzetiVirusbolt.Desktop.Services
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
