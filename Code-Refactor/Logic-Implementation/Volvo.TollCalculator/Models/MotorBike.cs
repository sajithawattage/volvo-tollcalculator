﻿namespace Volvo.TollCalculator.Models
{
    public class MotorBike : Vehicle
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
