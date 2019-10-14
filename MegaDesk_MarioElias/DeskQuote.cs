using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk_MarioElias
{
    public class DeskQuote  
    {
        public DeskQuote()
        {
            getRushOrderPrices();
        }

        private int[,] _rushOrderPrices;
        public enum Delivery
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Normal14Days
        }

        private const decimal BASE_DESK_PRICE = 200;
        private const decimal SURFACE_AREA_COST = 1;


        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public Delivery ShippingType { get; set; }

        public decimal QuotePrice { get; set; }

        public Desk Desk { get; set; }

        public decimal GetQuote()
        {
            //TODO: add logic to calculate price
            decimal runningTotal = 0;

            //add base price
            runningTotal = BASE_DESK_PRICE;

            //add surface area
            var surfaceArea = this.Desk.Width * this.Desk.Depth;

            var surfaceAreaPrice = 0M;

            if (surfaceArea > 1000)
            {
                surfaceAreaPrice = (surfaceArea - 1000) * SURFACE_AREA_COST;
            }
            runningTotal += surfaceAreaPrice;

            //add drawer
            var drawerCost = this.Desk.NumberOfDrawers * 50;

            runningTotal += drawerCost;

            //add shipping method
            var surfaceMaterialCost = 0M;

            switch (this.Desk.Material)
            {
                case Desk.Surface.Oak:
                    surfaceMaterialCost = 50;
                    break;
                case Desk.Surface.Laminate:
                    surfaceMaterialCost = 50;
                    break;
            }

            runningTotal += surfaceMaterialCost;

            return runningTotal;
        }

            private void getRushOrderPrices()
            {
                _rushOrderPrices = new int[3, 3];

                var pricesFile = @"rushOrderPrices.txt";

                try
                {
                    string[] prices = File.ReadAllLines(pricesFile);
                    int i = 0, j = 0;
                    foreach(string price in prices)
                    {
                        if(j == 2)
                        {
                            i++;
                            j = 0;
                        }
                        else
                        {
                            j++;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }

        }
    };

