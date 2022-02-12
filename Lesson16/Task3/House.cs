using System;

namespace Lesson16
{
    public class House : ICloneable
    {
        private int roomQuantity;
        private string houseName;
        
        public int RoomQuantity
        {
            get { return roomQuantity; }
            set { roomQuantity = value; }
        }

        public string HouseName
        {
            get { return houseName; }
            set { houseName = value; }
        }
       
        public House(int roomQuantity, string houseName)
        {
            this.roomQuantity = roomQuantity;
            this.houseName = houseName;
        }

        public object Clone() => new House(roomQuantity, houseName);

        public House DeepCopy(House house)
        {
            roomQuantity = house.roomQuantity;
            houseName = house.HouseName;
            return house;
        }
        
        public override string ToString()
        {
            return roomQuantity + ", " + houseName;
        }

        public static House operator +(House house1, House house2)
        {
            return new House(house1.RoomQuantity + house2.RoomQuantity, "Penthaus");
        }
    }
}
