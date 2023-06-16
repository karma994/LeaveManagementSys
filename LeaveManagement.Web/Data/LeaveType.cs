namespace LeaveManagement.Web.Data
{
    public class LeaveType : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        
    }
}
