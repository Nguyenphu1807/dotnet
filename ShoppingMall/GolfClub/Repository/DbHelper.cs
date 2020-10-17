using GolfClub.DAL;
using GolfClub.Model;

namespace GolfClub.Repository
{
    public class DbHelper
    {
        public Member PostMemberDetails(Member memberModel)
        {
            ClubMemberDbManager dbInstance = new ClubMemberDbManager();
            return dbInstance.CreateMember(memberModel);
        }
    }
}