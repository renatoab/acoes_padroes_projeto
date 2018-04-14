using System;
using System.Collections.Generic;
using System.Text;

namespace Acoes
{
    public class ResultsMemento
    {
        private Dictionary<string, int> _assetTotalQuantity;
        private Dictionary<string, double> _assetTotalValue;
        private Dictionary<string, double> _assetUnitValue;


        public Dictionary<string, int> AssetTotalQuantity
        {
            get { return _assetTotalQuantity; }
        }
        public Dictionary<string, double> AssetTotalValue
        {
            get { return _assetTotalValue; }
        }
        public Dictionary<string, double> AssetUnitValue
        {
            get { return _assetUnitValue; }
        }


        public ResultsMemento(Results res)
        {
            _assetTotalQuantity = CloneDictionary(res.AssetTotalQuantity);
            _assetTotalValue = CloneDictionary(res.AssetTotalValue);
            _assetUnitValue = CloneDictionary(res.AssetUnitValue);
        }

        public static Dictionary<string, int> CloneDictionary(Dictionary<string, int> original)
        {
            Dictionary<string, int> ret = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> entry in original)
            {
                ret.Add(entry.Key, entry.Value);
            }
            return ret;
        }

        public static Dictionary<string, double> CloneDictionary(Dictionary<string, double> original)
        {
            Dictionary<string, double> ret = new Dictionary<string, double>();

            foreach (KeyValuePair<string, double> entry in original)
            {
                ret.Add(entry.Key, entry.Value);
            }
            return ret;
        }
    }
}
