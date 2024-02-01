namespace Store_Application
{
    interface Items
    {
        void Add(Items i);
        void Fetch();
        int Remove(string name, int quantity, out int remain_qty);
        void BuyProduct(string name, int qty);

    }
}
