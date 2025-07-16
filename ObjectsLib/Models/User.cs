using System;
using System.Collections.Generic;

namespace LibPull.Objects.EntityFrameworkCore
{
    public partial class User
    {
        public User()
        {
            Confection = new HashSet<Confection>();
            DeliveryAlertAddedByUser = new HashSet<DeliveryAlert>();
            DeliveryAlertConfirmedByUser = new HashSet<DeliveryAlert>();
            DeliveryAlertRecipient = new HashSet<DeliveryAlert>();
            Log = new HashSet<Log>();
            MessageRecipient = new HashSet<Message>();
            MessageSender = new HashSet<Message>();
            NotificationRecipient = new HashSet<Notification>();
            NotificationSender = new HashSet<Notification>();
            OrderSchedule = new HashSet<OrderSchedule>();
            PullOrder = new HashSet<PullOrder>();
            SystemMessageCreatedBy = new HashSet<SystemMessage>();
            SystemMessageProcessedBy = new HashSet<SystemMessage>();
            SystemMessageSeenBy = new HashSet<SystemMessage>();
            SystemOperations = new HashSet<SystemOperations>();
            Vehicle = new HashSet<Vehicle>();
            VehicleLocationHistory = new HashSet<VehicleLocationHistory>();
            Transfer = new HashSet<Transfer>();
            PreassemblyHistory = new HashSet<PreassemblyHistory>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public int PermissionId { get; set; }
        public int? LanguageId { get; set; }
        public DateTime LastSeen { get; set; }
        public string AvatarUrl { get; set; }
        public bool? Active { get; set; }
        public string AccessToken { get; set; }
        public DateTime? LastChatActivity { get; set; }
        public int? LineSetId { get; set; }
        public int? PartSetSetId { get; set; }
        public int? LastVehicleId { get; set; }

        public virtual Language Language { get; set; }
        public virtual Vehicle LastVehicle { get; set; }
        public virtual LineSet LineSet { get; set; }
        public virtual ICollection<Log> Log { get; set; }
        public virtual PartSetSet PartSetSet { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual ICollection<Confection> Confection { get; set; }
        public virtual ICollection<DeliveryAlert> DeliveryAlertAddedByUser { get; set; }
        public virtual ICollection<DeliveryAlert> DeliveryAlertConfirmedByUser { get; set; }
        public virtual ICollection<DeliveryAlert> DeliveryAlertRecipient { get; set; }
        public virtual ICollection<Message> MessageRecipient { get; set; }
        public virtual ICollection<Message> MessageSender { get; set; }
        public virtual ICollection<Notification> NotificationRecipient { get; set; }
        public virtual ICollection<Notification> NotificationSender { get; set; }
        public virtual ICollection<OrderSchedule> OrderSchedule { get; set; }
        public virtual ICollection<PullOrder> PullOrder { get; set; }
        public virtual ICollection<SystemMessage> SystemMessageCreatedBy { get; set; }
        public virtual ICollection<SystemMessage> SystemMessageProcessedBy { get; set; }
        public virtual ICollection<SystemMessage> SystemMessageSeenBy { get; set; }
        public virtual ICollection<SystemOperations> SystemOperations { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
        public virtual ICollection<VehicleLocationHistory> VehicleLocationHistory { get; set; }
        public virtual ICollection<Transfer> Transfer { get; set; }
        public virtual ICollection<PreassemblyHistory> PreassemblyHistory { get; set; }
    }
}
