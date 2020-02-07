using System;
using System.Collections.Generic;
using System.Text;
using ProcessesInCreatio.DataModel.Documents.Bids;

namespace ProcessesInCreatio.DataModel.Documents
{
    /// <summary> Общая заявка на закупку ТМЦ </summary>
    public class Doc_BidForPurchase<T> : Doc_Base where T : IDocItem_BidForPurchase
    {
        /// <summary> Компания-заказчик </summary>
        public Company CustomerCompany { get; set; }

        /// <summary> Инициатор заявки </summary>
        public Employee Initiator { get; set; }

        /// <summary> Срок поставки (поставить до) </summary>
        public DateTime DeliveryTime { get; set; }

        /// <summary> Позиции заявки </summary>
        public List<T> BidPositions { get; set; }

        public Doc_BidForPurchase()
        {
            BidPositions = new List<T>();
        }
    }
}
