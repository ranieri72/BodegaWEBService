using System;
using System.Collections.Generic;

namespace ClassLibrary.Model
{
    public class Sales
    {
        private long id;
        private bool open;
        private DateTime openedDateTime;
        private DateTime closedDateTime;
        private User user;
        private List<SaleItems> listSaleItems;

        public long Id { get => id; set => id = value; }
        public bool Open { get => open; set => open = value; }
        public DateTime OpenedDateTime { get => openedDateTime; set => openedDateTime = value; }
        public DateTime ClosedDateTime { get => closedDateTime; set => closedDateTime = value; }
        public User User { get => user; set => user = value; }
        public List<SaleItems> ListSaleItems { get => listSaleItems; set => listSaleItems = value; }
    }
}
