namespace HMI_MF.Models
{
    public class TagModel
    {
        // Properties
        private int ID { get; set; }
        private string TagName { get; set; }
        private int TagValue { get; set; }
       
        // Constructors
        public TagModel(string tagname, int tagValue)
        {
            this.TagName = tagname; 
            this.TagValue = tagValue;
        }
    }
}
