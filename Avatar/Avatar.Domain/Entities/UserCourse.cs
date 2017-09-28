namespace Avatar.Domain.Entities
{
    public class UserCourse
    {
        #region Constructors
        public UserCourse()
        {

        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public int IdCourse { get; set; }
        public int IdUser { get; set; }

        public virtual User User { get; set; }
        public virtual Course Course { get; set; }
        #endregion

    }
}
