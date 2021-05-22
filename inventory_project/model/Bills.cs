namespace inventory_project.model
{
    class Bills
    {
        public int bill_id { get; set; }
        public int product_id { get; set; }
        public float unit_price {get; set; }
        public int quantity { get; set; }
        public float total_price { get; set; }
        public string date { get; set; }
        public string client { get; set; }
        public Bills(int bill_id, int product_id, float unit_price,  int quantity, float total_price, string date, string client)
        {
            this.bill_id = bill_id;
            this.product_id = product_id;
            this.unit_price = unit_price;
            this.quantity = quantity;
            this.total_price = total_price;
            this.date = date;
            this.client = client;
        }
    }
}
