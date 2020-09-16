using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIOMatic.Attributes;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace uBay.Core.Models
{
    [UIOMatic("bids", "Bids", "Bid", FolderIcon = "icon-users", ItemIcon = "icon-user", 
        RenderType = UIOMatic.Enums.UIOMaticRenderType.List)]
    [TableName("Bids")]
    public class Bid
    {
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int Id { get; set; }

        [UIOMaticListViewField]
        [UIOMaticField(Name = "Received", View = UIOMatic.Constants.FieldEditors.DateTimeUtc)]
        public DateTime ReceivedOnUtc { get; set; }

        [UIOMaticField(Name = "TransactionId", View = UIOMatic.Constants.FieldEditors.Label)]
        public Guid TransactionId { get; set; }

        [UIOMaticListViewField]
        [UIOMaticField(Name = "AuctionId", View = UIOMatic.Constants.FieldEditors.PickerContent)]
        public int AuctionId { get; set; }

        [UIOMaticListViewField]
        [UIOMaticField(Name = "BidderId", View = UIOMatic.Constants.FieldEditors.PickerMember)]
        public int BidderId { get; set; }

        [UIOMaticListViewField]
        [UIOMaticField(Name = "Amount")]
        public double Amount { get; set; }

        public bool? Accepted { get; set; }
    }
}
