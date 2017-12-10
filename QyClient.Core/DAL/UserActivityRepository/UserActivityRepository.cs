using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QyClient.Core.DAL.Entity;
using QyClient.Core.DAL.Interface;
using QyClient.Core.Manager.Interface;
using QyClient.Core.Model;

namespace QyClient.Core.DAL.UserActivityRepository
{
    class UserActivityRepository : IDownloadRecordRepository, IUserLikeRepository, IPlayRecordRepository
    {
        
        public List<LikeRecordEntity> GetLikeRecords()
        {
            // access db
            return null;
        }

        public List<PlayingRecordEntity> GetPlayRecords()
        {
            // access db
            return null;
        }


        public List<DownloadRecordEntity> GetDownloadRecords()
        {
            // access db
            return null;
        }



    }
}
