

namespace RequisiteService.Domain
{
   public  class Requisite
    {
        public int id { get; set; }
        public int ownerId { get; set; }
        public int requisiteTypeId { get; set; }
        public int value { get; set; }
        public bool isActivate { get; set; }
        public string createdAt { get; set; }
        public string updatedAt { get; set; }
        public bool isDelete { get; set; }

    }
}
