namespace SpaceGame
{
    public class Item
    {
        public string name;
        public decimal cost;
        private string v1;
        private double v2;

        public Item(string name, decimal cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public Item(string v1, double v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}