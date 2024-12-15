using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTrader
{
    public interface ITradeProcessor
    {
        protected abstract IEnumerable<string> ReadTradeData(Stream stream);

        protected abstract IEnumerable<TradeRecord> ParseTrades(IEnumerable<string> tradeData);


        

        protected abstract void StoreTrades(IEnumerable<TradeRecord> trades);

        


    }
}
