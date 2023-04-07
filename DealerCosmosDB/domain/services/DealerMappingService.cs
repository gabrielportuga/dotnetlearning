
using System.Text.Json;
using DelearCosmosbd.domain.models;
using DelearCosmosbd.infrastructure.configurations;
using Microsoft.Azure.Cosmos;

namespace DelearCosmosbd.domain.services
{
    public class DealerMappingService : IDealerMappingService
    {
        private Database _database;
        
        private Container _container;
        private CosmosClient cosmosClient;
        private Dictionary<string, string> _parameters;

        public DealerMappingService(LibSettings libSettings)
        {
            cosmosClient = new CosmosClient(libSettings.EndPointUrlCosmosDb, libSettings.PrimarykeyCosmosDb);

            this._database = cosmosClient.GetDatabase(libSettings.DatabaseId);
            this._container = this._database.GetContainer(libSettings.ContainerId);
            this._parameters = new Dictionary<string, string>();
        }

        public async Task<IEnumerable<VendorSummary>> GetVendorSummary()
        {
            var sqlQueryText = "SELECT c.vendor_key AS Vendor, COUNT(1) AS Quantity FROM c GROUP BY c.vendor_key";
            IEnumerable<VendorSummary> vendorSummary = await MapDataTo(GetQueryResultSetIterator<VendorSummary>(sqlQueryText));

            return vendorSummary;
        }

        public async Task<IEnumerable<DealerMapping>> GetDealers()
        {
            var sqlQueryText = "SELECT * FROM c ORDER BY c.vendor_key";
            List<DealerMapping> dealers = await MapDataTo(GetQueryResultSetIterator<DealerMapping>(sqlQueryText));
            return dealers;
        }

        public async Task<DealerMapping> GetDealer(string mapping_id)
        {
            var sqlQueryText = "SELECT * FROM c WHERE UPPER(c.mapping_id) = @mapping_id";
            AddParameters("@mapping_id", mapping_id.Trim().ToUpper());

            List<DealerMapping> dealers = await MapDataTo(GetQueryResultSetIterator<DealerMapping>(sqlQueryText));
            return dealers.FirstOrDefault()!;
        }

        public async Task<IEnumerable<DealerMapping>> GetDealers(string vendorName)
        {
            var sqlQueryText = "SELECT * FROM c WHERE UPPER(c.vendor_key) = @vendor ORDER BY c.mapping_id";
            AddParameters("@vendor", vendorName.Trim().ToUpper());

            List<DealerMapping> dealers = await MapDataTo(GetQueryResultSetIterator<DealerMapping>(sqlQueryText));
            return dealers;
        }

        public async Task<IEnumerable<DealerMapping>> GetDealersByCountry(string countryCode)
        {

            var sqlQueryText = $"SELECT * FROM c WHERE UPPER(c.country) = UPPER('{countryCode}')";

            QueryDefinition queryDefinition = new QueryDefinition(sqlQueryText);

            FeedIterator<DealerMapping> queryResultSetIterator = _container.GetItemQueryIterator<DealerMapping>(queryDefinition);

            List<DealerMapping> dealers = new List<DealerMapping> ();

            while (queryResultSetIterator.HasMoreResults) {
                FeedResponse<DealerMapping> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                foreach(DealerMapping dealer in currentResultSet) {
                    dealers.Add(dealer);
                }
            }

            return dealers;
        }

        public async Task<Dictionary<int, IEnumerable<DealerMapping>>> UpdateCbsMapping(string countryCode)
        {
            var dealers = await GetDealersByCountry(countryCode);
            var dealersUpdated = new List<DealerMapping>();

            foreach (var item in dealers)
            {
                item.cbs_codes = new Dictionary<string, string[]>();
                item.cbs_codes.Add("OIL", new string[]{"0000610", "0000616"});
                item.cbs_codes.Add("BRAKE_PADS_FRONT", new string[]{"0000612"});
                item.cbs_codes.Add("BRAKE_PADS_REAR", new string[]{"0000614"});
                item.cbs_codes.Add("BRAKE_FLUID", new string[]{"0000618"});

                var dealer = await this.UpdateData(item);
                dealersUpdated.Add((await UpdateData(dealer)));
            }

            var result = new Dictionary<int, IEnumerable<DealerMapping>>();

             result.Add(dealersUpdated.Count, dealersUpdated);

             return result;
        }
        public async Task<DealerMapping> UpdateData(DealerMapping dealer)
        {
            //var objJson = JsonSerializer.Serialize(dealer);
            return await _container.ReplaceItemAsync<DealerMapping>(dealer, dealer.id, new PartitionKey(dealer.vendor_key)); 
        }

        #region structure
        private void CleanParameters()
        {
            _parameters.Clear();
        }

        private void AddParameters(string key, string value)
        {
            _parameters.Add(key, value);
        }

        private FeedIterator<T> GetQueryResultSetIterator<T>(string sqlCommand)
        {
            QueryDefinition queryDefinition = new QueryDefinition(sqlCommand);
            foreach (var entry in _parameters)
            {
                queryDefinition.WithParameter(entry.Key, entry.Value);
            }

            CleanParameters();

            return _container.GetItemQueryIterator<T>(queryDefinition);
        }

        private async Task<List<T>> MapDataTo<T>(FeedIterator<T> queryResultSetIterator)
        {
            List<T> listReturn = new List<T>();
            while (queryResultSetIterator.HasMoreResults)
            {
                FeedResponse<T> currentResultSet = await queryResultSetIterator.ReadNextAsync();
                foreach (T data in currentResultSet)
                {
                    listReturn.Add(data);
                }
            }

            return listReturn;
        }
        #endregion
    }
    
}