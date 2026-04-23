using System;

namespace ShipmentApp
{

    class Shipment
    {

        protected float weight;
        protected float distance;

        public Shipment(float weight, float distance)
        {

            if (distance < 1)
            {
                Console.WriteLine("Error: la distancia debe ser de al menos 1 km.");
                distance = 1;
            }

            if (weight <= 0)
            {
                Console.WriteLine("Error: el peso debe ser positivo.");
                weight = 1;
            }

            this.weight = weight;
            this.distance = distance;
        }

        public virtual float CalculateCost()
        {
            return 0;
        }

        public virtual float CalculateCost(float aduana)
        {
            return CalculateCost() * (1 + aduana);
        }
    }


    class StandardShipment : Shipment
    {
        private int daysInWarehouse;

        public StandardShipment(float weight, float distance) : base(weight, distance)
        {
            daysInWarehouse = 0;
        }

        public StandardShipment(float weight, float distance, float aduana) : base(weight, distance)
        {
            daysInWarehouse = 0;
        }


        public override float CalculateCost()
        {
            return weight * distance * 0.05f;
        }


        public override float CalculateCost(float aduana)
        {
            return CalculateCost() * (1 + aduana);
        }


        public float CalculateWarehouseCost()
        {
            return daysInWarehouse * 10;
        }

        public void SetDaysInWarehouse(int days)
        {
            daysInWarehouse = days;
        }
    }


    class ExpressShipment : Shipment
    {
        public ExpressShipment(float weight, float distance) : base(weight, distance)
        {
        }


        public override float CalculateCost()
        {
            return weight * distance * 0.1f + 50;
        }


        public override float CalculateCost(float aduana)
        {
            return CalculateCost() * (1 + aduana);
        }

        public void PrioritizeShipment()
        {
            Console.WriteLine("El envio ha sido priorizado");
        }
    }
}
   
 