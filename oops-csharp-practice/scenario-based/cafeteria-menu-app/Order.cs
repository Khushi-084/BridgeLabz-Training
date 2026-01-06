using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.CafeteriaMenuApp{
    internal class Order{
        //method to calculate item cost
    public int CalculateItemCost(int price, int quantity){
            return price * quantity;
        }
    //method to get item by index
    public bool IsValidIndex(int index, int length){
            return index >= 0 && index < length;
        }
    }
}
