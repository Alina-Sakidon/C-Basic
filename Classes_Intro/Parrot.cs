namespace Classes_Intro
{
    internal class Parrot
    {
        private string _name;
        private string _ownerName;

        public Parrot(string name, string ownerName)
        {
            _name = name;
            _ownerName = ownerName;
        }

        public Parrot()
        { }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string OwnerName
        {
            get { return _ownerName; }
            set { _ownerName = value; }
        }

        public string SayHello(Parrot parrot)
        {
            return ($"zin, i'am parrot, my name is: {parrot.Name}");
        }
    }
}
