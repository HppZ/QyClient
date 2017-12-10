using System.Collections.Generic;
using QyClient.Core.DAL.Interface;
using QyClient.Core.Manager.Interface;
using QyClient.Core.Model;

namespace QyClient.Core.Manager.DownloadManager
{
    class DownloadManager:IDownloadManager
    {
        private IDownloadRecordRepository _repository;
        public DownloadManager(IDownloadRecordRepository repository)
        {
            _repository = repository;
        }


        public List<DownloadRecord> GetDownloadRecords()
        {
            var result = new List<DownloadRecord>();
            var records = _repository.GetDownloadRecords();
            foreach (var downloadItemEntity in records)
            {
                result.Add(new DownloadRecord()
                {
                    // ...
                });
            }

            return result;
        }

        public void SyncRecords()
        {

        }


    }
}
