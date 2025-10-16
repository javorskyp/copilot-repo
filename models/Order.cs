   /// <summary>
   /// Reprezentuje zamówienie w systemie.
   /// </summary>
   public class Order
   {
       public int Id { get; set; }
       public string Product { get; set; } = string.Empty;
       public decimal Price { get; set; }

       /// <summary>
       /// Waliduje zamówienie: cena musi być większa od zera.
       /// </summary>
       public bool IsValid()
       {
           return Price > 0;
       }
   }