using System;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            SweetTooth st = new SweetTooth();
            SpiceHound sh = new SpiceHound();
            while(st.IsFull == false && buffet.Menu.Count > 0)
            {
                IConsumable item = buffet.Serve();
                st.Consume(item);
            }
            while(sh.IsFull == false && buffet.Menu.Count > 0)
            {
                IConsumable item = buffet.Serve();
                sh.Consume(item);
            }
            if(sh.ConsumptionHistory.Count > st.ConsumptionHistory.Count)
            {
                Console.WriteLine($"SpiceHound consumed the most from the buffet, {sh.ConsumptionHistory.Count} items!");
            }
            else
            {
                Console.WriteLine($"SweetTooth consumed the most from the buffet, {st.ConsumptionHistory.Count} items!");
            }
        }
    }
}
