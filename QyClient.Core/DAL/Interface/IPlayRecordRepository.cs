using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QyClient.Core.DAL.Entity;

namespace QyClient.Core.DAL.Interface
{
    interface IPlayRecordRepository
    {

        List<PlayingRecordEntity> GetPlayRecords();


    }
}
