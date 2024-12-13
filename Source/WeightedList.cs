using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace BackroomsGenV1_1NET4_5
{
    class WeightedList<T> where T : RoomData
    {
        public struct WItem
        {
            public T Item;
            public float Weight;
            public Dictionary<string, float> OverrideWeights;

            public WItem(T item, float weight, Dictionary<string, float> overrideWeights)
            {
                this.Item = item;
                this.Weight = weight;
                this.OverrideWeights = overrideWeights;
            }
        }

        private List<WItem> wItems;
        private float totalWeight;

        public WeightedList()
        {
            wItems = new List<WItem>();
            totalWeight = 0;
        }

        public void AddItem(T item, float weight, Dictionary<string, float> overrideWeights)
        {
            float newWeight = weight + totalWeight;
            WItem wi = new WItem(item, newWeight, overrideWeights);
            totalWeight += weight;

            wItems.Add(wi);
        }

        public T GetRandItem(string placerRoomName)
        {
            //calc override total weight and
            //get the override weight
            float orTotalWeight = 0;
            float[] newWeights = new float[wItems.Count];
            float lastWeight = 0;
            for (int i = 0; i < wItems.Count; i++)
            {
                if (wItems[i].OverrideWeights.ContainsKey(placerRoomName))
                {
                    if(wItems[i].OverrideWeights[placerRoomName] == -1) //guaranteed chance of weight is sentinal value of -1
                        return wItems[i].Item;

                    newWeights[i] = wItems[i].OverrideWeights[placerRoomName] + orTotalWeight;

                    orTotalWeight += wItems[i].OverrideWeights[placerRoomName];
                }
                else
                {
                    float trueWeight = wItems[i].Weight - lastWeight; //get real weight of number (without +totalWeight)
                    newWeights[i] += trueWeight + orTotalWeight;
                    orTotalWeight += trueWeight;
                }

                lastWeight = wItems[i].Weight;
            }

            float rand = UnityEngine.Random.value * orTotalWeight;

            for (int i = 0; i < wItems.Count; i++)
            {
                if (newWeights[i] >= rand)
                    return wItems[i].Item;

            }

            SdtdConsole.Instance.Output("Rand: " + rand + ", orTotalWeight: " + orTotalWeight + ", newWeight: " + newWeights);

            return default(T);
        }
    }
}
