namespace OrderManagement.BL
{
    public abstract class BaseClass
    {
        public bool IsItsNew { get; set; }
        public bool HasChanges { get; set; }
        public bool DataIsCorrect 
        { 
            get 
            {
                return Validate();
            } 
        }
        public ObjectStatusOption ObjectStatus { get; set; }

        public abstract bool Validate();
    }

    public enum ObjectStatusOption
    {
        Active,
        Deleted
    }
}