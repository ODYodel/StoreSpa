using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WalmartSpa.Models
{
    public class ProductRecommendationModel
    {
        public class BestMarketplacePrice
        {
            public double price { get; set; }
            public string sellerInfo { get; set; }
            public double standardShipRate { get; set; }
            public double twoThreeDayShippingRate { get; set; }
            public bool availableOnline { get; set; }
            public bool clearance { get; set; }
            public string offerType { get; set; }
        }

        public class Attributes
        {
            public string color { get; set; }
            public string isOrderable { get; set; }
            public string prodClassType { get; set; }
            public string requiresTextileActLabeling { get; set; }
            public string consumerItemNumber { get; set; }
            public string replenishmentStartDate { get; set; }
            public string size { get; set; }
            public string mainimageurl { get; set; }
            public string chokingHazardWarning { get; set; }
            public string finerCateg { get; set; }
            public string isImport { get; set; }
            public string ppuQty { get; set; }
            public string hasWarranty { get; set; }
            public string isReplenishable { get; set; }
            public string pesticideInd { get; set; }
            public string ironBankCategory { get; set; }
            public string velocityClassification { get; set; }
            public string hasStateRestrictions { get; set; }
            public string multipackQuantity { get; set; }
            public string compositeWood { get; set; }
            public string storeSharedSHEligibility { get; set; }
            public string gender { get; set; }
            public string isPvtLabelUnbranded { get; set; }
            public string mirrorNum { get; set; }
        }

        public class ImageEntity
        {
            public string thumbnailImage { get; set; }
            public string mediumImage { get; set; }
            public string largeImage { get; set; }
            public string entityType { get; set; }
        }

        public class GiftOptions
        {
            public bool allowGiftWrap { get; set; }
            public bool allowGiftMessage { get; set; }
            public bool allowGiftReceipt { get; set; }
        }

        public class RootObject
        {
            public int itemId { get; set; }
            public int parentItemId { get; set; }
            public string name { get; set; }
            public double msrp { get; set; }
            public double salePrice { get; set; }
            public string upc { get; set; }
            public string categoryPath { get; set; }
            public string shortDescription { get; set; }
            public string longDescription { get; set; }
            public string brandName { get; set; }
            public string thumbnailImage { get; set; }
            public string mediumImage { get; set; }
            public string largeImage { get; set; }
            public string productTrackingUrl { get; set; }
            public bool ninetySevenCentShipping { get; set; }
            public double standardShipRate { get; set; }
            public string color { get; set; }
            public bool shipToStore { get; set; }
            public bool freeShipToStore { get; set; }
            public string modelNumber { get; set; }
            public string productUrl { get; set; }
            public string customerRating { get; set; }
            public int numReviews { get; set; }
            public string customerRatingImage { get; set; }
            public BestMarketplacePrice bestMarketplacePrice { get; set; }
            public string categoryNode { get; set; }
            public string rhid { get; set; }
            public bool bundle { get; set; }
            public bool clearance { get; set; }
            public bool preOrder { get; set; }
            public string stock { get; set; }
            public Attributes attributes { get; set; }
            public string gender { get; set; }
            public string age { get; set; }
            public string addToCartUrl { get; set; }
            public string affiliateAddToCartUrl { get; set; }
            public bool freeShippingOver35Dollars { get; set; }
            public List<ImageEntity> imageEntities { get; set; }
            public string offerType { get; set; }
            public bool isTwoDayShippingEligible { get; set; }
            public bool availableOnline { get; set; }
            public GiftOptions giftOptions { get; set; }
            public string size { get; set; }
            public bool? marketplace { get; set; }
            public string sellerInfo { get; set; }
        }
    }
}
