﻿namespace Volvo.TollCalculator.Models
{
    public class Emergency : Vehicle
    {
        public override bool VehicleTollFree
        {
            get
            {
                return true;
            }
        }
    }
}
