using System;
using System.Collections.Generic;

namespace BootCampApi.Controllers
{
    public class Singleton
    {
        public List<EventItem> items = new List<EventItem>()
        {
            new EventItem(0,"Lowlands",new DateTime(2019,04,26),"Legendary Artists from all over the world will come together!!", 22, "https://image.freepik.com/vrije-psd/moderne-banner-van-verfborstel-op-roze-achtergrond_24972-212.jpg"),
            new EventItem(1,"Lolapalooza",new DateTime(2019,11,30), "Lolapalooza is the best festival in the world!!", 220, "https://image.freepik.com/vrije-vector/decoratieve-gelukkige-de-groetachtergrond-van-het-holifestival_1017-17518.jpg"),
            new EventItem(2,"Grasspop",new DateTime(2020,11,01), "Grasspop is the best gathering for metal lovers!", 5, "https://image.freepik.com/vrije-vector/platte-carnaval-achtergrond_23-2148050075.jpg"),
            new EventItem(3,"Draaimolen", new DateTime(2019,05,05),"You love deep house go to draaimolen!", 10, "https://image.freepik.com/vrije-vector/abstracte-zwarte-vrijdagverkoop-met-de-achtergrond-van-de-inktplons_1017-15995.jpg"),
            new EventItem(4, "Pinkpop", new DateTime(2019,04,14) , "The best artists in the world come to this festival, you have the be here!", 420, "https://image.freepik.com/vrije-vector/chinese-nieuwe-jaar-elementen-achtergrond_23-2148011296.jpg"),
        }; 

        //new EventItem(4, "Maikel = top feest", DateTime.Now.AddDays(100), "Wij feesten dat maikel zo tof is, hij wil graag angular leren en is slim, daarom vieren wij dat! Inbegrepen in het pakket is maikel! Drank moet jeezelf betalen", 20),
        //    new EventItem(5, "Cas zijn angular party", DateTime.Now.AddDays(180), "Wil jij meer over angular leren en kaas eten! kom dan naar cas zijn angular party. Let wel op kaas is in dit geval niet in begrepen. Neem dus zelf kaas mee, met preferentie blauwe schimmelkaas",605)

        private static Singleton instance = null;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}
